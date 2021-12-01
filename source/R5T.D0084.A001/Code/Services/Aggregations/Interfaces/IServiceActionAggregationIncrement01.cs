using System;

using R5T.T0063;

using R5T.D0084.D001;
using R5T.D0084.D003;


namespace R5T.D0084.A001
{
    public interface IServiceActionAggregationIncrement01
    {
        IServiceAction<IAllProjectDirectoryPathsProvider> AllProjectDirectoryPathsProviderAction { get; set; }
        IServiceAction<IAllRepositoryDirectoryPathsProvider> AllRepositoryDirectoryPathsProviderAction { get; set; }
        IServiceAction<IAllSolutionDirectoryPathsProvider> AllSolutionDirectoryPathsProviderAction { get; set; }
        IServiceAction<IProjectDirectoryPathsProvider> ProjectDirectoryPathsProviderAction { get; set; }
        IServiceAction<ISolutionDirectoryPathProvider> SolutionDirectoryPathProviderAction { get; set; }
    }
}
