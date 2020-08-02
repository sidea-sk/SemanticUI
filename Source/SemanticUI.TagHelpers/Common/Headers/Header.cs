using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Common.Headers
{
    [HtmlTargetElement("sui-header")]
    public class Header : HeaderBase
    {
        public Header() : base("header", true)
        {
        }
    }
}
