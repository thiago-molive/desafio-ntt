using Ambev.DeveloperEvaluation.Domain.Exceptions;

namespace Ambev.DeveloperEvaluation.WebApi.Middleware;

internal sealed class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(
        RequestDelegate next,
        ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Exception occurred: {Message}", exception.Message);

            ExceptionDetails exceptionDetails = GetExceptionDetails(exception);

            var problemDetails = new CustomProblemDetails(exceptionDetails.Type, exceptionDetails.Error, exceptionDetails.Detail);

            context.Response.StatusCode = exceptionDetails.Status;

            await context.Response.WriteAsJsonAsync(problemDetails);
        }
    }

    private static ExceptionDetails GetExceptionDetails(Exception exception)
    {
        return exception switch
        {
            //ValidationException validationException => new ExceptionDetails(
            //    StatusCodes.Status400BadRequest,
            //    "ValidationFailure",
            //    "Validation error",
            //    "One or more validation errors occurred",
            //    validationException.Errors),

            ResourceNotFoundException resourceNotFoundException => new ExceptionDetails(
                StatusCodes.Status400BadRequest,
                "ResourceNotFound",
                resourceNotFoundException.Code,
                resourceNotFoundException.Message),

            AuthenticationException authenticationException => new ExceptionDetails(
                StatusCodes.Status401Unauthorized,
                "AuthenticationError",
                authenticationException.Code,
                authenticationException.Message),

            _ => new ExceptionDetails(
                StatusCodes.Status500InternalServerError,
                "ServerError",
                "Server error",
                "An unexpected error has occurred")
        };
    }

    internal sealed record ExceptionDetails(
        int Status,
        string Type,
        string Error,
        string Detail,
        IEnumerable<object>? Errors = null);

    internal record CustomProblemDetails(string type, string error, string detail);
}