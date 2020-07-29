using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Common
{
    [HtmlTargetElement("sui-description")]
    public class Description : SemanticTagHelper
    {
        public Description() : base("description", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
