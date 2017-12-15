using System.Reflection;
using System.IO;

namespace day07.tests
{
    public static class EmbeddedResourceReader
    {
        public static string Read(string embeddedResourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(embeddedResourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
