using MediatR;
using Microsoft.AspNetCore.Components;
using StarWarsSite.Features.StarWarsUseCase.ReadCharacters;
using StarWarsSite.Models;

namespace StarWarsSite.Pages;

public partial class Characters
{
    [Inject] private IMediator Mediator { get; set; } = null!;

    private IEnumerable<Character> characters = new List<Character>();

    protected override async Task OnInitializedAsync()
    {
        characters = await Mediator.Send(new ReadCharactersQuery());
    }
}