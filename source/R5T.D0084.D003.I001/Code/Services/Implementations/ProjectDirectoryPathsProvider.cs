using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0084.D003.I001
{
    [ServiceImplementationMarker]
    public class ProjectDirectoryPathsProvider : IProjectDirectoryPathsProvider, IServiceImplementation
    {
        public Task<WasFound<string[]>> GetProjectDirectoryPaths(string solutionDirectoryPath)
        {
            var solutionDirectoryExists = Instances.FileSystemOperator.DirectoryExists(solutionDirectoryPath);

            var values = solutionDirectoryExists
                ? Instances.FileSystemOperator.EnumerateAllChildDirectoryPaths(solutionDirectoryPath)
                    .ToArray()
                : Array.Empty<string>()
                ;

            var output = WasFound.From(solutionDirectoryExists, values);

            return Task.FromResult(output);
        }
    }
}
