
using ConsumoResponsableApi.Utils.Enums;

namespace ConsumoResponsableApi.Utils.Responses;

public static class Response
{
    public static ResponseSuccess<TData> GetResponseSuccess<TData>(HttpEnums statusCode, TData data) =>
        new()
        {
            StatusCode = (int)statusCode,
            Data = data
        };

    public static ResponseError GetResponseError(HttpEnums statusCode, int errorCode, params string[] errors) =>
        new()
        {
            StatusCode = (int)statusCode,
            ErrorCode = errorCode,
            Errors = errors.ToList()
        };

    public static ResponseError GetResponseError(HttpEnums statusCode, params string[] errors) =>
        GetResponseError(statusCode, 0, errors);
}