using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using Website.Components.Builders;

namespace Website.Components.Layout;

public partial class Hero : BaseSiteComponent
{
    [Parameter, EditorRequired]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string ImageType { get; set; } = "png";

    private string ImagePath => $"/images/home/{Title}Hero.{ImageType}";

    public string Classes => new ClassBuilder()
        .Add("hero")
        .Add(Class!, condition: Class is not null)
        .Build();

    public string Styles => new CssBuilder(Style ?? string.Empty)
        .Add("background", $"url({ImagePath})")
        .Build();
}