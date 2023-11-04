using Microsoft.AspNetCore.Components;
using Website.Components.Builders;
using Website.Components.Enums;
using Website.Components.Extensions;

namespace Website.Components.Layout;

public partial class FlexBox : BaseSiteComponent
{
    [Parameter, EditorRequired]
    public RenderFragment ChildContent { get; set; } = default!;

    [Parameter]
    public bool IsColumn { get; set; }

    [Parameter]
    public bool FullHeight { get; set; }

    [Parameter]
    public JustifyContent? JustifyContent { get; set; }

    public string Classes => new ClassBuilder()
        .Add("d-flex")
        .Add("flex-column", condition: IsColumn)
        .Add("h-100pc", condition: FullHeight)
        .Add(() => JustifyContent!.GetDisplayName(), condition: JustifyContent is not null)
        .Add(Class!, condition: Class is not null)
        .Build();
}
