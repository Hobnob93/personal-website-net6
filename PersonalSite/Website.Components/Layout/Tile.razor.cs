using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class Tile : BaseSiteComponent
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private IJSRuntime JsInterop { get; set; } = default!;

    [Parameter, EditorRequired]
    public string Char { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string Name { get; set; } = string.Empty;

    [Parameter]
    public string ImageType { get; set; } = "png";

    private string ImagePath => $"/images/home/{Name}.{ImageType}";
    private string ImageAlt => $"{Name} hero image";

    public string Classes => new ClassBuilder()
        .Add("hero-tile")
        .Add(Class!, condition: Class is not null)
        .Build();

    private void OnButtonClicked()
    {
        NavigationManager.NavigateTo($"/{Name.ToLower()}");
    }

    private async Task OnDivClicked()
    {
        var allowClick = await JsInterop.InvokeAsync<bool>("blazor_tileClick");
        if (allowClick)
            OnButtonClicked();
    }
}
