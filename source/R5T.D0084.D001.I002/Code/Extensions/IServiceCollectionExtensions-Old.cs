using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0084.D002;
using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllProjectDirectoryPathsProvider_Old(this IServiceCollection services,
            IServiceAction<IAllSolutionDirectoryPathsProvider> allSolutionDirectoryPathsProviderAction,
            IServiceAction<IProjectDirectoryPathsProvider> projectDirectoryPathsProviderAction)
        {
            services.AddSingleton<IAllProjectDirectoryPathsProvider, AllProjectDirectoryPathsProvider>()
                .Run(allSolutionDirectoryPathsProviderAction)
                .Run(projectDirectoryPathsProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllProjectDirectoryPathsProvider> AddAllProjectDirectoryPathsProviderAction_Old(this IServiceCollection services,
            IServiceAction<IAllSolutionDirectoryPathsProvider> allSolutionDirectoryPathsProviderAction,
            IServiceAction<IProjectDirectoryPathsProvider> projectDirectoryPathsProviderAction)
        {
            var serviceAction = ServiceAction.New<IAllProjectDirectoryPathsProvider>(() => services.AddAllProjectDirectoryPathsProvider_Old(
                allSolutionDirectoryPathsProviderAction,
                projectDirectoryPathsProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectFilePathsProvider"/> implementation of <see cref="IAllProjectFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllProjectFilePathsProvider_Old(this IServiceCollection services,
            IServiceAction<IAllProjectDirectoryPathsProvider> allProjectDirectoryPathsProviderAction,
            IServiceAction<IProjectFilePathProvider> projectFilePathProviderAction)
        {
            services.AddSingleton<IAllProjectFilePathsProvider, AllProjectFilePathsProvider>()
                .Run(allProjectDirectoryPathsProviderAction)
                .Run(projectFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectFilePathsProvider"/> implementation of <see cref="IAllProjectFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllProjectFilePathsProvider> AddAllProjectFilePathsProviderAction_Old(this IServiceCollection services,
            IServiceAction<IAllProjectDirectoryPathsProvider> allProjectDirectoryPathsProviderAction,
            IServiceAction<IProjectFilePathProvider> projectFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<IAllProjectFilePathsProvider>(() => services.AddAllProjectFilePathsProvider_Old(
                allProjectDirectoryPathsProviderAction,
                projectFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllRepositoryDirectoryPathsProvider"/> implementation of <see cref="IAllRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllRepositoryDirectoryPathsProvider_Old(this IServiceCollection services,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            services.AddSingleton<IAllRepositoryDirectoryPathsProvider, AllRepositoryDirectoryPathsProvider>()
                .Run(repositoriesDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllRepositoryDirectoryPathsProvider"/> implementation of <see cref="IAllRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllRepositoryDirectoryPathsProvider> AddAllRepositoryDirectoryPathsProviderAction_Old(this IServiceCollection services,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IAllRepositoryDirectoryPathsProvider>(() => services.AddAllRepositoryDirectoryPathsProvider_Old(
                repositoriesDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllSolutionDirectoryPathsProvider"/> implementation of <see cref="IAllSolutionDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllSolutionDirectoryPathsProvider_Old(this IServiceCollection services,
            IServiceAction<IAllRepositoryDirectoryPathsProvider> allRepositoryDirectoryPathsProviderAction,
            IServiceAction<ISolutionDirectoryPathProvider> solutionDirectoryPathProviderAction)
        {
            services.AddSingleton<IAllSolutionDirectoryPathsProvider, AllSolutionDirectoryPathsProvider>()
                .Run(allRepositoryDirectoryPathsProviderAction)
                .Run(solutionDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AllSolutionDirectoryPathsProvider"/> implementation of <see cref="IAllSolutionDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllSolutionDirectoryPathsProvider> AddAllSolutionDirectoryPathsProviderAction_Old(this IServiceCollection services,
            IServiceAction<IAllRepositoryDirectoryPathsProvider> allRepositoryDirectoryPathsProviderAction,
            IServiceAction<ISolutionDirectoryPathProvider> solutionDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IAllSolutionDirectoryPathsProvider>(() => services.AddAllSolutionDirectoryPathsProvider_Old(
                allRepositoryDirectoryPathsProviderAction,
                solutionDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}