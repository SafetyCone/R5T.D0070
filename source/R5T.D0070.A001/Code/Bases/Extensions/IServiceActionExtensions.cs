using System;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0062;
using R5T.T0063;

using R5T.D0070.Default;


namespace R5T.D0070.A001
{
    public static class IServiceActionExtensions
    {
        public static IAppSettingsFilePathProviderActionAggregation AddAppSettingsFilePathProviderActions(this IServiceAction _,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var appSettingsDirectoryPathProviderAction = _.AddExecutableDirectoryBasedAppSettingsDirectoryPathProviderAction(
                executableDirectoryPathProviderAction);

            var appsettingsFileNameProviderAction = _.AddDefaultJsonAppSettingsFileNameProviderAction(
                fileNameOperatorAction);

            var appSettingsFilePathProviderAction = _.AddAppSettingsFilePathProviderAction(
                appSettingsDirectoryPathProviderAction,
                appsettingsFileNameProviderAction,
                stringlyTypedPathOperatorAction);

            var output = new AppSettingsFilePathProviderActionAggregation
            {
                AppSettingsDirectoryPathProviderAction = appSettingsDirectoryPathProviderAction,
                AppSettingsFileNameProviderAction = appsettingsFileNameProviderAction,
                AppSettingsFilePathProvider = appSettingsFilePathProviderAction,
            };

            return output;
        }
    }
}
