using Microsoft.AspNetCore.Components;

namespace MyWebsite.Shared;

public partial class Bolden
{
    [Parameter] public string ColorClass { get; set; } = "mud-secondary-text";
    [Parameter] public bool MakeBold { get; set; }
    [Parameter] public string Text { get; set; } = "<bold text not provided>";
    
    [Parameter] public RenderFragment? ChildContent { get; set; }
}