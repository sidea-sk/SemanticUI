using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-submenu")]
    public class SubMenu : MenuBase
    {
        public SubMenu() : base(false)
        {
        }
    }
}
