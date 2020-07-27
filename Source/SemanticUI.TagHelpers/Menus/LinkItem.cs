using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-linkItem")]
    public class LinkItem : AnchorTagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LinkItem(IHttpContextAccessor httpContextAccessor, IHtmlGenerator generator) : base(generator)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public ActiveUrlMatch ActiveUrlMatch { get; set; } = ActiveUrlMatch.Exact;

        public Color Color { get; set; }

        public string RightIconName { get; set; }

        public bool IsActive { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("class", this.CreateClasses().ToClass());

            if (!string.IsNullOrWhiteSpace(this.RightIconName))
            {
                var iconClass = $"ui {this.RightIconName} icon";
                output.PostContent.SetHtmlContent($"<i class=\"{iconClass}\"></i>");
            }

            base.Process(context, output);
        }

        private IEnumerable<string> CreateClasses()
        {
            yield return "active".ToClassIf(this.IsActiveClass());
            yield return this.Color.ToClass();
            yield return "item";
        }

        private bool IsActiveClass()
        {
            if (this.IsActive)
            {
                return true;
            }

            if (this.ActiveUrlMatch == ActiveUrlMatch.None|| string.IsNullOrWhiteSpace(this.Page))
            {
                return false;
            }

            var path = _httpContextAccessor.HttpContext.Request.Path.ToString();
            if (this.ActiveUrlMatch == ActiveUrlMatch.Exact)
            {
                path += "/Index";
            }

            return path.Contains(this.Page, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
