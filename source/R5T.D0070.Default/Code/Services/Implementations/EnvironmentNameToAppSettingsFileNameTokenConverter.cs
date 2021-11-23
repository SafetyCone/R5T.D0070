using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class EnvironmentNameToAppSettingsFileNameTokenConverter : IEnvironmentNameToAppSettingsFileNameTokenConverter, IServiceImplementation
    {
        public Task<string> ConvertEnvironmentNameToAppSettingsFileNameToken(string environmentName)
        {
            // Assume that the environment name can be used directly as an appsetting filename token.
            return Task.FromResult(environmentName);
        }
    }
}
