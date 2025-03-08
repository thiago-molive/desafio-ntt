namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public sealed class ResourceNotFoundException : Exception
{
    public string Code { get; set; }

    public ResourceNotFoundException(Error error)
        : base(error.Detail)
    {
        Code = error.Title;
    }

    public static void ThrowIfNull(object? value, Error error)
    {
        if (value is null)
            throw new ResourceNotFoundException(error);
    }
}