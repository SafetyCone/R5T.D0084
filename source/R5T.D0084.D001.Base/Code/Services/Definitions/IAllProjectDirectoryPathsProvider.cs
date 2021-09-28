using System;
using System.Threading.Tasks;

using R5T.Dacia;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Provides all project directory paths, with no further assumptions.
    /// Parameterless.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllProjectDirectoryPathsProvider
    {
        Task<string[]> GetAllProjectDirectoryPaths();
    }
}
