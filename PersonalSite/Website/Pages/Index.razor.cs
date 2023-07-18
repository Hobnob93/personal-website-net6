using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Website.Pages;

public partial class Index
{
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("randomlySizeHeroColumns");
        }
    }
}
