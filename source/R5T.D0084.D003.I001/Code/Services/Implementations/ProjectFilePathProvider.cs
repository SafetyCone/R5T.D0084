using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0084.D003.I001
{
    [ServiceImplementationMarker]
    public class ProjectFilePathProvider : IProjectFilePathProvider, IServiceImplementation
    {
        public Task<WasFound<string>> GetProjectFilePath(string projectDirectoryPath)
        {
            var projectFilePath = Instances.FileSystemOperator.FindFileInDirectoryByFileExtension(
                projectDirectoryPath,
                Instances.FileExtension.CSharpProjectFile());

            var output = WasFound.From(projectFilePath);

            return Task.FromResult(output);
        }
    }
}
