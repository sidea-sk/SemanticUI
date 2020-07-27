﻿using System;
using System.Collections.Generic;

namespace Sidea.SemanticUI.Core
{
    public class IconData
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; } = Color.NoColor;

        public IconDecorations Decorations { get; set; }

        public string ToClass() => this.Classes().ToClass();

        private IEnumerable<string> Classes()
        {
            yield return this.Name;
            yield return this.Size.ToClass();
            yield return this.Color.ToClass();
            yield return this.Decorations.ToClass();
        }
    }
}
