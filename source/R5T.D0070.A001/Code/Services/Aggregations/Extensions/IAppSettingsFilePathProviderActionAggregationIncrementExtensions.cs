using System;


namespace R5T.D0070.A001
{
    public static class IAppSettingsFilePathProviderActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IAppSettingsFilePathProviderActionAggregationIncrement other)
            where T : IAppSettingsFilePathProviderActionAggregationIncrement
        {
            aggregation.AppSettingsDirectoryPathProviderAction = other.AppSettingsDirectoryPathProviderAction;
            aggregation.AppSettingsFileNameProviderAction = other.AppSettingsFileNameProviderAction;
            aggregation.AppSettingsFilePathProvider = other.AppSettingsFilePathProvider;

            return aggregation;
        }
    }
}
