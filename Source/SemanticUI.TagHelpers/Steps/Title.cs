using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Steps
{
    [HtmlTargetElement("step-title")]
    public class Title : SemanticTagHelper
    {
        public Title() : base("title", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
