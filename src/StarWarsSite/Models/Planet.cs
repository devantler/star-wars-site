namespace StarWarsSite.Models;

public record Planet
{
    public string Name { get; internal set; } = "";
    public string RotationPeriod { get; internal set; } = "";
    public string OrbitalPeriod { get; internal set; } = "";
    public string Diameter { get; internal set; } = "";
    public string[] Climate { get; internal set; } = Array.Empty<string>();
    public string Gravity { get; internal set; } = "";
    public string[] Terrain { get; internal set; } = Array.Empty<string>();
    public string SurfaceWater { get; internal set; } = "";
    public string Population { get; internal set; } = "";
}