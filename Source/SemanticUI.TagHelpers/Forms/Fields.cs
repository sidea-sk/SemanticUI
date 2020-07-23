using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-fields")]
    public class Fields : SemanticTagHelper
    {
        public Fields() : base("fields", "div")
        {
        }

        public Amount Count { get; set; }

        public bool Inline { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Count.ToClass(string.Empty);
            yield return "inline".ToClassIf(this.Inline);
        }
    }
}
