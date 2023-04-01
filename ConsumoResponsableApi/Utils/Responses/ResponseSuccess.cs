using System.Text.Json.Serialization;
using ConsumoResponsableApi.Utils.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoResponsableApi.Utils.Responses;

public class ResponseSuccess<TResponse> : ResponseBase
{
    [JsonPropertyName("data")]
    public TResponse Data { get; set; } = default!;

    [JsonConstructor]
    public ResponseSuccess() { }

    public ResponseSuccess(HttpEnums statusCode, TResponse data)
    {
        StatusCode = (int)statusCode;
        Data = data;
    }

    public IActionResult GetResult() =>
        new ObjectResult(this)
        {
            StatusCode = StatusCode
        };
}