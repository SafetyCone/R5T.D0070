using System;


namespace R5T.D0070.A001
{    
    public static class IAppSettingsFilePathProviderActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IAppSettingsFilePathProviderActionAggregation other)
            where T : IAppSettingsFilePathProviderActionAggregation
        {
            (aggregation as IAppSettingsFilePathProviderActionAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}
