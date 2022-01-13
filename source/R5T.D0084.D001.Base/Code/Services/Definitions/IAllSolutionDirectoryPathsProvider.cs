using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Provides all solution directory paths, with no further assumptions on the source of the solution directory paths.
    /// Parameterless, stringly-typed.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllSolutionDirectoryPathsProvider : IServiceDefinition
    {
        Task<string[]> GetAllSolutionDirectoryPaths();
    }
}
