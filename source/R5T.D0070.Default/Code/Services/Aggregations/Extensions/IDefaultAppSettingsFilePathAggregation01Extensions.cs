using System;

using R5T.D0070.Default;


namespace System
{
    public static class IDefaultAppSettingsFilePathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IDefaultAppSettingsFilePathAggregation01 other)
            where T : IDefaultAppSettingsFilePathAggregation01
        {
            aggregation.AppSettingsDirectoryPathProviderAction = other.AppSettingsDirectoryPathProviderAction;
            aggregation.AppSettingsFileNameProviderAction = other.AppSettingsFileNameProviderAction;
            aggregation.AppSettingsFilePathProvider = other.AppSettingsFilePathProvider;

            return aggregation;
        }
    }
}
