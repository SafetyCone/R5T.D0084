using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0084.D003
{
    /// <summary>
    /// Provides a project directory path from a solution directory path.
    /// Assumes that a set of project directory paths can be determined from a solution directory path.
    /// </summary>
    /// <remarks>
    /// * Parameterized.
    /// * Stringly-typed.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IProjectDirectoryPathsProvider : IServiceDefinition
    {
        Task<WasFound<string[]>> GetProjectDirectoryPaths(string solutionDirectoryPath);
    }
}