using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components;
using StarWarsSite.Features.StarWarsUseCase.ReadPlanets;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Planets
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private DetailsModal detailsModal = null!;
    private List<Planet> planets = new();

    protected override async Task OnInitializedAsync(){
        var data = await Mediator.Send(new ReadPlanetsQuery());
        planets = data.ToList();
    }
}