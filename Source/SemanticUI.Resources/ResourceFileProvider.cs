using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Sidea.SemanticUI.Resources
{
    public class ResourceFileProvider : IFileProvider
    {
        private const string _assemblyPath = "semantic";
        private ManifestEmbeddedFileProvider _provider = new ManifestEmbeddedFileProvider(typeof(ResourceFileProvider).Assembly);

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            var result = _provider.GetDirectoryContents(_assemblyPath + subpath);
            return result;
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            var result = _provider.GetFileInfo(_assemblyPath + subpath);
            return result;
        }

        public IChangeToken Watch(string filter)
        {
            var result = _provider.Watch(_assemblyPath + filter);
            return result;
        }
    }
}
