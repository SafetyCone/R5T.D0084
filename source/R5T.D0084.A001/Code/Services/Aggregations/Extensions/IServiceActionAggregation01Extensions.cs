using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            // No base aggregation.

            (aggregation as IServiceActionAggregationIncrement01).FillFrom(other);

            return aggregation;
        }
    }
}