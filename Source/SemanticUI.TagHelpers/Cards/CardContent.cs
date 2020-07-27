using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers.Cards
{
    [HtmlTargetElement("sui-card-content")]
    public class CardContent : SemanticTagHelper
    {
        public CardContent() : base("content", "div", false)
        {
        }

        public bool Extra { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return "extra".ToClassIf(this.Extra);
        }
    }
}
