﻿using System;
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
        private static Type GetEntityType(string typeName, Assembly [] assemblies)
        {
            new Process();
            //List<System.Reflection.Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    //Console.WriteLine(type.Name);
                    if (type.Name == typeName)
                    {
                        Console.WriteLine("=========");
                        Console.WriteLine("Type: " + type.Name);
                        Console.WriteLine("Namespace: " + type.Namespace);
                        Console.WriteLine("=========");
                        return type;
                    }
                }
            }

            Console.WriteLine("Type " + typeName + " doesn't exist in the current app domain");
            Environment.Exit(1);
            return null;
        }

        static void Main(string[] args)
        {
			if(args.Length == 0)
			{
				Console.WriteLine("Usage: reflect_doc <type name> <assembly file>");
				return;
			}

            List<System.Reflection.Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            if(args.Length == 2)
			{
                if(File.Exists(args[1]))
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
            else if(args.Length == 3)
            {
                if(Directory.Exists(args[1]))
                {
                    var files = Directory
                        .GetFiles(args[1],"*.dll",SearchOption.AllDirectories)
                        .Where(f => Path.GetFileName(f).StartsWith(args[2]))
                        .GroupBy(f => Path.GetFileName(f)).Select(g => g.First());

                    foreach(string file in files)
                    {
                        Assembly assembly = Assembly.LoadFrom(file);
                        Console.WriteLine(" + Loaded assembly: " + assembly.FullName);
                        assemblies.Add(assembly);
                    }
                }
                else
                {
                    Console.WriteLine("Directory " + args[1] + " doesn't exist");
                    Environment.Exit(1);
                }
                Console.WriteLine(" + Loaded assembly: " + Assembly.GetExecutingAssembly().FullName);
                assemblies = new List<Assembly>() { Assembly.GetExecutingAssembly() };
            }
            else
            {
                Console.WriteLine("Usage: reflect_doc <type name> <assembly file>");
                Environment.Exit(1);
            }

            Type type = GetEntityType(args[0], assemblies.ToArray());
            
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

            File.Exists("test");

            // From type. https://github.com/giacomelli/DocsByReflection
            /*
			var typeDoc = DocsService.GetXmlFromType(typeof(Stub));
			
			// From property.
			var propertyInfo = typeof(Stub).GetProperty("PropertyWithDoc");
			var propertyDoc = DocsService.GetXmlFromMember(propertyInfo);
			
			// From method.
			var methodInfo = typeof(Stub).GetMethod("MethodWithGenericParameter");
			var methodDoc = DocsService.GetXmlFromMember(methodInfo);
			
			// From assembly.
			var assemblyDoc = DocsService.GetXmlFromAssembly(typeof(Stub).Assembly);
			*/
        }
    }
}
