﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;

using R5T.D0084.D002;
using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AllSolutionDirectoryPathsProvider"/> implementation of <see cref="IAllSolutionDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllSolutionDirectoryPathsProvider(this IServiceCollection services,
            IServiceAction<IAllRepositoryDirectoryPathsProvider> allRepositoryDirectoryPathsProviderAction,
            IServiceAction<ISolutionDirectoryPathProvider> solutionDirectoryPathProviderAction)
        {
            services
                .Run(allRepositoryDirectoryPathsProviderAction)
                .Run(solutionDirectoryPathProviderAction)
                .AddSingleton<IAllSolutionDirectoryPathsProvider, AllSolutionDirectoryPathsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllRepositoryDirectoryPathsProvider"/> implementation of <see cref="IAllRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllRepositoryDirectoryPathsProvider(this IServiceCollection services,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            services
                .Run(repositoriesDirectoryPathProviderAction)
                .AddSingleton<IAllRepositoryDirectoryPathsProvider, AllRepositoryDirectoryPathsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectFilePathsProvider"/> implementation of <see cref="IAllProjectFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllProjectFilePathsProvider(this IServiceCollection services,
            IServiceAction<IAllProjectDirectoryPathsProvider> allProjectDirectoryPathsProviderAction,
            IServiceAction<IProjectFilePathProvider> projectFilePathProviderAction)
        {
            services
                .Run(allProjectDirectoryPathsProviderAction)
                .Run(projectFilePathProviderAction)
                .AddSingleton<IAllProjectFilePathsProvider, AllProjectFilePathsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllProjectDirectoryPathsProvider(this IServiceCollection services,
            IServiceAction<IAllSolutionDirectoryPathsProvider> allSolutionDirectoryPathsProviderAction,
            IServiceAction<IProjectDirectoryPathsProvider> projectDirectoryPathsProviderAction)
        {
            services
                .Run(allSolutionDirectoryPathsProviderAction)
                .Run(projectDirectoryPathsProviderAction)
                .AddSingleton<IAllProjectDirectoryPathsProvider, AllProjectDirectoryPathsProvider>();

            return services;
        }
    }
}
