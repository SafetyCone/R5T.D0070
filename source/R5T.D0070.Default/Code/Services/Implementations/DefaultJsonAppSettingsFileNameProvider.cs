using System;
using System.Threading.Tasks;

using R5T.Cherusci;
using R5T.Lombardy;


namespace R5T.D0070
{
    public class DefaultJsonAppSettingsFileNameProvider : IAppSettingsFileNameProvider
    {
        private IFileNameOperator FileNameOperator { get; }


        public DefaultJsonAppSettingsFileNameProvider(
            IFileNameOperator fileNameOperator)
        {
            this.FileNameOperator = fileNameOperator;
        }

        public Task<string> GetAppSettingsFileName()
        {
            var fileName = this.FileNameOperator.GetFileName(AppSettingsFile.DefaultFileNameStem, FileExtensions.Json);

            return Task.FromResult(fileName);
        }
    }
}
