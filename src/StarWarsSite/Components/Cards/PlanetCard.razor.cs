using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Models;

namespace StarWarsSite.Components.Cards;

public partial class PlanetCard
{
    [Parameter] public DetailsModal DetailsModal { get; set; } = null!;
    [Parameter] public Planet Planet { get; set; } = null!;

    private static string ToMillions(string? number)
    {
        if (number?.Equals("Unknown", StringComparison.OrdinalIgnoreCase) != false) return "Unknown";

        var numberValue = double.Parse(number);
        return $"{numberValue / 1000000}M";
    }
}