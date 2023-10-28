using Microsoft.AspNetCore.Components;

namespace Website.Components.Layout;

public partial class NavMenu
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    private void LogoClicked()
    {
        NavigationManager.NavigateTo("./");
    }
}
