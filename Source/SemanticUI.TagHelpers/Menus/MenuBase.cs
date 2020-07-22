using System.Collections.Generic;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    public abstract class MenuBase : SemanticTagHelper
    {
        protected MenuBase(bool prefixUi = true) : base("menu", "div", prefixUi)
        {
        }

        public Orientation Orientation { get; set; } = Orientation.Horizontal;

        public Position Alignment { get; set; } = Position.Left;

        public bool Pointing { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Orientation.ToClass();
            yield return "pointing".ToClassIf(this.Pointing);
            yield return this.Alignment.ToAlignmentClass();
        }
    }
}
