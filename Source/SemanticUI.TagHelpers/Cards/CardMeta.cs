using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Cards
{
    [HtmlTargetElement("sui-card-meta")]
    public class CardMeta : SemanticTagHelper
    {
        public CardMeta() : base("meta", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
