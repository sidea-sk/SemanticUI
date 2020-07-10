using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public class SingleButtonBase : ButtonBase<SingleButtonData>
    {
        protected SingleButtonBase(): base("button")
        {
        }

        [Parameter]
        public ButtonState ButtonState { get; set; }

        [Parameter]
        public Emphasizes Emphasizes { get; set; }

        public bool Disabled => this.ButtonState != ButtonState.Enabled && this.ButtonState != ButtonState.Active;

        protected override IEnumerable<string> Classes()
        {
            return base.Classes()
                .Concat(new[] {
                    this.ButtonState.ToClass(),
                    this.Emphasizes.ToClass()
                });
        }
    }
}
