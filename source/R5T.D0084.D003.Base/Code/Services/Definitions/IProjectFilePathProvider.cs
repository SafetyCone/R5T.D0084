using System;
using System.Threading.Tasks;

using R5T.Dacia;
using R5T.Magyar;


namespace R5T.D0084.D003
{
    /// <summary>
    /// Provides the project file path for a project file inside the specified project directory path.
    /// Assumes that a single project file path can be determined for a project directory path.
    /// </summary>
    /// <remarks>
    /// * Parameterized.
    /// * Stringly-typed.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IProjectFilePathProvider
    {
        Task<WasFound<string>> GetProjectFilePath(string projectDirectoryPath);
    }
}
