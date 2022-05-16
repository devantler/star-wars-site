using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Components;
using StarWarsSite.Features.StarWarsUseCase.ReadPersons;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Persons
{
    [Inject] private IMediator Mediator { get; set; } = null!;
    private Details _detailsModal;
    private List<Person> persons = new();

    protected override async Task OnInitializedAsync(){
        var data = await Mediator.Send(new ReadPersonsQuery());
        persons = data.ToList();
    }
}