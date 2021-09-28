using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceAggregation02Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation02 other)
            where T : IServiceAggregation02
        {
            (aggregation as IServiceAggregation01).FillFrom(other);

            (aggregation as IServiceAggregationIncrement02).FillFrom(other);

            return aggregation;
        }
    }
}
