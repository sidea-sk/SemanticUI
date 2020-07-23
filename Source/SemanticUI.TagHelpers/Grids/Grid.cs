﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-grid")]
    public class Grid : SemanticTagHelper
    {
        public Grid() : base("grid", "div")
        {
        }

        public Amount Columns { get; set; }

        public bool Stackable { get; set; }

        public bool IsContainer { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Columns.ToClass("column");
            yield return "stackable".ToClassIf(this.Stackable);
        }

        protected override IEnumerable<string> AfterCssNameClasses()
        {
            return base.AfterCssNameClasses()
                .Concat(new[] { this.IsContainer.ToClassIf("container") })
                ;
        }
    }
}