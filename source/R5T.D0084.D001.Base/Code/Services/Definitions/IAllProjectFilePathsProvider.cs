using System;
using System.Threading.Tasks;

using R5T.Dacia;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Get all project file paths, with no further assumptions on the source of the project file paths.
    /// Parameterless, stringly-typed.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllProjectFilePathsProvider
    {
        Task<string[]> GetAllProjectFilePaths();
    }
}
