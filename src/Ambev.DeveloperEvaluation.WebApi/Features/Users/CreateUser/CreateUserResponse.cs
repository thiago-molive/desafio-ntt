using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;

/// <summary>
/// API response model for CreateUser operation
/// </summary>
public class CreateUserResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's full name
    /// </summary>
    public CreateUserName Name { get; set; }

    /// <summary>
    /// The user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The user's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the address of the newly created user.
    /// </summary>
    /// <value>An object representing the address of the created user.</value>
    public CreateUserAddress Address { get; set; }

    /// <summary>
    /// The user's role in the system
    /// </summary>
    public string Role { get; set; }

    /// <summary>
    /// The current status of the user
    /// </summary>
    public string Status { get; set; }
}

public class CreateUserName
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}

public class CreateUserAddress
{
    public string City { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
    public string Zipcode { get; set; }
    public CreateUserGeolocation Geolocation { get; set; }
}

public class CreateUserGeolocation
{
    public string Lat { get; set; }
    public string Long { get; set; }
}
