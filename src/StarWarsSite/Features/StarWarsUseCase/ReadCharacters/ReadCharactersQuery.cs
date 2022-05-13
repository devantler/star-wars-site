using MediatR;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadCharacters;

public record ReadCharactersQuery() : IRequest<IEnumerable<Character>>;