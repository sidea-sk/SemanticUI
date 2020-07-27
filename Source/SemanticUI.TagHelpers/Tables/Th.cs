using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-th")]
    public class Th : TCell
    {
        public Th() : base("th")
        {
        }
    }
}
