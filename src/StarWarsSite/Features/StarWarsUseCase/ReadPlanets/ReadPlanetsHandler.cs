using MediatR;
using Newtonsoft.Json.Linq;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;
using System.Linq;

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
        var result = new List<Planet>();
        var data = await _contentDeliveryService.Content.GetByType("planet", null, 1, 100);
        var planetsContent = data.Content.Items;
        return from planetContent in planetsContent select CreatePlanetFromProperties(planetContent);
    }

    private static Planet CreatePlanetFromProperties(Content planetContent)
    {
        var name = planetContent.Name;
        var rotationPeriod = planetContent.Properties["rotationPeriod"].ToString();
        var orbitalPeriod = planetContent.Properties["orbitalPeriod"].ToString();
        var diameter = planetContent.Properties["diameter"].ToString();
        // var climate = ((JArray)properties.FirstOrDefault(x => x.Key == "climate").Value).ToObject<IEnumerable<string>>();
        // var gravity = (string)properties.FirstOrDefault(x => x.Key == "gravity").Value;
        // var terrain = (string)properties.FirstOrDefault(x => x.Key == "terrain").Value;
        // var surfaceWater = (string)properties.FirstOrDefault(x => x.Key == "surfaceWater").Value;
        var population = planetContent.Properties["population"].ToString();

        return new Planet(name, population, new List<string?>(){"1", "2"});
    }
}