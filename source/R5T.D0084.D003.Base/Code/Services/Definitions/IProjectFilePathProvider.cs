using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


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
    public interface IProjectFilePathProvider : IServiceDefinition
    {
        Task<WasFound<string>> GetProjectFilePath(string projectDirectoryPath);
    }
}
