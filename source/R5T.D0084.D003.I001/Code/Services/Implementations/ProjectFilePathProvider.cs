using System;
using System.Threading.Tasks;

using R5T.Dacia;
using R5T.Magyar;


namespace R5T.D0084.D003.I001
{
    [ServiceImplementationMarker]
    public class ProjectFilePathProvider : IProjectFilePathProvider
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
