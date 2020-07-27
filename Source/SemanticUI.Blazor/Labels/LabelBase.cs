using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public class LabelBase : SemanticComponent
    {
        public LabelBase(string cssName = "label") : base(cssName)
        {
        }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public Size Size { get; set; }

        [Parameter]
        public LabelDecorations Decorations { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
            yield return this.Decorations.ToClass();
        }
    }
}
