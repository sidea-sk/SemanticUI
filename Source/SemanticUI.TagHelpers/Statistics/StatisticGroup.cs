using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers.Statistics
{
    [HtmlTargetElement("sui-statistic-group")]
    public class StatisticGroup : SemanticTagHelper
    {
        public StatisticGroup() : base("statistics", "div")
        {
        }

        public Amount Amount { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Amount.ToClass(of: string.Empty);
        }
    }
}
