using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D003.I002
{
    /// <summary>
    /// A solution directory path provider that provides the /source directory of the repository directory path.
    /// </summary>
    [ServiceImplementationMarker]
    public class SourceSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider, IServiceImplementation
    {
        public static string SourceDirectoryName => "source";


        public Task<string> GetSolutionDirectoryPath(string repositoryDirectoryPath)
        {
            var output = Instances.PathOperator.GetDirectoryPath(
                repositoryDirectoryPath,
                SourceSolutionDirectoryPathProvider.SourceDirectoryName);

            return Task.FromResult(output);
        }
    }
}
