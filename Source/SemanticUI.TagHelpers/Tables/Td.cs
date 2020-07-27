using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-td")]
    public class Td : TCell
    {
        public Td() : base("td")
        {
        }
    }
}
