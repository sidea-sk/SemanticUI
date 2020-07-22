using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-menuItem")]
    public class MenuItem : SemanticTagHelper
    {
        public MenuItem() : base("item", "div", false)
        {
        }

        public Color Color { get; set; }

        public string RightIconName { get; set; }

        public bool IsActive { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }

        protected override IEnumerable<string> Classes()
        {
            yield return "active".ToClassIf(this.IsActive);
            yield return this.Color.ToClass();
        }
    }
}
