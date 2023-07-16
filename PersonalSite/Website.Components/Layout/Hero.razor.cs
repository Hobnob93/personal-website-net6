using Microsoft.AspNetCore.Components;

namespace Website.Components.Layout;

public partial class Hero
{
    [Parameter, EditorRequired]
    public RenderFragment ChildContent { get; set; } = default!;
}
