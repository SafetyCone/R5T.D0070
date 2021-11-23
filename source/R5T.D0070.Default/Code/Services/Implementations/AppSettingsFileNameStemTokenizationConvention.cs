using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class AppSettingsFileNameStemTokenizationConvention : IAppSettingsFileNameStemTokenizationConvention, IServiceImplementation
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
