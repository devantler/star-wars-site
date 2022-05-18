using MediatR;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadStarships;

public record ReadStarshipsQuery() : IRequest<IEnumerable<Starship>>;