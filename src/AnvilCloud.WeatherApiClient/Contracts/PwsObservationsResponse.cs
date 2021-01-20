using System.Text.Json.Serialization;

namespace AnvilCloud.WeatherApiClient.Contracts
{
    public class PwsObservationsResponse
    {
        [JsonPropertyName("observations")]
        public PwsObservation[] Observations { get; set; }
    }
}
