using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = this.TagName;
            output.Attributes.SetAttribute("class", this.Class());

            base.Process(context, output);
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
