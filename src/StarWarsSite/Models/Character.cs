namespace StarWarsSite.Models;

public record Character
{
    public string Name { get; init; }
    public string Species { get; init; }
    public string Planet { get; init; }
}