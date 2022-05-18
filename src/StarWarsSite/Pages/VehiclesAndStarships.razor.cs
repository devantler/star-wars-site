using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Features.StarWarsUseCase.ReadPlanets;
using StarWarsSite.Features.StarWarsUseCase.ReadStarships;
using StarWarsSite.Features.StarWarsUseCase.ReadVehicles;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class VehiclesAndStarships
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private DetailsModal detailsModal = null!;
    private List<VehicleOrStarship> vehiclesAndStarships = new();

    protected override async Task OnInitializedAsync()
    {
        var starships = await Mediator.Send(new ReadStarshipsQuery());
        var vehicles = await Mediator.Send(new ReadVehiclesQuery());
        vehiclesAndStarships.AddRange(starships);
        vehiclesAndStarships.AddRange(vehicles);
        vehiclesAndStarships.Sort();
    }
}