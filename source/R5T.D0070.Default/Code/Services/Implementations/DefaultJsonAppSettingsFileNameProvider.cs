using System;
using System.Threading.Tasks;

using R5T.Cherusci;
using R5T.Lombardy;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceImplementationMarker]
    public class DefaultJsonAppSettingsFileNameProvider : IAppSettingsFileNameProvider, IServiceImplementation
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
