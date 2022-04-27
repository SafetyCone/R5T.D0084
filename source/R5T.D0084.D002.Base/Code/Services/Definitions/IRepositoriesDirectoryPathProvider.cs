using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D002
{
    /// <summary>
    /// Provides the repositories directory path with no further assumptions.
    /// The repositories directory path is the directory containing all repositories (each cloned repository exists as a child directory of this directory).
    /// </summary>
    /// <remarks>
    /// * Parameterless.
    /// * Stringly-typed.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IRepositoriesDirectoryPathProvider
    {
        Task<string> GetRepositoriesDirectoryPath();
    }
}
