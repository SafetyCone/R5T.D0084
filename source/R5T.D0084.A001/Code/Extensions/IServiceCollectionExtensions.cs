using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Magyar;

using R5T.D0084.D001.I002;
using R5T.D0084.D002;
using R5T.D0084.D003.I001;
using R5T.D0084.D003.I002;


namespace R5T.D0084.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServiceAggregation02 AddAllProjectFilePathsProviderServiceActions(this IServiceCollection services,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            // Level 0.
            var projectFilePathProviderAction = services.AddProjectFilePathProviderAction();

            var allProjectDirectoryPathsProviderServiceActions = services.AddAllProjectDirectoryPathsProviderServiceActions(
                repositoriesDirectoryPathProviderAction);

            var allProjectFilePathsProviderAction = services.AddAllProjectFilePathsProviderAction(
                allProjectDirectoryPathsProviderServiceActions.AllProjectDirectoryPathsProviderAction,
                projectFilePathProviderAction);

            return new ServiceAggregation02()
                .As<ServiceAggregation02, IServiceAggregationIncrement02>(increment =>
                {
                    increment.AllProjectFilePathsProviderAction = allProjectFilePathsProviderAction;
                    increment.ProjectFilePathProviderAction = projectFilePathProviderAction;
                })
                .FillFrom(allProjectDirectoryPathsProviderServiceActions)
                ;
        }

        public static ServiceAggregation01 AddAllProjectDirectoryPathsProviderServiceActions(this IServiceCollection services,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            // Level 0.
            var projectDirectoryPathsProviderAction = services.AddProjectDirectoryPathsProviderAction();
            var solutionDirectoryPathProviderAction = services.AddSourceSolutionDirectoryPathProviderAction();

            // Level 1.
            var allRepositoryDirectoryPathsProviderAction = services.AddAllRepositoryDirectoryPathsProviderAction(
                repositoriesDirectoryPathProviderAction);

            // Level 2.
            var allSolutionDirectoryPathsProviderAction = services.AddAllSolutionDirectoryPathsProviderAction(
                allRepositoryDirectoryPathsProviderAction,
                solutionDirectoryPathProviderAction);

            // Level 3.
            var allProjectDirectoryPathsProviderAction = services.AddAllProjectDirectoryPathsProviderAction(
                allSolutionDirectoryPathsProviderAction,
                projectDirectoryPathsProviderAction);

            return new ServiceAggregation01
            {
                AllProjectDirectoryPathsProviderAction = allProjectDirectoryPathsProviderAction,
                AllRepositoryDirectoryPathsProviderAction = allRepositoryDirectoryPathsProviderAction,
                AllSolutionDirectoryPathsProviderAction = allSolutionDirectoryPathsProviderAction,
                ProjectDirectoryPathsProviderAction = projectDirectoryPathsProviderAction,
                SolutionDirectoryPathProviderAction = solutionDirectoryPathProviderAction,
            };
        }
    }
}