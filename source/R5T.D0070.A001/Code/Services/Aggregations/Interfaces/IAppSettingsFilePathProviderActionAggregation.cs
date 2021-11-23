using System;

using R5T.T0063;


namespace R5T.D0070.A001
{
    [ServiceActionAggregationMarker]
    public interface IAppSettingsFilePathProviderActionAggregation : IAppSettingsFilePathProviderActionAggregationIncrement, IServiceActionAggregation
    {
    }
}
