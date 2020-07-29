﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public abstract class ItemBase : SemanticComponent
    {
        protected ItemBase() : base("item", prefixUiClass: false)
        {
        }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public string RightIcon { get; set; }

        protected bool HasRightIcon => !string.IsNullOrWhiteSpace(this.RightIcon);

        protected sealed override IEnumerable<string> Classes()
        {
            yield return this.Color.ToClass();
            yield return "active".ToClassIf(this.IsActive);
        }
    }
}
