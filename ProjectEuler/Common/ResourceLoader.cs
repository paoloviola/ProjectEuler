using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectEuler.Common
{
    internal static class ResourceLoader
    {
        public static Stream? OpenResource(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream($"{typeof(ResourceLoader).Namespace!}.Resources.{name}");
        }

        public static byte[]? ReadResourceData(string name)
        {
            using var resource = OpenResource(name);
            if(resource == null)
            {
                return null;
            }

            using var memory = new MemoryStream();
            resource.CopyTo(memory);
            return memory.ToArray();
        }

        public static string? ReadResource(string name)
        {
            return ReadResource(name, Encoding.UTF8);
        }

        public static string? ReadResource(string name, Encoding encoding)
        {
            var data = ReadResourceData(name);
            if(data == null)
            {
                return null;
            }

            return encoding.GetString(data);
        }
    }
}
