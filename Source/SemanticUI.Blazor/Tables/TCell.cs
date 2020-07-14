using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Sidea.SemanticUI.Core;

namespace Sidea.SemanticUI.Blazor
{
    public class TCell : TRowCell
    {
        [Parameter]
        public Position Alignment { get; set; } = Position.Default;

        [Parameter]
        public bool Collapsing { get; set; }

        [Parameter]
        public int RowSpan { get; set; }

        [Parameter]
        public int CellSpan { get; set; }

        [Parameter]
        public Amount Wide { get; set; }

        protected override IEnumerable<string> Classes()
        {
            return base.Classes()
                .Concat(this.ClassesPrivate());
        }

        protected override void InitializeAttributes(Dictionary<string, object> attributes)
        {
            if (this.RowSpan > 1)
            {
                attributes.Add("rowspan", this.RowSpan);
            }

            if (this.CellSpan > 1)
            {
                attributes.Add("cellspan", this.RowSpan);
            }
        }

        private IEnumerable<string> ClassesPrivate()
        {
            yield return "collapsing".ToClassIf(this.Collapsing);
            yield return this.Alignment.ToAlignmentClass();
            yield return this.Wide.ToClass("wide");
        }
    }
}
