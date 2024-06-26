using Microsoft.AspNetCore.Components;
using StarWarsSite.Components.Modals;
using StarWarsSite.Models;

namespace StarWarsSite.Components.Cards;

public partial class PersonCard
{
    [Parameter] public Person Person { get; set; } = null!;
    [Parameter] public DetailsModal DetailsModal { get; set; } = null!;
}