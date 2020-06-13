﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public abstract class SemanticComponent : ComponentBase
    {
        private Tooltip _tooltip = new Tooltip();

        protected SemanticComponent(string cssName, bool prefixUiClass = true)
        {
            this.CssName = cssName;
            this.PrefixUiClass = prefixUiClass;
        }

        [Parameter]
        public Tooltip Tooltip
        {
            get => _tooltip;
            set => _tooltip = value ?? new Tooltip();
        }

        [Parameter]
        public string TooltipContent
        {
            get => this.Tooltip.Content;
            set => this.Tooltip.Content = value;
        }

        [Parameter]
        public string Title { get; set; }

        protected string CssName { get; set; }

        protected bool PrefixUiClass { get; set; }

        protected string Class()
        {
            return new[]
            {
                this.PrefixUiClass.ToClassIf("ui")
            }
            .Concat(this.Classes())
            .Concat(new [] { this.CssName })
            .Concat(this.AfterCssNameClasses())
            .ToClass();
        }

        protected abstract IEnumerable<string> Classes();

        protected virtual IEnumerable<string> AfterCssNameClasses()
        {
            yield break;
        }

        protected Dictionary<string, object> Attributes()
        {
            var attributes = new Dictionary<string, object>();
            InitializeAttributes(attributes);
            return attributes;
        }

        protected virtual void InitializeAttributes(Dictionary<string, object> attributes)
        {
            this.Tooltip.SetAttributes(attributes);
            this.Title.SetAsAttribute("title", attributes);
        }
    }
}
