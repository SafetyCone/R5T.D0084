using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation01 other)
            where T : IServiceAggregation01
        {
            // No base aggregation.

            (aggregation as IServiceAggregationIncrement01).FillFrom(other);

            return aggregation;
        }
    }
}