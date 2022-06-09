using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Magyar.Extensions;

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
            var projectFilePathProviderAction = services.AddProjectFilePathProviderAction_Old();

            var allProjectDirectoryPathsProviderServiceActions = services.AddAllProjectDirectoryPathsProviderServiceActions(
                repositoriesDirectoryPathProviderAction);

            var allProjectFilePathsProviderAction = services.AddAllProjectFilePathsProviderAction_Old(
                allProjectDirectoryPathsProviderServiceActions.AllProjectDirectoryPathsProviderAction,
                projectFilePathProviderAction);

            return new ServiceAggregation02()
                .ModifyAs<ServiceAggregation02, IServiceAggregationIncrement02>(increment =>
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
            var projectDirectoryPathsProviderAction = services.AddProjectDirectoryPathsProviderAction_Old();
            var solutionDirectoryPathProviderAction = services.AddSourceSolutionDirectoryPathProviderAction_Old();

            // Level 1.
            var allRepositoryDirectoryPathsProviderAction = services.AddAllRepositoryDirectoryPathsProviderAction_Old(
                repositoriesDirectoryPathProviderAction);

            // Level 2.
            var allSolutionDirectoryPathsProviderAction = services.AddAllSolutionDirectoryPathsProviderAction_Old(
                allRepositoryDirectoryPathsProviderAction,
                solutionDirectoryPathProviderAction);

            // Level 3.
            var allProjectDirectoryPathsProviderAction = services.AddAllProjectDirectoryPathsProviderAction_Old(
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