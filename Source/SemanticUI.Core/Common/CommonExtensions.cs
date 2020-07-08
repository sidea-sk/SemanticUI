using static Sidea.SemanticUI.Core.Position;

namespace Sidea.SemanticUI.Core
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

        public static string ToClass(this Emphasizes emphasizes)
        {
            return emphasizes == Emphasizes.NoEmphasizes
                ? string.Empty
                : emphasizes.ToString().ToLower();
        }

        public static string ToClass(this Orientation orientation, Orientation emptyIf = Orientation.Horizontal)
        {
            return orientation == emptyIf
                ? string.Empty
                : orientation.ToString().ToLower();
        }

        public static string ToClass(this Amount count, string of)
        {
            return count == Amount.Unlimited
                ? string.Empty
                : count.ToString().ToLower() + " " + of;
        }

        public static string ToAlignmentClass(this Position position)
        {
            switch (position)
            {
                case Left:
                case Right:
                    return position.ToString().ToLower() + " aligned";
                default:
                    return string.Empty;
            }
        }

        public static string ToFloatedClass(this Position position)
        {
            switch (position)
            {
                case Left:
                case Right:
                    return position.ToString().ToLower() + " floated";
                default:
                    return string.Empty;
            }
        }

        public static string ToPositionClass(this Position position)
        {
            if(position.HasFlag(Position.Top))
            {
                return $"top {position.HorizontalPosition(ignoreCenter: false)}";
            }

            if (position.HasFlag(Position.Center))
            {
                return $"{position.HorizontalPosition(ignoreCenter: true)} center";
            }

            if (position.HasFlag(Position.Bottom))
            {
                return $"bottom {position.HorizontalPosition(ignoreCenter: false)}";
            }

            return string.Empty;
        }

        private static string HorizontalPosition(this Position position, bool ignoreCenter = false)
        {
            if (position.HasFlag(Position.Left))
            {
                return "left";
            }

            if (position.HasFlag(Position.Right))
            {
                return "right";
            }

            if(!ignoreCenter && position.HasFlag(Position.Center))
            {
                return "center";
            }

            return "right";
        }
    }
}
