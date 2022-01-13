using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0084.D001
{
    /// <summary>
    /// Provides all repository directory paths.
    /// Parameterless.
    /// Makes no assumption about location or system or anything regarding repository directory paths.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IAllRepositoryDirectoryPathsProvider : IServiceDefinition
    {
        Task<string[]> GetAllRepositoryDirectoryPaths();
    }
}
