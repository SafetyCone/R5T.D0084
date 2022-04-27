using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D002.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedRepositoriesDirectoryPathProvider : IRepositoriesDirectoryPathProvider, IServiceImplementation
    {
        private string RepositoriesDirectoryPath { get; }


        public ConstructorBasedRepositoriesDirectoryPathProvider(
            [NotServiceComponent] string repositoriesDirectoryPath)
        {
            this.RepositoriesDirectoryPath = repositoriesDirectoryPath;
        }

        public Task<string> GetRepositoriesDirectoryPath()
        {
            return Task.FromResult(this.RepositoriesDirectoryPath);
        }
    }
}
