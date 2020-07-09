﻿namespace Sidea.SemanticUI.Core
{
    public static class CommonExtensions
    {
        public static string ToClass(this Size size)
        {
            return size == Size.Undefined
                ? string.Empty
                : size.ToString().ToLower();
        }

        public static string ToClass(this Color color)
        {
            return color == Color.NoColor
                ? string.Empty
                : color.ToString().ToLower();
        }

        public static string ToClass(this Severity severity)
        {
            return severity == Severity.NoSeverity
                ? string.Empty
                : severity.ToString().ToLower();
        }
    }
}
