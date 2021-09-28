using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Dacia;

using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    [ServiceImplementationMarker]
    public class AllSolutionDirectoryPathsProvider : IAllSolutionDirectoryPathsProvider
    {
        private IAllRepositoryDirectoryPathsProvider AllRepositoryDirectoryPathsProvider { get; }
        private ISolutionDirectoryPathProvider SolutionDirectoryPathProvider { get; }


        public AllSolutionDirectoryPathsProvider(
            IAllRepositoryDirectoryPathsProvider allRepositoryDirectoryPathsProvider,
            ISolutionDirectoryPathProvider solutionDirectoryPathProvider)
        {
            this.AllRepositoryDirectoryPathsProvider = allRepositoryDirectoryPathsProvider;
            this.SolutionDirectoryPathProvider = solutionDirectoryPathProvider;
        }

        public async Task<string[]> GetAllSolutionDirectoryPaths()
        {
            var allRepositoryDirectoryPaths = await this.AllRepositoryDirectoryPathsProvider.GetAllRepositoryDirectoryPaths();

            var solutionDirectoryPaths = new List<string>();
            foreach (var repositoryDirectoryPath in allRepositoryDirectoryPaths)
            {
                var solutionDirectoryPath = await this.SolutionDirectoryPathProvider.GetSolutionDirectoryPath(repositoryDirectoryPath);

                solutionDirectoryPaths.Add(solutionDirectoryPath);
            }

            var output = solutionDirectoryPaths.ToArray();
            return output;
        }
    }
}
