using System.Collections.Generic;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    public abstract class LabelBase : SemanticTagHelper
    {
        public LabelBase() : base("label", "div")
        {
        }

        public Color Color { get; set; }

        public Size Size { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
        }
    }
}
