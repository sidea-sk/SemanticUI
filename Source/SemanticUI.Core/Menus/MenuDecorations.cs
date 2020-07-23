using System;

using static Sidea.SemanticUI.Core.MenuDecorations;

namespace Sidea.SemanticUI.Core
{
    [Flags]
    public enum MenuDecorations
    {
        None       = 0,
        Icon       = 1 << 0,
        Labeled    = 1 << 1,
        Pointing   = 1 << 2,
        Inverted   = 1 << 3,
        Fluid      = 1 << 4,
        Compact    = 1 << 5,
        Borderless = 1 << 6
    }

    public static class MenuDecorationsExtensions
    {
        public static string ToClass(this MenuDecorations decorations)
        {
            var classes = new string[]
            {
                "labeled".ToClassIf(decorations.HasFlag(Labeled)),
                "icon".ToClassIf(decorations.HasFlag(Icon)),
                "pointing".ToClassIf(decorations.HasFlag(MenuDecorations.Pointing)),
                "compact".ToClassIf(decorations.HasFlag(Compact)),
                "fluid".ToClassIf(decorations.HasFlag(Fluid)),
                "borderless".ToClassIf(decorations.HasFlag(Borderless)),
                "inverted".ToClassIf(decorations.HasFlag(Inverted))
            };

            return classes.ToClass();
        }
    }
}
