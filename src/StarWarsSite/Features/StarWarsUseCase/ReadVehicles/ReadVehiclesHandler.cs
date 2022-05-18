using MediatR;
using StarWarsSite.Models;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;
namespace StarWarsSite.Features.StarWarsUseCase.ReadVehicles;

public class ReadVehiclesHandler : IRequestHandler<ReadVehiclesQuery, IEnumerable<Vehicle>>
{
    private readonly ContentDeliveryService _contentDeliveryService;
    public ReadVehiclesHandler(ContentDeliveryService contentDeliveryService)
    {
        _contentDeliveryService = contentDeliveryService;
    }
    public async Task<IEnumerable<Vehicle>> Handle(ReadVehiclesQuery request, CancellationToken cancellationToken)
    {
        var data = await _contentDeliveryService.Content.GetByType("vehicle", null, 1, 100);
        return from itemContent in data.Content.Items select MapItemContentToVehicle(itemContent);
    }

    private static Vehicle MapItemContentToVehicle(Content itemContent)
    {
        return new Vehicle()
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
            VehicleClass = itemContent.Properties["vehicleClass"].ToString() ?? "Unknown"
        };
    }
}