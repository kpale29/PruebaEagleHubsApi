
using ConsumoResponsableApi.Utils.Enums;

namespace ConsumoResponsableApi.Utils.Exceptions;

[Serializable]
public class DatabaseException : BaseException
{
    public DatabaseException() { }
    public DatabaseException(HttpEnums statusCode, int errorCode, params string[] errors)
        : base(statusCode, errorCode, errors) { }
    public DatabaseException(HttpEnums statusCode, params string[] errors)
        : base(statusCode, 0, errors) { }
}