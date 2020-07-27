using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-form")]
    public class Form : SemanticTagHelper
    {
        public Form() : base("form", "div")
        {
        }

        public Size Size { get; set; }

        public Severity Severity { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Size.ToClass();
            yield return this.Severity.ToClass();
        }
    }
}
