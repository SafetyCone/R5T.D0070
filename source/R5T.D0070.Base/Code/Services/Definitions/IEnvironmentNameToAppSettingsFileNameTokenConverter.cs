using System;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public interface IEnvironmentNameToAppSettingsFileNameTokenConverter
    {
        Task<string> ConvertEnvironmentNameToAppSettingsFileNameToken(string environmentName);
    }
}
