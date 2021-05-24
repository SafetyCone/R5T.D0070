using System;
using System.Threading.Tasks;

using R5T.D0065;


namespace R5T.D0070
{
    public class ExecutableDirectoryBasedAppSettingsDirectoryPathProvider : IAppSettingsDirectoryPathProvider
    {
        private IExecutableDirectoryPathProvider ExecutableDirectoryPathProvider { get; }


        public ExecutableDirectoryBasedAppSettingsDirectoryPathProvider(
            IExecutableDirectoryPathProvider executableDirectoryPathProvider)
        {
            this.ExecutableDirectoryPathProvider = executableDirectoryPathProvider;
        }

        public Task<string> GetAppSettingsDirectoryPath()
        {
            // Just return the executable directory path.
            return this.ExecutableDirectoryPathProvider.GetExecutableDirectoryPath();
        }
    }
}
