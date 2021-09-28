using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceAggregationIncrement01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregationIncrement01 other)
            where T : IServiceAggregationIncrement01
        {
            aggregation.AllProjectDirectoryPathsProviderAction = other.AllProjectDirectoryPathsProviderAction;
            aggregation.AllRepositoryDirectoryPathsProviderAction = other.AllRepositoryDirectoryPathsProviderAction;
            aggregation.AllSolutionDirectoryPathsProviderAction = other.AllSolutionDirectoryPathsProviderAction;
            aggregation.ProjectDirectoryPathsProviderAction = other.ProjectDirectoryPathsProviderAction;
            aggregation.SolutionDirectoryPathProviderAction = other.SolutionDirectoryPathProviderAction;

            return aggregation;
        }
    }
}