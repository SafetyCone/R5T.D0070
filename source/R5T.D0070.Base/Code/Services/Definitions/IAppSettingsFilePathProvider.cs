using System;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public interface IAppSettingsFilePathProvider
    {
        Task<string> GetAppSettingsFilePath();
    }
}
