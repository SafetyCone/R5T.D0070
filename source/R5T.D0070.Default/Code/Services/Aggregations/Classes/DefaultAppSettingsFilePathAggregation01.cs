using System;

using R5T.Dacia;


namespace R5T.D0070.Default
{
    public class DefaultAppSettingsFilePathAggregation01 : IDefaultAppSettingsFilePathAggregation01
    {
        public IServiceAction<IAppSettingsFilePathProvider> AppSettingsFilePathProvider { get; set; }
        public IServiceAction<IAppSettingsDirectoryPathProvider> AppSettingsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IAppSettingsFileNameProvider> AppSettingsFileNameProviderAction { get; set; }
    }
}
