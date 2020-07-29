using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Common
{
    [HtmlTargetElement("sui-detail")]
    public class Detail : SemanticTagHelper
    {
        public Detail() : base("detail", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
