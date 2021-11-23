using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceDefinitionMarker]
    public interface IAppSettingsFileNameStemTokenizationConvention : IServiceDefinition
    {
        Task<string[]> Tokenize(string appSettingsFileNameStem);
        Task<string> Combine(IEnumerable<string> appSettingsFileNameStemTokens);
    }
}
