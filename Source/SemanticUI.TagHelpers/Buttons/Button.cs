using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-button")]
    public class Button : SingleButtonBase
    {
        public Button() : base("button")
        {
        }
    }
}
