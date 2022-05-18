namespace StarWarsSite.Models;

public record Vehicle : VehicleOrStarship
{
    public string VehicleClass { get; internal set; } = "";
}