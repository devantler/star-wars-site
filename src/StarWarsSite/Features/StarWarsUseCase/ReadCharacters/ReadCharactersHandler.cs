using MediatR;
using StarWarsSite.Handlers;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadCharacters;

public class ReadCharactersHandler<TRequest, TResponse> : HeartcoreReadAllHandler<ReadCharactersQuery, Character>
{
    // I can override the base class implementation of Handle() if I want a custom implementation for this handler.
}