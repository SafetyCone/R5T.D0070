using System;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public static class IAppSettingsFileNameStemTokenizationConventionExtensions
    {
        public static Task<string> Combine(this IAppSettingsFileNameStemTokenizationConvention appSettingsFileNameStemTokenizationConvention,
            params string[] tokens)
        {
            return appSettingsFileNameStemTokenizationConvention.Combine(tokens);
        }
    }
}
