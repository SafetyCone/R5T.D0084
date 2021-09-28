using System;
using System.Threading.Tasks;


namespace R5T.D0084.D002.I001
{
    public class ConstructorBasedRepositoriesDirectoryPathProvider : IRepositoriesDirectoryPathProvider
    {
        private string RepositoriesDirectoryPath { get; }


        public ConstructorBasedRepositoriesDirectoryPathProvider(
            string repositoriesDirectoryPath)
        {
            this.RepositoriesDirectoryPath = repositoriesDirectoryPath;
        }

        public Task<string> GetRepositoriesDirectoryPath()
        {
            return Task.FromResult(this.RepositoriesDirectoryPath);
        }
    }
}
