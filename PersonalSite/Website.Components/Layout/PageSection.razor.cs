using Microsoft.AspNetCore.Components;

namespace Website.Components.Layout;

public partial class PageSection : BaseSiteComponent
{
    [Parameter, EditorRequired]
    public RenderFragment ChildContent { get; set; } = default!;

    [Parameter]
    public string? Title { get; set; }
}