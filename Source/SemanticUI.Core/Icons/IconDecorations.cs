using System;
using System.Linq;

using static Sidea.SemanticUI.Core.IconDecorations;

namespace Sidea.SemanticUI.Core
{
    public enum IconDecorations
    {
        NoDecor  = 0,
        Link     = 1 << 0,
        Inverted = 1 << 1,
        Disabled = 1 << 2,
        Loading  = 1 << 3,
        Fitted   = 1 << 4,
        Flipped  = 1 << 5,
        Rotated  = 1 << 6,
        Circular = 1 << 7,
        Bordered = 1 << 8
    }

    public static class IconDecorationsExtensions
    {
        private static readonly IconDecorations[] allValues = Enum.GetValues(typeof(IconDecorations))
                .Cast<IconDecorations>()
                .ToArray();

        public static string ToClass(this IconDecorations decorations)
        {
            var classes = allValues
                .Select(v =>
                {
                    return decorations.HasFlag(v)
                        ? v.ValueToClass()
                        : string.Empty;
                });

            return classes.ToClass();
        }

        private static string ValueToClass(this IconDecorations value)
        {
            return value switch
            {
                NoDecor => string.Empty,
                _ => value.ToString().ToLower(),
            };
        }
    }
    
}
