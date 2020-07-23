using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-segment")]
    public class Segment : SemanticTagHelper
    {
        public Segment() : base("segment", "div")
        {
        }

        public Color Color { get; set; }

        public bool Inverted { get; set; }

        public bool Compact { get; set; }

        public bool Secondary { get; set; }

        public bool Loading { get; set; }

        public bool Stacked { get; set; }

        public bool Raised { get; set; }

        public bool Piled { get; set; }

        public bool Placeholder { get; set; }

        public bool Blurred { get; set; }

        public Orientation Orientation { get; set; } = Orientation.Horizontal;

        protected override IEnumerable<string> Classes()
        {
            yield return "blurring dimmable dimmed".ToClassIf(this.Blurred);
            yield return "placeholder".ToClassIf(this.Placeholder);
            yield return "compact".ToClassIf(this.Compact);
            yield return this.Color.ToClass();
            yield return "secondary".ToClassIf(this.Secondary);
            yield return "piled".ToClassIf(this.Piled);
            yield return "stacked".ToClassIf(this.Stacked);
            yield return "raised".ToClassIf(this.Raised);
            yield return "inverted".ToClassIf(this.Inverted);
            yield return "loading".ToClassIf(this.Loading);
            yield return this.Orientation.ToClass(emptyIf: Orientation.Horizontal);
        }
    }
}
