using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0084.D002.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValuedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedRepositoriesDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider, StaticValuedRepositoriesDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedRepositoriesDirectoryPathProvider"/> implementation of <see cref="IRepositoriesDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedRepositoriesDirectoryPathProvider(this IServiceCollection services,
            string repositoriesDirectoryPath)
        {
            services.AddSingleton<IRepositoriesDirectoryPathProvider>(_ => new ConstructorBasedRepositoriesDirectoryPathProvider(
                repositoriesDirectoryPath));

            return services;
        }
    }
}
