using MediatR;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadPersons;

public record ReadPersonsQuery() : IRequest<IEnumerable<Person>>;