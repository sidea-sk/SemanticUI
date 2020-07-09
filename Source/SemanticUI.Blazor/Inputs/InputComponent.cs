using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public class InputComponent : SemanticComponent
    {
        public InputComponent(string cssName, bool prefixUiClass = true) : base(cssName, prefixUiClass)
        {
        }

        [Parameter]
        public EditState State { get; set; }

        protected override IEnumerable<string> Classes()
        {
            yield return this.State.ToClass();
        }
    }
}
