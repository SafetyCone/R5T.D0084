using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0084.D002.I001
{[ServiceImplementationMarker]
    public class StaticValuedRepositoriesDirectoryPathProvider : IRepositoriesDirectoryPathProvider,IServiceImplementation
    {
        public static string RepositoriesDirectoryPath { get; set; }


        public Task<string> GetRepositoriesDirectoryPath()
        {
            return Task.FromResult(StaticValuedRepositoriesDirectoryPathProvider.RepositoriesDirectoryPath);
        }
    }
}
