using static Sidea.SemanticUI.Core.InputDecorations;

namespace Sidea.SemanticUI.Core
{
    [System.Flags]
    public enum InputDecorations
    {
        NoDecoration = 0,
        Icon         = 1 << 0,
        IconRight    = 1 << 1, // use either Icon or IconRight
        Labeled      = 1 << 2,
        LabeledRight = 1 << 3, // use either Label or LabelRight
        Action       = 1 << 4,
        Inverted     = 1 << 5,
        Fluid        = 1 << 6,
        Transparent  = 1 << 7
    }

    public static class InputDecorationsExtensions
    {
        public static string ToClass(this InputDecorations decorations)
        {
            var classes = new string[]
            {
                decorations.IconClass(),
                decorations.LabelClass(),
                "transparent".ToClassIf(decorations.HasFlag(Transparent)),
                "fluid".ToClassIf(decorations.HasFlag(Fluid)),
                "inverted".ToClassIf(decorations.HasFlag(Inverted)),
                "action".ToClassIf(decorations.HasFlag(Action))
            };

            return classes.ToClass();
        }

        private static string IconClass(this InputDecorations decorations)
        {
            if (decorations.HasFlag(IconRight))
            {
                return "right icon";
            }

            return decorations.HasFlag(Icon)
                ? "left icon"
                : string.Empty;
        }

        private static string LabelClass(this InputDecorations decorations)
        {
            if (decorations.HasFlag(LabeledRight))
            {
                return "right labeled";
            }

            return decorations.HasFlag(Labeled)
                ? "labeled"
                : string.Empty;
        }
    }
}
