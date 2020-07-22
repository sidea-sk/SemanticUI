﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.TagHelpers;

namespace SemanticUI.TagHelpers.Sample.TagHelpers
{
    [HtmlTargetElement("sl-example")]
    public class ExampleTagHelper : TagHelper
    {
        public string Header { get; set; }
        public string Text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "ui segment");
            output.PreContent.SetHtmlContent($"<h4>{Header}</h4><p>{Text}</p>");
        }
    }
}
