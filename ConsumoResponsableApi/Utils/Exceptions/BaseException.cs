using System.Runtime.Serialization;
using ConsumoResponsableApi.Utils.Enums;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Utils.Exceptions;

[Serializable]
public class BaseException : Exception
{
    public string[] Errors { get; set; } = null!;
    public HttpEnums Code { get; set; }
    public int ErrorCode { get; set; }

    public BaseException() { }

    public BaseException(HttpEnums statusCode, int errorCode, params string[] errors)
    {
        ErrorCode = errorCode;
        Errors = errors;
        Code = statusCode;
    }

    public BaseException(HttpEnums statusCode, params string[] errors) : this(statusCode, 0, errors) { }

    protected BaseException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        Code = HttpEnums.InternalServerError;
        Errors = new string[] { "Default Serializable Constructor" };
    }

    public ResponseError GetResponseError() =>
        Response.GetResponseError(Code, ErrorCode, Errors.ToArray());
}