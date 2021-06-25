using System;

using R5T.Dacia;


namespace R5T.D0070.Default
{
    public class EnvironmentNameSpecificAppSettingsFilePathAggregation01
    {
        public IServiceAction<IAppSettingsFileNameStemTokenizationConvention> AppSettingsFileNameStemTokenizationConventionAction { get; set; }
        public IServiceAction<IEnvironmentNameToAppSettingsFileNameTokenConverter> EnvironmentNameToAppSettingsFileNameTokenConverterAction { get; set; }
        public IServiceAction<IEnvironmentNameSpecificAppSettingsFileNameProvider> EnvironmentNameSpecificAppSettingsFileNameProviderAction { get; set; }
        public IServiceAction<IEnvironmentNameSpecificAppSettingsFilePathProvider> EnvironmentNameSpecificAppSettingsFilePathProviderAction { get; set; }
    }
}
