using MediatR;
using StarWarsSite.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadVehicles;

public record ReadVehiclesQuery : IRequest<IEnumerable<Vehicle>>;