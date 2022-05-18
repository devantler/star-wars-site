using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Features.StarWarsUseCase.ReadPersons;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Persons
{
    private DetailsModal _detailsModal = null!;
    private List<Person> _persons = new();
    [Inject] private IMediator Mediator { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        var data = await Mediator.Send(new ReadPersonsQuery());
        _persons = data.ToList();
    }
}