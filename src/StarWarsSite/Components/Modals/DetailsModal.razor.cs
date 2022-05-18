using Blazorise;
using Microsoft.AspNetCore.Components;

namespace StarWarsSite.Components.Modals;

public partial class DetailsModal
{
    [Parameter] public string Title { get; set; } = "";
    [Parameter] public List<KeyValuePair<string, string>> LabelsAndTexts { get; set; } = new();
    private Modal? modal;

    public void Show(List<KeyValuePair<string, string>> labelsAndTexts)
    {
        LabelsAndTexts = labelsAndTexts;
        modal.Show();
    }

    public void Hide()
    {
        modal?.Hide();
    }
}