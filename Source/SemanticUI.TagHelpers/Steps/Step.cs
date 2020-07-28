﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers.Steps
{
    [HtmlTargetElement("sui-step")]
    public class Step : SemanticTagHelper
    {
        public Step() : base("step", "div", false)
        {
        }

        public StepDecorations Decorations { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Decorations.ToClass();
        }
    }
}
