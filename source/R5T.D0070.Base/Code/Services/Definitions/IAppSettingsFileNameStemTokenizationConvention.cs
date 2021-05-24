using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.D0070
{
    public interface IAppSettingsFileNameStemTokenizationConvention
    {
        Task<string[]> Tokenize(string appSettingsFileNameStem);
        Task<string> Combine(IEnumerable<string> appSettingsFileNameStemTokens);
    }
}
