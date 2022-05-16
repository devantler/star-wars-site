using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Planets
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private readonly List<Planet> planets = new()
    {
        new Planet("Tatooine", "Tatooine"),
        new Planet("Alderaan", "Alderaan"),
        new Planet("Yavin IV", "Yavin IV"),
        new Planet("Hoth", "Hoth"),
        new Planet("Dagobah", "Dagobah")
    };
}