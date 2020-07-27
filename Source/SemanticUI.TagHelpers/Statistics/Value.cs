using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Statistics
{
    [HtmlTargetElement("sui-statistic-value")]
    public class Value : SemanticTagHelper
    {
        public Value() : base("value", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
