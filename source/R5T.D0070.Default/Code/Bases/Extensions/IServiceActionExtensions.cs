using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0070.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultJsonAppSettingsFileNameProvider"/> implementation of <see cref="IAppSettingsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsFileNameProvider> AddDefaultJsonAppSettingsFileNameProviderAction(this IServiceAction _,
            IServiceAction<IFileNameOperator> fileNameOperatorAction)
        {
            var serviceAction = _.New<IAppSettingsFileNameProvider>(services => services.AddDefaultJsonAppSettingsFileNameProvider(
                fileNameOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AppSettingsFilePathProvider"/> implementation of <see cref="IAppSettingsFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsFilePathProvider> AddAppSettingsFilePathProviderAction(this IServiceAction _,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IAppSettingsFileNameProvider> appSettingsFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IAppSettingsFilePathProvider>(services => services.AddAppSettingsFilePathProvider(
                appSettingsDirectoryPathProviderAction,
                appSettingsFileNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableDirectoryBasedAppSettingsDirectoryPathProvider"/> implementation of <see cref="IAppSettingsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsDirectoryPathProvider> AddExecutableDirectoryBasedAppSettingsDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IAppSettingsDirectoryPathProvider>(services => services.AddExecutableDirectoryBasedAppSettingsDirectoryPathProvider(
                executableDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
