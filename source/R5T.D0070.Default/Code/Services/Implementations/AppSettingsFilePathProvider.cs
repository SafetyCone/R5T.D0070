﻿using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class AppSettingsFilePathProvider : IAppSettingsFilePathProvider, IServiceImplementation
    {
        private IAppSettingsDirectoryPathProvider AppSettingsDirectoryPathProvider { get; }
        private IAppSettingsFileNameProvider AppSettingsFileNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public AppSettingsFilePathProvider(
            IAppSettingsDirectoryPathProvider appSettingsDirectoryPathProvider,
            IAppSettingsFileNameProvider appSettingsFileNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.AppSettingsDirectoryPathProvider = appSettingsDirectoryPathProvider;
            this.AppSettingsFileNameProvider = appSettingsFileNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetAppSettingsFilePath()
        {
            var directoryPath = await this.AppSettingsDirectoryPathProvider.GetAppSettingsDirectoryPath();
            var fileName = await this.AppSettingsFileNameProvider.GetAppSettingsFileName();

            var filePath = this.StringlyTypedPathOperator.GetFilePath(directoryPath, fileName);
            return filePath;
        }
    }
}
