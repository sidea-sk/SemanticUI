using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Common
{
    [HtmlTargetElement("sui-header")]
    public class Header : SemanticTagHelper
    {
        public Header() : base("header", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
