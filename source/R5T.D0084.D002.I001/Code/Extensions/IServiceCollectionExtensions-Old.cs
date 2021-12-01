using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0084.D002.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedRepositoriesDirectoryPathProvider_Old(this IServiceCollection services,
            string repositoriesDirectoryPath)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider>((_) => new ConstructorBasedRepositoriesDirectoryPathProvider(repositoriesDirectoryPath));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddConstructorBasedRepositoriesDirectoryPathProviderAction_Old(this IServiceCollection services,
            string repositoriesDirectoryPath)
        {
            var serviceAction = ServiceAction.New<IRepositoriesDirectoryPathProvider>(() => services.AddConstructorBasedRepositoriesDirectoryPathProvider_Old(
                repositoriesDirectoryPath));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedRepositoriesDirectoryPathProvider_Old(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider, StaticValuedRepositoriesDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRepositoriesDirectoryPathProvider> AddStaticValuedRepositoriesDirectoryPathProviderAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IRepositoriesDirectoryPathProvider>(() => services.AddStaticValuedRepositoriesDirectoryPathProvider_Old());
            return serviceAction;
        }
    }
}