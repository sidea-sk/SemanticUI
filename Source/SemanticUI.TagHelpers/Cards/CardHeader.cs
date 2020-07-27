using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Cards
{
    [HtmlTargetElement("sui-card-header")]
    public class CardHeader : SemanticTagHelper
    {
        public CardHeader() : base("header", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
