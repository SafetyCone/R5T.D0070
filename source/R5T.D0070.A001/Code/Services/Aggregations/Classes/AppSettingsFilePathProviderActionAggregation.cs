using System;
using R5T.T0063;


namespace R5T.D0070.A001
{
    [ServiceActionAggregationImplementationMarker]
    public class AppSettingsFilePathProviderActionAggregation : IAppSettingsFilePathProviderActionAggregation, IServiceActionAggregationImplementation
    {
        public IServiceAction<IAppSettingsDirectoryPathProvider> AppSettingsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IAppSettingsFileNameProvider> AppSettingsFileNameProviderAction { get; set; }
        public IServiceAction<IAppSettingsFilePathProvider> AppSettingsFilePathProvider { get; set; }
    }
}
