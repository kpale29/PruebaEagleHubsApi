using System.Text.Json;
using ConsumoResponsableApi.Utils.Enums;
using ConsumoResponsableApi.Utils.Exceptions;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Middlewares
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (BaseException baseException)
            {
                await BuildResponseAsync(context, baseException.GetResponseError(), baseException);
            }
            catch (Exception ex)
            {
                await BuildResponseAsync(context,
                    Response.GetResponseError(HttpEnums.InternalServerError, "Internal Server Error"),
                    ex, true);
            }
        }

        private async Task BuildResponseAsync(HttpContext httpContext, ResponseError responseError, Exception ex, bool isFatal = false)
        {

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = responseError.StatusCode;

            var loggingInputObj = new
            {
                error_ex_to_string = ex.ToString()
            };

            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(responseError, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }));
        }
    }
}
