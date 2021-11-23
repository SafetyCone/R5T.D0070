using System;
using System.Threading.Tasks;

using R5T.D0065;
using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class ExecutableDirectoryBasedAppSettingsDirectoryPathProvider : IAppSettingsDirectoryPathProvider, IServiceImplementation
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
