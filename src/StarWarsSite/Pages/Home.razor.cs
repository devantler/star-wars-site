using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace StarWarsSite.Pages;

public partial class Home
{
    [Inject] private IJSRuntime JsRuntime  { get; set; } = null!;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
            await PlayBackgroundMusic();
    }

    public async Task PlayBackgroundMusic()
    {
        await JsRuntime.InvokeAsync<string>("PlayAudio", "bgm");
    }
}