using System;
using System.Threading.Tasks;

using R5T.Cherusci;
using R5T.Lombardy;

using R5T.D0062;


namespace R5T.D0070
{
    public class EnvironmentNameSpecificAppSettingsFileNameProvider : IEnvironmentNameSpecificAppSettingsFileNameProvider
    {
        private IAppSettingsFileNameStemTokenizationConvention AppSettingsFileNameStemTokenizationConvention { get; }
        private IEnvironmentNameToAppSettingsFileNameTokenConverter EnvironmentNameToAppSettingsFileNameTokenConverter { get; }
        private IEnvironmentNameProvider EnvironmentNameProvider { get; }
        private IFileNameOperator FileNameOperator { get; }


        public EnvironmentNameSpecificAppSettingsFileNameProvider(
            IAppSettingsFileNameStemTokenizationConvention appSettingsFileNameStemTokenizationConvention,
            IEnvironmentNameToAppSettingsFileNameTokenConverter environmentNameToAppSettingsFileNameTokenConverter,
            IEnvironmentNameProvider environmentNameProvider,
            IFileNameOperator fileNameOperator)
        {
            this.AppSettingsFileNameStemTokenizationConvention = appSettingsFileNameStemTokenizationConvention;
            this.EnvironmentNameToAppSettingsFileNameTokenConverter = environmentNameToAppSettingsFileNameTokenConverter;
            this.EnvironmentNameProvider = environmentNameProvider;
            this.FileNameOperator = fileNameOperator;
        }

        public async Task<string> GetAppSettingsFileName()
        {
            var environmentName = await this.EnvironmentNameProvider.GetEnvironmentName();

            var environmentNameAppSettingFileNameToken = await this.EnvironmentNameToAppSettingsFileNameTokenConverter.ConvertEnvironmentNameToAppSettingsFileNameToken(environmentName);

            var appsettingsFileNameStem = await this.AppSettingsFileNameStemTokenizationConvention.Combine(AppSettingsFile.DefaultFileNameStem, environmentNameAppSettingFileNameToken);

            var fileName = this.FileNameOperator.GetFileName(appsettingsFileNameStem, FileExtensions.Json);
            return fileName;
        }
    }
}
