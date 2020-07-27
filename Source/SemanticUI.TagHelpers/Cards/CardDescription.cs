using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers.Cards
{
    [HtmlTargetElement("sui-card-description")]
    public class CardDescription : SemanticTagHelper
    {
        public CardDescription() : base("description", "div", false)
        {
        }

        protected override IEnumerable<string> Classes()
        {
            yield break;
        }
    }
}
