﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0063;


namespace R5T.D0070.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultJsonAppSettingsFileNameProvider"/> implementation of <see cref="IAppSettingsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultJsonAppSettingsFileNameProvider(this IServiceCollection services,
            IServiceAction<IFileNameOperator> fileNameOperatorAction)
        {
            services
                .AddSingleton<IAppSettingsFileNameProvider, DefaultJsonAppSettingsFileNameProvider>()
                .Run(fileNameOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AppSettingsFilePathProvider"/> implementation of <see cref="IAppSettingsFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAppSettingsFilePathProvider(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IAppSettingsFileNameProvider> appSettingsFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IAppSettingsFilePathProvider, AppSettingsFilePathProvider>()
                .Run(appSettingsDirectoryPathProviderAction)
                .Run(appSettingsFileNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableDirectoryBasedAppSettingsDirectoryPathProvider"/> implementation of <see cref="IAppSettingsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddExecutableDirectoryBasedAppSettingsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IAppSettingsDirectoryPathProvider, ExecutableDirectoryBasedAppSettingsDirectoryPathProvider>()
                .Run(executableDirectoryPathProviderAction)
                ;

            return services;
        }
    }
}
