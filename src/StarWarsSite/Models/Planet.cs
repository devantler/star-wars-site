namespace StarWarsSite.Models;

public record Planet(
    string Name,
    string Population,
    List<string?> Climate
);