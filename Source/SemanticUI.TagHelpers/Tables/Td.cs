using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Tables
{
    [HtmlTargetElement("sui-td")]
    public class Td : TCell
    {
        public Td() : base("td")
        {
        }
    }
}
