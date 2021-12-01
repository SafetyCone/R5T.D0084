using System;

using R5T.Magyar;

using R5T.T0062;
using R5T.T0063;

using R5T.D0084.D001.I002;
using R5T.D0084.D002;
using R5T.D0084.D003.I001;
using R5T.D0084.D003.I002;


namespace R5T.D0084.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation02 AddAllProjectFilePathsProviderServiceActions(this IServiceAction _,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            // Level 0.
            var projectFilePathProviderAction = _.AddProjectFilePathProviderAction();

            var allProjectDirectoryPathsProviderServiceActions = _.AddAllProjectDirectoryPathsProviderServiceActions(
                repositoriesDirectoryPathProviderAction);

            var allProjectFilePathsProviderAction = _.AddAllProjectFilePathsProviderAction(
                allProjectDirectoryPathsProviderServiceActions.AllProjectDirectoryPathsProviderAction,
                projectFilePathProviderAction);

            return new ServiceActionAggregation02()
                .As<ServiceActionAggregation02, IServiceActionAggregationIncrement02>(increment =>
                {
                    increment.AllProjectFilePathsProviderAction = allProjectFilePathsProviderAction;
                    increment.ProjectFilePathProviderAction = projectFilePathProviderAction;
                })
                .FillFrom(allProjectDirectoryPathsProviderServiceActions)
                ;
        }

        public static ServiceActionAggregation01 AddAllProjectDirectoryPathsProviderServiceActions(this IServiceAction _,
            IServiceAction<IRepositoriesDirectoryPathProvider> repositoriesDirectoryPathProviderAction)
        {
            // Level 0.
            var projectDirectoryPathsProviderAction = _.AddProjectDirectoryPathsProviderAction();
            var solutionDirectoryPathProviderAction = _.AddSourceSolutionDirectoryPathProviderAction();

            // Level 1.
            var allRepositoryDirectoryPathsProviderAction = _.AddAllRepositoryDirectoryPathsProviderAction(
                repositoriesDirectoryPathProviderAction);

            // Level 2.
            var allSolutionDirectoryPathsProviderAction = _.AddAllSolutionDirectoryPathsProviderAction(
                allRepositoryDirectoryPathsProviderAction,
                solutionDirectoryPathProviderAction);

            // Level 3.
            var allProjectDirectoryPathsProviderAction = _.AddAllProjectDirectoryPathsProviderAction(
                allSolutionDirectoryPathsProviderAction,
                projectDirectoryPathsProviderAction);

            return new ServiceActionAggregation01
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
