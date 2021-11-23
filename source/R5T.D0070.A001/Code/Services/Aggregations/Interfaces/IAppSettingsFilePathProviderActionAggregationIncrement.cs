using System;

using R5T.T0063;


namespace R5T.D0070.A001
{
    [ServiceActionAggregationIncrementMarker]
    public interface IAppSettingsFilePathProviderActionAggregationIncrement : IServiceActionAggregationIncrement
    {
        public IServiceAction<IAppSettingsFilePathProvider> AppSettingsFilePathProvider { get; set; }
        public IServiceAction<IAppSettingsDirectoryPathProvider> AppSettingsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IAppSettingsFileNameProvider> AppSettingsFileNameProviderAction { get; set; }
    }
}
