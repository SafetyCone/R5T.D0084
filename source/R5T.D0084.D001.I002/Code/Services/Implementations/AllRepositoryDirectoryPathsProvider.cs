using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Dacia;

using R5T.D0084.D002;


namespace R5T.D0084.D001.I002
{
    [ServiceImplementationMarker]
    public class AllRepositoryDirectoryPathsProvider : IAllRepositoryDirectoryPathsProvider
    {
        private IRepositoriesDirectoryPathProvider RepositoriesDirectoryPathProvider { get; }


        public AllRepositoryDirectoryPathsProvider(
            IRepositoriesDirectoryPathProvider repositoriesDirectoryPathProvider)
        {
            this.RepositoriesDirectoryPathProvider = repositoriesDirectoryPathProvider;
        }

        public async Task<string[]> GetAllRepositoryDirectoryPaths()
        {
            var repositoriesDirectoryPath = await this.RepositoriesDirectoryPathProvider.GetRepositoriesDirectoryPath();

            var output = Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(
                repositoriesDirectoryPath)
                .ToArray();

            return output;
        }
    }
}
