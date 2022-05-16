using MediatR;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadPlanets;

public record ReadPlanetsQuery() : IRequest<IEnumerable<Planet>>;