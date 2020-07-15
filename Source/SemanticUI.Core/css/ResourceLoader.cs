using System.IO;
using System.Reflection;

namespace Sidea.SemanticUI.Core.css
{
    public static class ResourceLoader
    {
        private static Assembly _assemlby = typeof(ResourceLoader).Assembly;

        public static string Load(string resourceFilePath)
        {
            var resourceName = resourceFilePath.Replace("/", ".");
            using Stream stream = _assemlby.GetManifestResourceStream(resourceName);
            using StreamReader reader = new StreamReader(stream);

            string result = reader.ReadToEnd();
            return result;
        }
    }
}
