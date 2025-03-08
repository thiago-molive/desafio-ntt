namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public sealed class AuthenticationException : Exception
{
    public string Code { get; set; }

    public AuthenticationException(Error error)
        : base(error.Detail)
    {
        Code = error.Title;
    }

    public static void ThrowIfNull(object? value, Error error)
    {
        if (value is null)
            throw new AuthenticationException(error);
    }
}