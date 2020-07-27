﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers.Cards
{
    [HtmlTargetElement("sui-card")]
    public class Card : SemanticTagHelper
    {
        public Card() : base("card", "div")
        {
        }

        public Color Color { get; set; }

        public CardDecorations Decorations { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Color.ToClass();
            yield return this.Decorations.ToClass();
        }
    }
}
