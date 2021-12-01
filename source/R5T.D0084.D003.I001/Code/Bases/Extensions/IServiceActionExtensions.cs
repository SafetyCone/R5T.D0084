using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0084.D003.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProjectFilePathProvider"/> implementation of <see cref="IProjectFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProjectFilePathProvider> AddProjectFilePathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProjectFilePathProvider>(services => services.AddProjectFilePathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ProjectDirectoryPathsProvider"/> implementation of <see cref="IProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProjectDirectoryPathsProvider> AddProjectDirectoryPathsProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProjectDirectoryPathsProvider>(services => services.AddProjectDirectoryPathsProvider());
            return serviceAction;
        }
    }
}
