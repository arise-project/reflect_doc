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
        private static Type GetEntityType(string typeName)
        {
            new Process();
            List<System.Reflection.Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            foreach (var assembly in assemblies)
            {
                Type t = assembly.GetType(typeName, false);
                if (t != null)
                    return t;
            }

            throw new ArgumentException(
                "Type " + typeName + " doesn't exist in the current app domain");
        }

        static void Main(string[] args)
        {
			if(args.Length == 0)
			{
				
				Console.WriteLine("Usage: reflect_doc <type name> <assembly file>");
				return;
			}

            Type type = GetEntityType(args[0]);

			if(args.Length == 2)
			{
				Assembly assembly = Assembly.LoadFrom(args[1]);
				//DocsByReflection.Docs.GenerateDocs(type, assembly);
			}

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
