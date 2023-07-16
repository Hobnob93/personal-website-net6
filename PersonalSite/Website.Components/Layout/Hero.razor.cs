using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class Hero : BaseComponent
{
    [Parameter, EditorRequired]
    public RenderFragment ChildContent { get; set; } = default!;

    public string Classes => new ClassBuilder()
        .Add("hero")
        .Add(Class!, condition: Class is not null)
        .Build();
}
