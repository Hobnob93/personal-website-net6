using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class HeroTileSection : BaseComponent
{
    [Parameter, EditorRequired]
    public string Item1 { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string Item2 { get; set; } = string.Empty;

    public string Classes => new ClassBuilder()
        .Add("hero-column")
        .Add(Class!, condition: Class is not null)
        .Build();
}
