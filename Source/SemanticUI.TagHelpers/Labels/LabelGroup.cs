using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers.Labels
{
    [HtmlTargetElement("sui-labelGroup")]
    public class LabelGroup : SemanticTagHelper
    {
        public LabelGroup() : base("labels", "div")
        {
        }

        public Color Color { get; set; }

        public Size Size { get; set; }

        // only circular and tag
        public LabelDecorations Decorations { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
            yield return this.Decorations.ToClass();
        }
    }
}
