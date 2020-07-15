using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Sidea.SemanticUI.Core
{
    public class FileProvider : IFileProvider
    {
        private const string _assemblyPath = "css/semantic-ui";
        private ManifestEmbeddedFileProvider _provider = new ManifestEmbeddedFileProvider(typeof(FileProvider).Assembly);

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
