using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Features.StarWarsUseCase.ReadPlanets;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Planets
{
    private DetailsModal _detailsModal = null!;
    private List<Planet> _planets = new();
    [Inject] private IMediator Mediator { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        var data = await Mediator.Send(new ReadPlanetsQuery());
        _planets = data.ToList();
    }
}