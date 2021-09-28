using System;
using System.Threading.Tasks;

using R5T.Dacia;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Provides all repository directory paths.
    /// Parameterless.
    /// Makes no assumption about location or system or anything regarding repository directory paths.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllRepositoryDirectoryPathsProvider
    {
        Task<string[]> GetAllRepositoryDirectoryPaths();
    }
}
