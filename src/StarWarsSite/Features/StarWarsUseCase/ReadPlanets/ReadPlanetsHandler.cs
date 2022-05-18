using System.Linq;
using MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;
namespace StarWarsSite.Features.StarWarsUseCase.ReadPlanets;

public class ReadPlanetsHandler : IRequestHandler<ReadPlanetsQuery, IEnumerable<Planet>>
{
    private readonly ContentDeliveryService _contentDeliveryService;
    public ReadPlanetsHandler(ContentDeliveryService contentDeliveryService)
    {
        _contentDeliveryService = contentDeliveryService;
    }
    public async Task<IEnumerable<Planet>> Handle(ReadPlanetsQuery request, CancellationToken cancellationToken)
    {
        var data = await _contentDeliveryService.Content.GetByType("planet", null, 1, 100);
        return from itemContent in data.Content.Items select MapItemContentToPlanet(itemContent);
    }

    private static Planet MapItemContentToPlanet(Content itemContent)
    {
        return new Planet(){
            Name = itemContent.Name,
            RotationPeriod = itemContent.Properties["rotationPeriod"].ToString() ?? "Unknown",
            OrbitalPeriod = itemContent.Properties["orbitalPeriod"].ToString() ?? "Unknown",
            Diameter = itemContent.Properties["diameter"].ToString() ?? "Unknown",
            Climate = ((JArray) itemContent.Properties["climate"]).ToObject<string[]>(),
            Gravity = itemContent.Properties["gravity"].ToString() ?? "Unknown",
            Terrain = ((JArray) itemContent.Properties["terrain"]).ToObject<string[]>(),
            SurfaceWater = itemContent.Properties["surfaceWater"].ToString() ?? "Unknown",
            Population = itemContent.Properties["population"].ToString() ?? "Unknown",
        };
    }
}