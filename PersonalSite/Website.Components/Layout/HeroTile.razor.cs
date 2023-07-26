using Microsoft.AspNetCore.Components;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class HeroTile : BaseComponent
{
    [Parameter, EditorRequired]
    public string Text { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public string ImageName { get; set; } = string.Empty;

    private string ImagePath => $"/images/home/{ImageName}.png";
    private string ImageAlt => $"{ImageName} hero image";

    public string Classes => new ClassBuilder()
        .Add("hero-tile")
        .Add(Class!, condition: Class is not null)
        .Build();
}
