﻿using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class EnvironmentNameSpecificAppSettingsFilePathProvider : IEnvironmentNameSpecificAppSettingsFilePathProvider, IServiceImplementation
    {
        private IAppSettingsDirectoryPathProvider AppSettingsDirectoryPathProvider { get; }
        private IEnvironmentNameSpecificAppSettingsFileNameProvider EnvironmentNameSpecificAppSettingsFileNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public EnvironmentNameSpecificAppSettingsFilePathProvider(
            IAppSettingsDirectoryPathProvider appSettingsDirectoryPathProvider,
            IEnvironmentNameSpecificAppSettingsFileNameProvider environmentNameSpecificAppSettingsFileNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.AppSettingsDirectoryPathProvider = appSettingsDirectoryPathProvider;
            this.EnvironmentNameSpecificAppSettingsFileNameProvider = environmentNameSpecificAppSettingsFileNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetAppSettingsFilePath()
        {
            var appSettingsDirectoryPath = await this.AppSettingsDirectoryPathProvider.GetAppSettingsDirectoryPath();
            var environmentSpecificAppSettingsFileName = await this.EnvironmentNameSpecificAppSettingsFileNameProvider.GetAppSettingsFileName();

            var environmentSpecificAppSettingsFilePath = this.StringlyTypedPathOperator.GetFilePath(appSettingsDirectoryPath, environmentSpecificAppSettingsFileName);
            return environmentSpecificAppSettingsFilePath;
        }
    }
}
