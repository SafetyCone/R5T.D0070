using System;

using R5T.D0070.Default;


namespace System
{
    public static class IEnvironmentNameSpecificAppSettingsFilePathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IEnvironmentNameSpecificAppSettingsFilePathAggregation01 other)
            where T : IEnvironmentNameSpecificAppSettingsFilePathAggregation01
        {
            aggregation.AppSettingsFileNameStemTokenizationConventionAction = other.AppSettingsFileNameStemTokenizationConventionAction;
            aggregation.EnvironmentNameSpecificAppSettingsFileNameProviderAction = other.EnvironmentNameSpecificAppSettingsFileNameProviderAction;
            aggregation.EnvironmentNameSpecificAppSettingsFilePathProviderAction = other.EnvironmentNameSpecificAppSettingsFilePathProviderAction;
            aggregation.EnvironmentNameToAppSettingsFileNameTokenConverterAction = other.EnvironmentNameToAppSettingsFileNameTokenConverterAction;

            return aggregation;
        }
    }
}
