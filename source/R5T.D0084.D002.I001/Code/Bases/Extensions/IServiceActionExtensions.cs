using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0084.D002.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddStaticValuedRepositoriesDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IRepositoriesDirectoryPathProvider>(services => services.AddStaticValuedRepositoriesDirectoryPathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddConstructorBasedRepositoriesDirectoryPathProviderAction(this IServiceAction _,
            string repositoriesDirectoryPath)
        {
            var serviceAction = _.New<IRepositoriesDirectoryPathProvider>(services => services.AddConstructorBasedRepositoriesDirectoryPathProvider(
                repositoriesDirectoryPath));

            return serviceAction;
        }
    }
}
