using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0084.D002.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedRepositoriesDirectoryPathProvider(this IServiceCollection services,
            string repositoriesDirectoryPath)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider>((_) => new ConstructorBasedRepositoriesDirectoryPathProvider(repositoriesDirectoryPath));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddConstructorBasedRepositoriesDirectoryPathProviderAction(this IServiceCollection services,
            string repositoriesDirectoryPath)
        {
            var serviceAction = ServiceAction.New<IRepositoriesDirectoryPathProvider>(() => services.AddConstructorBasedRepositoriesDirectoryPathProvider(
                repositoriesDirectoryPath));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedRepositoriesDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider, StaticValuedRepositoriesDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddStaticValuedRepositoriesDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IRepositoriesDirectoryPathProvider>(() => services.AddStaticValuedRepositoriesDirectoryPathProvider());
            return serviceAction;
        }
    }
}