using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

using System.Collections.Generic;
using System.Linq;

namespace Sidea.SemanticUI.TagHelpers
{
    public abstract class SemanticTagHelper : TagHelper
    {
        private readonly bool _prefixUi;

        protected SemanticTagHelper(
            string cssName,
            string tagName,
            bool prefixUi = true)
        {
            this.CssName = cssName;
            this.TagName = tagName;
            _prefixUi = prefixUi;
        }

        protected string TagName { get; }

        protected string CssName { get; }

        protected TagMode TagMode { get; set; } = TagMode.StartTagAndEndTag;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = this.TagName;
            output.TagMode = this.TagMode;

            output.Attributes.SetAttribute("class", this.Class());
        }

        protected string Class()
        {
            return new []
                {
                    "ui".ToClassIf(_prefixUi)
                }
                .Concat(this.Classes())
                .Concat(new[] { this.CssName })
                .Concat(this.AfterCssNameClasses())
                .ToClass();
        }

        protected abstract IEnumerable<string> Classes();

        protected virtual IEnumerable<string> AfterCssNameClasses()
        {
            yield break;
        }
    }
}
