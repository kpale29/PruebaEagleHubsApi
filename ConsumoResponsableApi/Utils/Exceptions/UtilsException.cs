using System.Runtime.Serialization;

namespace ConsumoResponsableApi.Utils.Exceptions;

[Serializable]
public class UtilsException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Exception"/> class with a specified error message
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public UtilsException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exception"/> class with a specified error message
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
    public UtilsException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exception"/> class with a specified error message
    /// </summary>
    /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination</param>
    protected UtilsException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}