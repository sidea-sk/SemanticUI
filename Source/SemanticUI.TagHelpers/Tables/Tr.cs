using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Tables
{
    [HtmlTargetElement("sui-tr")]
    public class Tr : TRowCell
    {
        public Tr() : base("tr")
        {
        }
    }
}
