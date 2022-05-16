using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Planets
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private List<Planet> planets = new List<Planet>{
        new Planet("Tatooine", "Tatooine"),
        new Planet("Alderaan", "Alderaan"),
        new Planet("Yavin IV", "Yavin IV"),
        new Planet("Hoth", "Hoth"),
        new Planet("Dagobah", "Dagobah")
    };

    protected override async Task OnInitializedAsync()
    {
        //planets = await Mediator.Send(new ReadPlanetsQuery());
    }
}