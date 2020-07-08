using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor.Buttons
{
    public abstract class ButtonBase : SemanticComponent
    {
        public ButtonBase() : base(cssName: "button")
        {
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool IsBusy { get; set; }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public Size Size { get; set; }

        [Parameter]
        public bool Basic { get; set; } = false;

        [Parameter]
        public bool Fluid { get; set; } = false;

        [Parameter]
        public Emphasizes Emphasizes { get; set; }

        [Parameter]
        public bool Icon { get; set; } = true;

        [Parameter]
        public bool Enabled { get; set; } = true;

        public bool Disabled => !this.Enabled;

        protected override IEnumerable<string> Classes()
        {
            yield return this.Icon.ToClassIf("icon");
            yield return this.Fluid.ToClassIf("fluid");
            yield return this.Color.ToClass();
            yield return this.Size.ToClass();
            yield return this.Basic.ToClassIf("basic");
            yield return this.Emphasizes.ToClass();
            yield return this.IsBusy.ToClassIf("sync loading");
        }
    }
}
