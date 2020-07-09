using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public abstract class ButtonBase : SemanticComponent
    {
        public ButtonBase() : base(cssName: "button")
        {
        }

        [Parameter]
        public ButtonState ButtonState { get; set; }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public Size Size { get; set; }

        [Parameter]
        public ButtonDecoration Decoration { get; set; }

        [Parameter]
        public bool Fluid { get; set; } = false;

        [Parameter]
        public Emphasizes Emphasizes { get; set; }

        public bool Disabled => this.ButtonState != ButtonState.Enabled && this.ButtonState != ButtonState.Active;

        protected override IEnumerable<string> Classes()
        {
            yield return this.Decoration.ToClass();
            // yield return "icon".ToClassIf(this.Icon);
            yield return "fluid".ToClassIf(this.Fluid);
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
            // yield return "basic".ToClassIf(this.Basic);
            yield return this.Emphasizes.ToClass();
            // yield return "sync loading".ToClassIf(this.IsBusy);
        }
    }
}
