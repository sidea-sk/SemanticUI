﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-row")]
    public class Row : SemanticTagHelper
    {
        public Row() : base("row", "div", false)
        {
        }

        public Amount Columns { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Columns.ToClass("column");
        }
    }
}
