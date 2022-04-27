using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;

using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    [ServiceImplementationMarker]
    public class AllProjectFilePathsProvider : IAllProjectFilePathsProvider, IServiceImplementation
    {
        private IAllProjectDirectoryPathsProvider AllProjectDirectoryPathsProvider { get; }
        private IProjectFilePathProvider ProjectFilePathProvider { get; }


        public AllProjectFilePathsProvider(
            IAllProjectDirectoryPathsProvider allProjectDirectoryPathsProvider,
            IProjectFilePathProvider projectFilePathProvider)
        {
            this.AllProjectDirectoryPathsProvider = allProjectDirectoryPathsProvider;
            this.ProjectFilePathProvider = projectFilePathProvider;
        }

        public async Task<string[]> GetAllProjectFilePaths()
        {
            var allProjectDirectoryPaths = await this.AllProjectDirectoryPathsProvider.GetAllProjectDirectoryPaths();

            var projectFilePaths = new List<string>();
            foreach (var projectDirectoryPath in allProjectDirectoryPaths)
            {
                var projectFilePathWasFound = await this.ProjectFilePathProvider.GetProjectFilePath(projectDirectoryPath);
                if (projectFilePathWasFound)
                {
                    projectFilePaths.Add(projectFilePathWasFound);
                }
            }

            var output = projectFilePaths.ToArray();
            return output;
        }
    }
}
