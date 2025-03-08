namespace Ambev.DeveloperEvaluation.Application.Users.CreateUser;

/// <summary>
/// Represents the response returned after successfully creating a new user.
/// </summary>
/// <remarks>
/// This response contains the details of the newly created user,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateUserResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created user.
    /// </summary>
    /// <value>An integer that uniquely identifies the created user in the system.</value>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the email of the newly created user.
    /// </summary>
    /// <value>A string representing the email of the created user.</value>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the username of the newly created user.
    /// </summary>
    /// <value>A string representing the username of the created user.</value>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the password of the newly created user.
    /// </summary>
    /// <value>A string representing the password of the created user.</value>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the name of the newly created user.
    /// </summary>
    /// <value>An object representing the name of the created user.</value>
    public CreateUserName Name { get; set; }

    /// <summary>
    /// Gets or sets the address of the newly created user.
    /// </summary>
    /// <value>An object representing the address of the created user.</value>
    public CreateUserAddress Address { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the newly created user.
    /// </summary>
    /// <value>A string representing the phone number of the created user.</value>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the status of the newly created user.
    /// </summary>
    /// <value>A string representing the status of the created user.</value>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the role of the newly created user.
    /// </summary>
    /// <value>A string representing the role of the created user.</value>
    public string Role { get; set; }
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
