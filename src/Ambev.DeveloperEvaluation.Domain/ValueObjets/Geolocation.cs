using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.ValueObjets;

/// <summary>
/// Represents the geolocation.
/// </summary>
public class Geolocation : ValueObject
{
    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    public string Lat { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    public string Long { get; set; } = string.Empty;

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Lat;
        yield return Long;
    }
}