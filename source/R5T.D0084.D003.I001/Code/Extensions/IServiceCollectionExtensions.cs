using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0084.D003.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProjectDirectoryPathsProvider"/> implementation of <see cref="IProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProjectDirectoryPathsProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectDirectoryPathsProvider, ProjectDirectoryPathsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProjectFilePathProvider"/> implementation of <see cref="IProjectFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProjectFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectFilePathProvider, ProjectFilePathProvider>();

            return services;
        }
    }
}
