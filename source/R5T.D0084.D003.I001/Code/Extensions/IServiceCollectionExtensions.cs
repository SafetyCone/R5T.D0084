using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0084.D003.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProjectFilePathProvider"/> implementation of <see cref="IProjectFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProjectFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectFilePathProvider, ProjectFilePathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProjectFilePathProvider"/> implementation of <see cref="IProjectFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProjectFilePathProvider> AddProjectFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IProjectFilePathProvider>(() => services.AddProjectFilePathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ProjectDirectoryPathsProvider"/> implementation of <see cref="IProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProjectDirectoryPathsProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectDirectoryPathsProvider, ProjectDirectoryPathsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProjectDirectoryPathsProvider"/> implementation of <see cref="IProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProjectDirectoryPathsProvider> AddProjectDirectoryPathsProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IProjectDirectoryPathsProvider>(() => services.AddProjectDirectoryPathsProvider());
            return serviceAction;
        }
    }
}