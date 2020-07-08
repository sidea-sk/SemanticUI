using System;
using System.Linq;

using static Sidea.SemanticUI.Core.TableParameters;

namespace Sidea.SemanticUI.Core
{
    [Flags]
    public enum TableParameters
    {
        DefaultProperties,
        Basic,
        VeryBasic,  // use either Basic or VeryBasic
        Celled,
        Collapsing,
        Compact,
        Definition,
        Fixed,
        Inverted,
        Padded,
        VeryPadded, // use either Padded or VeryPadded
        SingleLine,
        SelectableRow,
        Striped,
        Structured
    }

    public static class TableParametersExtensions
    {
        private static readonly TableParameters[] allValues = Enum.GetValues(typeof(TableParameters))
                .Cast<TableParameters>()
                .ToArray();

        public static string ToClass(this TableParameters properties)
        {
            var classes = allValues
                .Select(v => 
                {
                    return properties.HasFlag(v)
                        ? v.ValueToClass()
                        : string.Empty;
                });

            return classes.ToClass();
        }

        private static string ValueToClass(this TableParameters value)
        {
            return value switch
            {
                SingleLine => "single line",
                SelectableRow => "selectable",
                _ => value.ToString().ToLower(),
            };
        }
    }
}
