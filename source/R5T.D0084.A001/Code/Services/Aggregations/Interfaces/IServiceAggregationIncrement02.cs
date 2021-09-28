using System;

using R5T.Dacia;

using R5T.D0084.D001;
using R5T.D0084.D003;


namespace R5T.D0084.A001
{
    public interface IServiceAggregationIncrement02
    {
        IServiceAction<IAllProjectFilePathsProvider> AllProjectFilePathsProviderAction { get; set; }
        IServiceAction<IProjectFilePathProvider> ProjectFilePathProviderAction { get; set; }
    }
}
