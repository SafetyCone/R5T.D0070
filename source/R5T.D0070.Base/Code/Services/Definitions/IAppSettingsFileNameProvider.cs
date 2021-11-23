﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0070
{
    [ServiceDefinitionMarker]
    public interface IAppSettingsFileNameProvider : IServiceDefinition
    {
        Task<string> GetAppSettingsFileName();
    }
}
