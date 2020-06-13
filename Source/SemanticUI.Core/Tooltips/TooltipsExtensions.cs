using System.Collections.Generic;

namespace Perun.Presentation.Semantic.Core.Tooltips
{
    public static class TooltipsExtensions
    {
        public static void SetAttributes(this Tooltip tooltip, IDictionary<string, object> attributes)
        {
            if(tooltip == null || string.IsNullOrWhiteSpace(tooltip.Content))
            {
                return;
            }
            tooltip.Content.SetAsAttribute("data-tooltip", attributes);
            tooltip.Position.ToClass().SetAsAttribute("data-position", attributes);

            if (tooltip.InvertedTooltip)
            {
                string.Empty.SetAsAttribute("data-inverted", attributes);
            }
        }
    }
}
