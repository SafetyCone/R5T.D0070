using System;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public class EnvironmentNameToAppSettingsFileNameTokenConverter : IEnvironmentNameToAppSettingsFileNameTokenConverter
    {
        public Task<string> ConvertEnvironmentNameToAppSettingsFileNameToken(string environmentName)
        {
            // Assume that the environment name can be used directly as an appsetting filename token.
            return Task.FromResult(environmentName);
        }
    }
}
