using System;
using System.Linq;

using static Sidea.SemanticUI.Core.ListDecorations;

namespace Sidea.SemanticUI.Core
{
    [Flags]
    public enum ListDecorations
    {
        NoDecoration,
        Animated,
        Bulleted,
        Celled,
        Divided,
        Inverted,
        Link,
        Ordered,
        Relaxed,
        VeryRelaxed,
        Selection,
    }

    public static class ListDecorationsExtensions
    {
        private static readonly ListDecorations[] allValues = Enum.GetValues(typeof(ListDecorations))
                .Cast<ListDecorations>()
                .ToArray();

        public static string ToClass(this ListDecorations decorations)
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

        private static string ValueToClass(this ListDecorations value)
        {
            return value switch
            {
                NoDecoration => string.Empty,
                VeryRelaxed => "very relaxed",
                _ => value.ToString().ToLower(),
            };
        }
    }
}
