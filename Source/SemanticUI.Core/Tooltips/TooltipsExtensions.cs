﻿using System.Collections.Generic;

namespace Sidea.SemanticUI.Core
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
            tooltip.Position.ToPositionClass().SetAsAttribute("data-position", attributes);

            if (tooltip.InvertedTooltip)
            {
                string.Empty.SetAsAttribute("data-inverted", attributes);
            }
        }
    }
}
