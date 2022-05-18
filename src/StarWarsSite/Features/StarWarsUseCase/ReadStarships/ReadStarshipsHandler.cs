using MediatR;
using Newtonsoft.Json.Linq;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadStarships;

public class ReadStarshipsHandler : IRequestHandler<ReadStarshipsQuery, IEnumerable<Starship>>
{
    private readonly ContentDeliveryService _contentDeliveryService;

    public ReadStarshipsHandler(ContentDeliveryService contentDeliveryService)
    {
        _contentDeliveryService = contentDeliveryService;
    }

    public async Task<IEnumerable<Starship>> Handle(ReadStarshipsQuery request, CancellationToken cancellationToken)
    {
        var data = await _contentDeliveryService.Content.GetByType("starship", null, 1, 100);
        return from itemContent in data.Content.Items select MapItemContentToStarship(itemContent);
    }

    private static Starship MapItemContentToStarship(Content itemContent)
    {
        var hyperdriveRating = itemContent.Properties["hyperdriveRating"].ToString();
        var mglt = itemContent.Properties["mglt"].ToString();
        var starshipClass = itemContent.Properties["starshipClass"].ToString();
        return new Starship
        {
            Name = itemContent.Name,
            Model = itemContent.Properties["model"].ToString() ?? "Unknown",
            Manufacturer = itemContent.Properties["manufacturer"].ToString() ?? "Unknown",
            CostInCredits = itemContent.Properties["costInCredits"].ToString() ?? "Unknown",
            Length = itemContent.Properties["length"].ToString() ?? "Unknown",
            MaxAtmospheringSpeed = itemContent.Properties["maxAtmospheringSpeed"].ToString() ?? "Unknown",
            Crew = itemContent.Properties["crew"].ToString() ?? "Unknown",
            Passengers = itemContent.Properties["passengers"].ToString() ?? "Unknown",
            CargoCapacity = itemContent.Properties["cargoCapacity"].ToString() ?? "Unknown",
            Consumables = itemContent.Properties["consumables"].ToString() ?? "Unknown",
            HyperdriveRating = !string.IsNullOrEmpty(hyperdriveRating) ? hyperdriveRating : "Unknown",
            MGLT = !string.IsNullOrEmpty(mglt) ? mglt : "Unknown",
            StarshipClass = !string.IsNullOrEmpty(starshipClass) ? starshipClass : "Unknown",
            Pilots = ((JArray)itemContent.Properties["pilots"])?.Select(x => x.Value<string>("name")).ToArray() ??
                     new[] { "None" }
        };
    }
}