using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class HeroTile : BaseComponent
{
    [Parameter, EditorRequired]
    public string Text { get; set; } = string.Empty;

    public string Classes => new ClassBuilder()
        .Add("hero-tile")
        .Add(Class!, condition: Class is not null)
        .Build();
}
