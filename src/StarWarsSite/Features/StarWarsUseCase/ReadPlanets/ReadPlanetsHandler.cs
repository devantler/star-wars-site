using MediatR;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;

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
        var root = await _contentDeliveryService.Content.GetRoot();
        var content = root.Single(x => x.Name == "Planets");
        var childrenPagedContent = await _contentDeliveryService.Content.GetChildren(content.Id, null, 1, 100);
        var result = new List<Planet>();
        foreach (var childContent in childrenPagedContent.Content.Items)
        {
            var properties = childContent.Properties;
            result.Add(new Planet(
                (string)properties.FirstOrDefault(x => x.Key == "planetName").Value,
                (string)properties.FirstOrDefault(x => x.Key == "population").Value
            ));
        }
        return result;
    }
}