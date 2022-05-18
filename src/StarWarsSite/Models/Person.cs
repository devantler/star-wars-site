namespace StarWarsSite.Models;

public record Person
{
    public string Name {get; internal set; } = "";
    public string Height { get; internal set; } = "";
    public string Mass { get; internal set; } = "";
    public string HairColor { get; internal set; } = "";
    public string SkinColor { get; internal set; } = "";
    public string EyeColor { get; internal set; } = "";
    public string BirthYear { get; internal set; } = "";
    public string Gender {get; internal set; } = "";
    public string Homeworld { get; internal set; } = "";
    public string Specie { get; internal set; } = "";
}