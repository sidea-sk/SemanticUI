using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-button")]
    public class ButtonTagHelper : SemanticTagHelper
    {
        private SingleButtonData _data = Activator.CreateInstance<SingleButtonData>();

        public ButtonTagHelper() : base("button", "button")
        {
        }

        public SingleButtonData Data 
        {
            get => _data;
            set => _data = value ?? Activator.CreateInstance<SingleButtonData>();
        }

        public bool IsVisible
        {
            get => _data.IsVisible;
            set => _data.IsVisible = value;
        }

        public Color Color
        {
            get => _data.Color;
            set => _data.Color = value;
        }

        public Size Size
        {
            get => _data.Size;
            set => _data.Size = value;
        }

        public ButtonDecoration Decoration
        {
            get => _data.Decoration;
            set => _data.Decoration = value;
        }

        public bool Fluid
        {
            get => _data.Fluid;
            set => _data.Fluid = value;
        }

        public Position Floated
        {
            get => _data.Floated;
            set => _data.Floated = value;
        }

        public Position Attached
        {
            get => _data.Attached;
            set => _data.Attached = value;
        }

        protected override IEnumerable<string> Classes()
        {
            yield return this.Decoration.ToClass();
            yield return "fluid".ToClassIf(this.Fluid);
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
            yield return this.Floated.ToFloatedClass();
            yield return this.Attached.ToAttachedClass();
        }
    }
}
