using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Diagnostics;
//using DocsByReflection;

namespace reflect_doc
{
    class Program
    {
        private static Type [] GetEntityType(string typeName, Assembly[] assemblies)
        {
            //List<System.Reflection.Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var result = new List<Type>();

            foreach (var assembly in assemblies)
            {
                Console.WriteLine("=========");
                Console.WriteLine("Assembly: " + assembly.FullName);
                            
                try
                {
                    var types = assembly.GetTypes();
                    Console.WriteLine("Types count: " + types.Length);
                    Console.WriteLine("=========");
                    foreach (var type in types)
                    {
                        //Console.WriteLine(type.Name);
                        if (string.IsNullOrEmpty(typeName) || 
                            type.Name.IndexOf(typeName, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine("Type: " + type.Name);
                            Console.WriteLine("Namespace: " + type.Namespace);
                            Console.WriteLine("Assembly: " + type.Assembly.FullName);
                            Console.WriteLine("------------");
                            result.Add(type);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    continue;
                }
            }

            if(result.Count == 0)
            {
                Console.WriteLine("Type " + typeName + " doesn't exist in the current app domain");
                Environment.Exit(1);
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("reflect_doc <type name> <assembly file>");
                Console.WriteLine("reflect_doc <assembly directory> <assembly file>");
                return;
            }

            //List<System.Reflection.Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            List<System.Reflection.Assembly> assemblies = new List<System.Reflection.Assembly>();
            var typePattern = args[0];
            if (args.Length == 1)
            {
                var dir = args[0];
                var files = Directory.GetFiles(dir, "*.dll", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    assemblies.Add(Assembly.LoadFrom(file));
                }
                typePattern = "";
            }
            else if (args.Length == 2)
            {
                if (File.Exists(args[1]))
                {
                    Assembly assembly = Assembly.LoadFrom(args[1]);
                    Console.WriteLine(" + Loaded assembly: " + assembly.FullName);
                    assemblies = new List<Assembly>() { assembly };
                    //DocsByReflection.Docs.GenerateDocs(type, assembly);
                }
                else
                {
                    Console.WriteLine("Assembly file " + args[1] + " doesn't exist");
                    Environment.Exit(1);
                }
            }
            else if (args.Length == 3)
            {
                Console.WriteLine("Loaded assembly: ");

                if (Directory.Exists(args[1]))
                {
                    var files = Directory
                        .GetFiles(args[1], "*.dll", SearchOption.AllDirectories)
                        .Where(f => Path.GetFileName(f).StartsWith(args[2]))
                        .GroupBy(f => Path.GetFileName(f)).Select(g => g.First());

                    foreach (string file in files)
                    {
                        Assembly assembly = Assembly.LoadFrom(file);
                        Console.WriteLine("\t + " + assembly.FullName);
                        assemblies.Add(assembly);
                    }
                }
                else
                {
                    Console.WriteLine("Directory " + args[1] + " doesn't exist");
                    Environment.Exit(1);
                }

            }
            else
            {
                Console.WriteLine("Usage: reflect_doc <type name> <assembly file>");
                Environment.Exit(1);
            }

            Type[] types = GetEntityType(typePattern, assemblies.ToArray());
            if(string.IsNullOrEmpty(typePattern))
            {
                return;
            }

            foreach (var type in types)
            {
                var search = args.Length > 1 ? args[1] : null;

                FieldInfo[] fields = type.GetFields();
                if (fields.Length > 0)
                    Console.WriteLine("Fields: ");
                foreach (FieldInfo fi in fields)
                {
                    if (search == null || fi.Name.Contains(search))
                        Console.WriteLine("\t" + fi.Name);
                }

                ConstructorInfo[] constructors = type.GetConstructors();
                if (constructors.Length > 0)
                    Console.WriteLine("Constructors: ");

                foreach (ConstructorInfo ci in constructors)
                {
                    if (search == null || ci.Name.Contains(search))
                        Console.WriteLine("\t" + ci.Name);
                }

                MethodInfo[] methods = type.GetMethods();
                if (methods.Length > 0)
                    Console.WriteLine("Methods: ");
                foreach (MethodInfo mi in methods)
                {
                    if (search == null || mi.Name.Contains(search))
                        Console.WriteLine("\t" + mi.Name);
                }

                Type[] nestedTypes = type.GetNestedTypes();
                if (nestedTypes.Length > 0)
                    Console.WriteLine("Nested types: ");
                foreach (Type t in nestedTypes)
                {
                    if (search == null || t.Name.Contains(search))
                        Console.WriteLine("\t" + t.Name);
                }

                PropertyInfo[] properties = type.GetProperties();
                if (properties.Length > 0)
                    Console.WriteLine("Properties: ");
                foreach (PropertyInfo pi in properties)
                {
                    if (search == null || pi.Name.Contains(search))
                        Console.WriteLine("\t" + pi.Name);
                }

                MemberInfo[] members = type.GetMembers();
                if (members.Length > 0)
                    Console.WriteLine("Members type: ");
                foreach (MemberInfo mi in members)
                {
                    if (search == null || mi.Name.Contains(search))
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t{0}, name: {1}", mi.Name, mi.MemberType);
                        Console.WriteLine("\t" + mi);
                        try
                        {
                            //var methodDoc = DocsService.GetXmlFromMember(mi);
                            //Console.WriteLine("\t" + methodDoc.ToString());	
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
    }
}
