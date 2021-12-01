using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0084.D003.I002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SourceSolutionDirectoryPathProvider"/> implementation of <see cref="ISolutionDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISolutionDirectoryPathProvider> AddSourceSolutionDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<ISolutionDirectoryPathProvider>(services => services.AddSourceSolutionDirectoryPathProvider());
            return serviceAction;
        }
    }
}
