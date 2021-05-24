using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public class AppSettingsFileNameStemTokenizationConvention : IAppSettingsFileNameStemTokenizationConvention
    {
        public Task<string> Combine(IEnumerable<string> appSettingsFileNameStemTokens)
        {
            var appSettingsFileNameStem = StringHelper.Join(AppSettingsFileNameStem.DefaultTokenSeparator, appSettingsFileNameStemTokens);

            return Task.FromResult(appSettingsFileNameStem);
        }

        public Task<string[]> Tokenize(string appSettingsFileNameStem)
        {
            var tokens = StringHelper.Split(AppSettingsFileNameStem.DefaultTokenSeparator, appSettingsFileNameStem);
            
            return Task.FromResult(tokens);
        }
    }
}
