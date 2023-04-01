using System.Text.Json.Serialization;

namespace ConsumoResponsableApi.Utils.Responses;

public class ResponseError : ResponseBase
{
    [JsonPropertyName("errors")]
    public List<string> Errors { get; set; } = null!;

    [JsonPropertyName("errorCode")]
    public int ErrorCode { get; set; }

    [JsonConstructor]
    public ResponseError() { }
}