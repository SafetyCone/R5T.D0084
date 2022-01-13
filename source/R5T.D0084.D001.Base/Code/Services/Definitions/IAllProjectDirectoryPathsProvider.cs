using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Provides all project directory paths, with no further assumptions.
    /// Parameterless.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllProjectDirectoryPathsProvider : IServiceDefinition
    {
        Task<string[]> GetAllProjectDirectoryPaths();
    }
}
