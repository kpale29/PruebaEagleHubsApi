
using ConsumoResponsableApi.Utils.Enums;

namespace ConsumoResponsableApi.Utils.Exceptions;

[Serializable]
public class HttpException : BaseException
{
    public HttpException() { }
    public HttpException(HttpEnums statusCode, int errorCode, params string[] errors)
        : base(statusCode, errorCode, errors) { }
    public HttpException(HttpEnums statusCode, params string[] errors)
        : base(statusCode, 0, errors) { }
}