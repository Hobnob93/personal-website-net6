using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class HeroTile : BaseComponent
{
    [Parameter, EditorRequired]
    public string Text { get; set; } = default!;

    public string Classes => new ClassBuilder()
        .Add("hero-tile")
        .Add("flex-grow-1")
        .Add(Class!, condition: Class is not null)
        .Build();
}
