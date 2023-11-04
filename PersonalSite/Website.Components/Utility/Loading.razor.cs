using Website.Components.Builders;

namespace Website.Components.Utility;

public partial class Loading : BaseSiteComponent
{
    public string Classes => new ClassBuilder()
        .Add("loading-content")
        .Add(Class!, condition: Class is not null)
        .Build();
}
