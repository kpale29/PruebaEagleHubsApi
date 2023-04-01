using System.Text.Json.Serialization;

namespace ConsumoResponsableApi.Utils.Responses;

public abstract class ResponseBase
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }    

    [JsonConstructor]
    public ResponseBase() { }
}