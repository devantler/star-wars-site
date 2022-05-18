using MediatR;
using Newtonsoft.Json.Linq;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace StarWarsSite.Features.StarWarsUseCase.ReadPersons;

public class ReadCharactersHandler : IRequestHandler<ReadPersonsQuery, IEnumerable<Person>>
{
    private readonly ContentDeliveryService _contentDeliveryService;

    public ReadCharactersHandler(ContentDeliveryService contentDeliveryService)
    {
        _contentDeliveryService = contentDeliveryService;
    }

    public async Task<IEnumerable<Person>> Handle(ReadPersonsQuery request, CancellationToken cancellationToken)
    {
        var data = await _contentDeliveryService.Content.GetByType("person", null, 1, 100);
        return from itemContent in data.Content.Items select MapItemContentToPerson(itemContent);
    }

    private static Person MapItemContentToPerson(Content itemContent)
    {
        return new Person
        {
            Name = itemContent.Name,
            Height = itemContent.Properties["height"].ToString() ?? "Unknown",
            Mass = itemContent.Properties["mass"].ToString() ?? "Unknown",
            HairColor = itemContent.Properties["hairColor"].ToString() ?? "Unknown",
            SkinColor = itemContent.Properties["skinColor"].ToString() ?? "Unknown",
            EyeColor = itemContent.Properties["eyeColor"].ToString() ?? "Unknown",
            BirthYear = itemContent.Properties["birthYear"].ToString() ?? "Unknown",
            Gender = itemContent.Properties["gender"].ToString() ?? "Unknown",
            Homeworld = ((JObject)itemContent.Properties["homeworld"]).Value<string>("planetName"),
            Specie = ((JObject)itemContent.Properties["specie"])?.Value<string>("name") ?? "Unknown"
        };
    }
}