using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Steps
{
    [HtmlTargetElement("step-content")]
    public class Content : SemanticTagHelper
    {
        public Content() : base("content", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
