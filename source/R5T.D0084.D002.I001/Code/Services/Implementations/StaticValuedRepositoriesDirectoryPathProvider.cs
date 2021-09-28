using System;
using System.Threading.Tasks;


namespace R5T.D0084.D002.I001
{
    public class StaticValuedRepositoriesDirectoryPathProvider : IRepositoriesDirectoryPathProvider
    {
        public static string RepositoriesDirectoryPath { get; set; }


        public Task<string> GetRepositoriesDirectoryPath()
        {
            return Task.FromResult(StaticValuedRepositoriesDirectoryPathProvider.RepositoriesDirectoryPath);
        }
    }
}
