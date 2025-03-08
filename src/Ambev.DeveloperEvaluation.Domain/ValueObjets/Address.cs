using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.ValueObjets;

/// <summary>
/// Represents the user's address.
/// </summary>
public class Address : ValueObject
{
    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the street.
    /// </summary>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the number.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the zipcode.
    /// </summary>
    public string Zipcode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the geolocation.
    /// </summary>
    public Geolocation Geolocation { get; set; } = new Geolocation();

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return City;
        yield return Street;
        yield return Number;
        yield return Zipcode;
        yield return Geolocation;
    }
}