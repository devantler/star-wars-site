namespace StarWarsSite.Models;

public record Starship : VehicleOrStarship
{
    public string HyperdriveRating { get; internal set; } = "";
    public string MGLT { get; internal set; } = "";
    public string StarshipClass { get; internal set; } = "";
}