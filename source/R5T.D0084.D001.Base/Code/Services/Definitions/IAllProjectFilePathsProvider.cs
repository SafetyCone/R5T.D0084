using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Get all project file paths, with no further assumptions on the source of the project file paths.
    /// Parameterless, stringly-typed.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllProjectFilePathsProvider : IServiceDefinition
    {
        Task<string[]> GetAllProjectFilePaths();
    }
}
