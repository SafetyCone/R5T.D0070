using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;

using R5T.D0065;


namespace R5T.D0070.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static
            (
            IServiceAction<IAppSettingsFilePathProvider> _,
            IServiceAction<IAppSettingsDirectoryPathProvider> AppSettingsDirectoryPathProviderAction,
            IServiceAction<IAppSettingsFileNameProvider> AppSettingsFileNameProviderAction
            )
        AddDefaultJsonAppSettingsFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var appSettingsDirectoryPathProviderAction = services.AddExecutableDirectoryBasedAppSettingsDirectoryPathProviderAction(
                executableDirectoryPathProviderAction);

            var appsettingsFileNameProviderAction = services.AddDefaultJsonAppSettingsFileNameProviderAction(
                fileNameOperatorAction);

            var appSettingsFilePathProviderAction = services.AddAppSettingsFilePathProviderAction(
                appSettingsDirectoryPathProviderAction,
                appsettingsFileNameProviderAction,
                stringlyTypedPathOperatorAction);

            return
                (
                appSettingsFilePathProviderAction,
                appSettingsDirectoryPathProviderAction,
                appsettingsFileNameProviderAction
                );
        }
    }
}
