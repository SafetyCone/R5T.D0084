using System;

using R5T.D0084.A001;


namespace System
{
    public static class IServiceActionAggregation02Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation02 other)
            where T : IServiceActionAggregation02
        {
            (aggregation as IServiceActionAggregation01).FillFrom(other);

            (aggregation as IServiceActionAggregationIncrement02).FillFrom(other);

            return aggregation;
        }
    }
}
