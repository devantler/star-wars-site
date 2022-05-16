using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Characters
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private List<Character> characters = new List<Character>{
        new Character("Luke Skywalker", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
        new Character("Darth Vader", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
        new Character("Obi-Wan Kenobi", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
        new Character("R2-D2", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
        new Character("C-3PO", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
        new Character("Yoda", "Lorem ipsum", "Human", new Planet("Tatooine", "Tatooine")),
    };

    protected override async Task OnInitializedAsync()
    {
        //characters = await Mediator.Send(new ReadCharactersQuery());
    }
}