﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.TagHelpers
{
    [HtmlTargetElement("sui-icon")]
    public class Icon : SemanticTagHelper
    {
        private IconData _data = new IconData();

        public Icon() : base("icon", "i", false)
        {
        }

        public IconData Data
        {
            get => _data;
            set => _data = value ?? new IconData();
        }

        public string Name
        {
            get => _data.Name;
            set => _data.Name = value;
        }

        public Size Size
        {
            get => _data.Size;
            set => _data.Size = value;
        }

        public Color Color
        {
            get => _data.Color;
            set => _data.Color = value;
        }

        public IconDecorations Decorations
        {
            get => _data.Decorations;
            set => _data.Decorations = value;
        }

        protected override IEnumerable<string> Classes()
        {
            yield return _data.ToClass();
        }
    }
}
