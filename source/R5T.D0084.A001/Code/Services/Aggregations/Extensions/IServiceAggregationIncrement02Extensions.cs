using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceAggregationIncrement02Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregationIncrement02 other)
            where T : IServiceAggregationIncrement02
        {
            aggregation.AllProjectFilePathsProviderAction = other.AllProjectFilePathsProviderAction;
            aggregation.ProjectFilePathProviderAction = other.ProjectFilePathProviderAction;

            return aggregation;
        }
    }
}
