using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Features.StarWarsUseCase.ReadStarships;
using StarWarsSite.Features.StarWarsUseCase.ReadVehicles;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class VehiclesAndStarships
{
    private readonly List<VehicleOrStarship> _vehiclesAndStarships = new();

    private DetailsModal _detailsModal = null!;
    [Inject] private IMediator Mediator { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        var starships = await Mediator.Send(new ReadStarshipsQuery());
        var vehicles = await Mediator.Send(new ReadVehiclesQuery());
        _vehiclesAndStarships.AddRange(starships);
        _vehiclesAndStarships.AddRange(vehicles);
        _vehiclesAndStarships.Sort();
    }
}