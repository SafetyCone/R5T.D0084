using System;

using R5T.T0032;
using R5T.T0044;


namespace R5T.D0084.D003.I001
{
    public static class Instances
    {
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static IFileSystemOperator FileSystemOperator { get; } = T0044.FileSystemOperator.Instance;
    }
}
