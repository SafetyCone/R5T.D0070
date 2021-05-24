﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;

using R5T.D0062;
using R5T.D0065;


namespace R5T.D0070
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EnvironmentNameSpecificAppSettingsFilePathProvider"/> implementation of <see cref="IEnvironmentNameSpecificAppSettingsFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentNameSpecificAppSettingsFilePathProvider(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IEnvironmentNameSpecificAppSettingsFileNameProvider> environmentNameSpecificAppSettingsFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IEnvironmentNameSpecificAppSettingsFilePathProvider, EnvironmentNameSpecificAppSettingsFilePathProvider>()
                .Run(appSettingsDirectoryPathProviderAction)
                .Run(environmentNameSpecificAppSettingsFileNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameSpecificAppSettingsFilePathProvider"/> implementation of <see cref="IEnvironmentNameSpecificAppSettingsFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameSpecificAppSettingsFilePathProvider> AddEnvironmentNameSpecificAppSettingsFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IEnvironmentNameSpecificAppSettingsFileNameProvider> environmentNameSpecificAppSettingsFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameSpecificAppSettingsFilePathProvider>(() => services.AddEnvironmentNameSpecificAppSettingsFilePathProvider(
                appSettingsDirectoryPathProviderAction,
                environmentNameSpecificAppSettingsFileNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameSpecificAppSettingsFileNameProvider"/> implementation of <see cref="IEnvironmentNameSpecificAppSettingsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentNameSpecificAppSettingsFileNameProvider(this IServiceCollection services,
            IServiceAction<IAppSettingsFileNameStemTokenizationConvention> appSettingsFileNameStemTokenizationConventionAction,
            IServiceAction<IEnvironmentNameToAppSettingsFileNameTokenConverter> environmentNameToAppSettingsFileNameTokenConverterAction,
            IServiceAction<IEnvironmentNameProvider> environmentNameProviderAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction)
        {
            services
                .AddSingleton<IEnvironmentNameSpecificAppSettingsFileNameProvider, EnvironmentNameSpecificAppSettingsFileNameProvider>()
                .Run(appSettingsFileNameStemTokenizationConventionAction)
                .Run(environmentNameToAppSettingsFileNameTokenConverterAction)
                .Run(environmentNameProviderAction)
                .Run(fileNameOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameSpecificAppSettingsFileNameProvider"/> implementation of <see cref="IEnvironmentNameSpecificAppSettingsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameSpecificAppSettingsFileNameProvider> AddEnvironmentNameSpecificAppSettingsFileNameProviderAction(this IServiceCollection services,
            IServiceAction<IAppSettingsFileNameStemTokenizationConvention> appSettingsFileNameStemTokenizationConventionAction,
            IServiceAction<IEnvironmentNameToAppSettingsFileNameTokenConverter> environmentNameToAppSettingsFileNameTokenConverterAction,
            IServiceAction<IEnvironmentNameProvider> environmentNameProviderAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameSpecificAppSettingsFileNameProvider>(() => services.AddEnvironmentNameSpecificAppSettingsFileNameProvider(
                appSettingsFileNameStemTokenizationConventionAction,
                environmentNameToAppSettingsFileNameTokenConverterAction,
                environmentNameProviderAction,
                fileNameOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameToAppSettingsFileNameTokenConverter"/> implementation of <see cref="IEnvironmentNameToAppSettingsFileNameTokenConverter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentNameToAppSettingsFileNameTokenConverter(this IServiceCollection services)
        {
            services.AddSingleton<IEnvironmentNameToAppSettingsFileNameTokenConverter, EnvironmentNameToAppSettingsFileNameTokenConverter>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameToAppSettingsFileNameTokenConverter"/> implementation of <see cref="IEnvironmentNameToAppSettingsFileNameTokenConverter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameToAppSettingsFileNameTokenConverter> AddEnvironmentNameToAppSettingsFileNameTokenConverterAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameToAppSettingsFileNameTokenConverter>(() => services.AddEnvironmentNameToAppSettingsFileNameTokenConverter());
            return serviceAction;
        }

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
        /// Adds the <see cref="DefaultJsonAppSettingsFileNameProvider"/> implementation of <see cref="IAppSettingsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsFileNameProvider> AddDefaultJsonAppSettingsFileNameProviderAction(this IServiceCollection services,
            IServiceAction<IFileNameOperator> fileNameOperatorAction)
        {
            var serviceAction = ServiceAction.New<IAppSettingsFileNameProvider>(() => services.AddDefaultJsonAppSettingsFileNameProvider(
                fileNameOperatorAction));

            return serviceAction;
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
        /// Adds the <see cref="AppSettingsFilePathProvider"/> implementation of <see cref="IAppSettingsFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsFilePathProvider> AddAppSettingsFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IAppSettingsFileNameProvider> appSettingsFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<IAppSettingsFilePathProvider>(() => services.AddAppSettingsFilePathProvider(
                appSettingsDirectoryPathProviderAction,
                appSettingsFileNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
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

        /// <summary>
        /// Adds the <see cref="ExecutableDirectoryBasedAppSettingsDirectoryPathProvider"/> implementation of <see cref="IAppSettingsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsDirectoryPathProvider> AddExecutableDirectoryBasedAppSettingsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IAppSettingsDirectoryPathProvider>(() => services.AddExecutableDirectoryBasedAppSettingsDirectoryPathProvider(
                executableDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AppSettingsFileNameStemTokenizationConvention"/> implementation of <see cref="IAppSettingsFileNameStemTokenizationConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAppSettingsFileNameStemTokenizationConvention(this IServiceCollection services)
        {
            services.AddSingleton<IAppSettingsFileNameStemTokenizationConvention, AppSettingsFileNameStemTokenizationConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AppSettingsFileNameStemTokenizationConvention"/> implementation of <see cref="IAppSettingsFileNameStemTokenizationConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsFileNameStemTokenizationConvention> AddAppSettingsFileNameStemTokenizationConventionAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IAppSettingsFileNameStemTokenizationConvention>(() => services.AddAppSettingsFileNameStemTokenizationConvention());
            return serviceAction;
        }
    }
}