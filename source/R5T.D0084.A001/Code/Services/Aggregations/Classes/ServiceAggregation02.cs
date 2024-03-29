﻿using System;

using R5T.Dacia;

using R5T.D0084.D001;
using R5T.D0084.D003;


namespace R5T.D0084.A001
{
    public class ServiceAggregation02 : IServiceAggregation02
    {
        public IServiceAction<IAllProjectDirectoryPathsProvider> AllProjectDirectoryPathsProviderAction { get; set; }
        public IServiceAction<IAllProjectFilePathsProvider> AllProjectFilePathsProviderAction { get; set; }
        public IServiceAction<IAllRepositoryDirectoryPathsProvider> AllRepositoryDirectoryPathsProviderAction { get; set; }
        public IServiceAction<IAllSolutionDirectoryPathsProvider> AllSolutionDirectoryPathsProviderAction { get; set; }
        public IServiceAction<IProjectDirectoryPathsProvider> ProjectDirectoryPathsProviderAction { get; set; }
        public IServiceAction<IProjectFilePathProvider> ProjectFilePathProviderAction { get; set; }
        public IServiceAction<ISolutionDirectoryPathProvider> SolutionDirectoryPathProviderAction { get; set; }
    }
}