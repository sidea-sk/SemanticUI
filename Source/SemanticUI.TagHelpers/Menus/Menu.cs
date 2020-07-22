using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-menu")]
    public class Menu : MenuBase
    {
        public Menu() : base(true)
        {
        }
    }
}
