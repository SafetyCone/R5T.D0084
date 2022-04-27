using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;

using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    [ServiceImplementationMarker]
    public class AllProjectDirectoryPathsProvider : IAllProjectDirectoryPathsProvider, IServiceImplementation
    {
        private IAllSolutionDirectoryPathsProvider AllSolutionDirectoryPathsProvider { get; }
        private IProjectDirectoryPathsProvider ProjectDirectoryPathsProvider { get; }


        public AllProjectDirectoryPathsProvider(
            IAllSolutionDirectoryPathsProvider allSolutionDirectoryPathsProvider,
            IProjectDirectoryPathsProvider projectDirectoryPathsProvider)
        {
            this.AllSolutionDirectoryPathsProvider = allSolutionDirectoryPathsProvider;
            this.ProjectDirectoryPathsProvider = projectDirectoryPathsProvider;
        }

        public async Task<string[]> GetAllProjectDirectoryPaths()
        {
            var allSolutionDirectoryPaths = await this.AllSolutionDirectoryPathsProvider.GetAllSolutionDirectoryPaths();

            var allProjectDirectoryPaths = new List<string>();
            foreach (var solutionDirectoryPath in allSolutionDirectoryPaths)
            {
                var projectDirectoryPathsWereFound = await this.ProjectDirectoryPathsProvider.GetProjectDirectoryPaths(solutionDirectoryPath);

                if(projectDirectoryPathsWereFound)
                {
                    allProjectDirectoryPaths.AddRange(projectDirectoryPathsWereFound.Result);
                }
            }

            var output = allProjectDirectoryPaths.ToArray();
            return output;
        }
    }
}
