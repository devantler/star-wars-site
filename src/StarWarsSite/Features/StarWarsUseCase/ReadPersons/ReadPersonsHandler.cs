using AutoMapper;
using MediatR;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;

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
        var root = await _contentDeliveryService.Content.GetRoot();
        var content = root.Single(x => x.Name == "People");
        var childrenPagedContent = await _contentDeliveryService.Content.GetChildren(content.Id, null, 1, 100);
        var result = new List<Person>();
        foreach (var childContent in childrenPagedContent.Content.Items)
        {
            var properties = childContent.Properties;
            result.Add(new Person{
                Name = (string)properties.FirstOrDefault(x => x.Key == "personName").Value,
                Gender = (string)properties.FirstOrDefault(x => x.Key == "gender").Value,
                //Specie = (string)properties.FirstOrDefault(x => x.Key == "specie").Value
            });
        }
        return result;
    }
}