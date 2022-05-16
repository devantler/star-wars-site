namespace StarWarsSite.Models;

public record Character(
    string Name,
    string Description,
    string Species,
    Planet Planet
);