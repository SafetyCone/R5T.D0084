using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0084.D003.I002
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SourceSolutionDirectoryPathProvider"/> implementation of <see cref="ISolutionDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSourceSolutionDirectoryPathProvider_Old(this IServiceCollection services)
        {
            services.AddSingleton<ISolutionDirectoryPathProvider, SourceSolutionDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SourceSolutionDirectoryPathProvider"/> implementation of <see cref="ISolutionDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISolutionDirectoryPathProvider> AddSourceSolutionDirectoryPathProviderAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ISolutionDirectoryPathProvider>(() => services.AddSourceSolutionDirectoryPathProvider_Old());
            return serviceAction;
        }
    }
}