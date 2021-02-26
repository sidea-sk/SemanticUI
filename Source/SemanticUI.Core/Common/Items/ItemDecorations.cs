using System;
using System.Linq;
using static Sidea.SemanticUI.Core.ItemDecorations;

namespace Sidea.SemanticUI.Core
{

    [Flags]
    public enum ItemDecorations
    {
        None = 0,
        SimpleDropdown,
    }

    public static class ItemDecorationsExtensions
    {
        private static readonly ItemDecorations[] _allValues = System.Enum.GetValues(typeof(ItemDecorations))
                .Cast<ItemDecorations>()
                .ToArray();


        public static string ToClass(this ItemDecorations decorations)
        {
            var classes = _allValues
                .Select(v =>
                {
                    return decorations.HasFlag(v)
                        ? v.ValueToClass()
                        : string.Empty;
                });

            return classes.ToClass();
        }

        private static string ValueToClass(this ItemDecorations value)
        {
            return value switch
            {
                None => string.Empty,
                SimpleDropdown => "simple dropdown",
                _ => value.ToString().ToLower(),
            };
        }
    }
}
