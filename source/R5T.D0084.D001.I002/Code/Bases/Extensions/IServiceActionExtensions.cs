using System;

using R5T.T0062;
using R5T.T0063;

using R5T.D0084.D002;
using R5T.D0084.D003;


namespace R5T.D0084.D001.I002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AllSolutionDirectoryPathsProvider"/> implementation of <see cref="IAllSolutionDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllSolutionDirectoryPathsProvider> AddAllSolutionDirectoryPathsProviderAction(this IServiceAction _,
            IServiceAction<IAllRepositoryDirectoryPathsProvider> allRepositoryDirectoryPathsProviderAction,
            IServiceAction<ISolutionDirectoryPathProvider> solutionDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IAllSolutionDirectoryPathsProvider>(services => services.AddAllSolutionDirectoryPathsProvider(
                allRepositoryDirectoryPathsProviderAction,
                solutionDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllRepositoryDirectoryPathsProvider"/> implementation of <see cref="IAllRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllRepositoryDirectoryPathsProvider> AddAllRepositoryDirectoryPathsProviderAction(this IServiceAction _,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IAllRepositoryDirectoryPathsProvider>(services => services.AddAllRepositoryDirectoryPathsProvider(
                repositoriesDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectFilePathsProvider"/> implementation of <see cref="IAllProjectFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllProjectFilePathsProvider> AddAllProjectFilePathsProviderAction(this IServiceAction _,
            IServiceAction<IAllProjectDirectoryPathsProvider> allProjectDirectoryPathsProviderAction,
            IServiceAction<IProjectFilePathProvider> projectFilePathProviderAction)
        {
            var serviceAction = _.New<IAllProjectFilePathsProvider>(services => services.AddAllProjectFilePathsProvider(
                allProjectDirectoryPathsProviderAction,
                projectFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllProjectDirectoryPathsProvider> AddAllProjectDirectoryPathsProviderAction(this IServiceAction _,
            IServiceAction<IAllSolutionDirectoryPathsProvider> allSolutionDirectoryPathsProviderAction,
            IServiceAction<IProjectDirectoryPathsProvider> projectDirectoryPathsProviderAction)
        {
            var serviceAction = _.New<IAllProjectDirectoryPathsProvider>(services => services.AddAllProjectDirectoryPathsProvider(
                allSolutionDirectoryPathsProviderAction,
                projectDirectoryPathsProviderAction));

            return serviceAction;
        }
    }
}
