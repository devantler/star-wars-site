namespace StarWarsSite.Models;

public record VehicleOrStarship : IComparable
{
    public string Name { get; internal set; } = "";
    public string Model { get; internal set; } = "";
    public string Manufacturer { get; internal set; } = "";
    public string CostInCredits { get; internal set; } = "";
    public string Length { get; internal set; } = "";
    public string MaxAtmospheringSpeed { get; internal set; } = "";
    public string Crew { get; internal set; } = "";
    public string Passengers { get; internal set; } = "";
    public string CargoCapacity { get; internal set; } = "";
    public string Consumables { get; internal set; } = "";
    public string[] Pilots { get; internal set; } = Array.Empty<string>();
    public int CompareTo(object? obj)
    {
        return Name.CompareTo(((VehicleOrStarship)obj!).Name);
    }
}