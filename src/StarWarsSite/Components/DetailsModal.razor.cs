using Blazorise;
using Microsoft.AspNetCore.Components;

namespace StarWarsSite.Components;

public partial class DetailsModal
{
    [Parameter] public string Title { get; set; } = "";
    [Parameter] public Dictionary<string, string> LabelsAndTexts { get; set; } = new();
    private Modal? modal;

    public void Show(Dictionary<string, string> labelsAndTexts)
    {
        LabelsAndTexts = labelsAndTexts;
        modal.Show();
    }

    public void Hide()
    {
        modal?.Hide();
    }
}