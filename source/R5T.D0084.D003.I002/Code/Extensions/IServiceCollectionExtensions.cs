using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0084.D003.I002
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SourceSolutionDirectoryPathProvider"/> implementation of <see cref="ISolutionDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSourceSolutionDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<ISolutionDirectoryPathProvider, SourceSolutionDirectoryPathProvider>();

            return services;
        }
    }
}
