using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D003
{
    /// <summary>
    /// Gets the solution directory path for a repository path.
    /// Assumes that a single solution directory path can be chosen from a repository directory path.
    /// </summary>
    /// <remarks>
    /// * Parameterized.
    /// * Stringly-typed.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface ISolutionDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetSolutionDirectoryPath(string repositoryDirectoryPath);
    }
}
