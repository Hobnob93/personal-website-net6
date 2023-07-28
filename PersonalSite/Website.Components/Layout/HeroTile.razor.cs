using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class HeroTile : BaseComponent
{
    [Parameter, EditorRequired]
    public string Char { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string Name { get; set; } = string.Empty;

    private string ImagePath => $"/images/home/{Name}.png";
    private string ImageAlt => $"{Name} hero image";

    public string Classes => new ClassBuilder()
        .Add("hero-tile")
        .Add(Class!, condition: Class is not null)
        .Build();
}
