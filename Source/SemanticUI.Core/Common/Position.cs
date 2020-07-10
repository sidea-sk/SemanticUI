using System;

using static Sidea.SemanticUI.Core.Position;

namespace Sidea.SemanticUI.Core
{
    [Flags]
    public enum Position
    {
        Default = 0,
        Top = 1,
        Center = 2,
        Bottom = 4,
        Left = 8,
        Right = 16,

        TopLeft = Top | Left,
        TopCenter = Top | Center,
        TopRight = Top | Right,
        LeftCenter = Left | Center,
        RightCenter = Right | Center,
        BottomLeft = Bottom | Left,
        BottomCenter = Bottom | Center,
        BottomRight = Bottom | Right,
    }

    public static class PositionExtensions
    {
        public static string ToAlignmentClass(this Position position)
        {
            switch (position)
            {
                case Left:
                case Right:
                case Center:
                    return position.ToString().ToLower() + " aligned";
                default:
                    return string.Empty;
            }
        }

        public static string ToFloatedClass(this Position position)
        {
            switch (position)
            {
                case Right:
                    return position.ToString().ToLower() + " floated";
                default:
                    return string.Empty;
            }
        }

        public static string ToPositionClass(this Position position)
        {
            if (position.HasFlag(Top))
            {
                return $"top {position.HorizontalPosition(ignoreCenter: false)}";
            }

            if (position.HasFlag(Center))
            {
                return $"{position.HorizontalPosition(ignoreCenter: true)} center";
            }

            if (position.HasFlag(Bottom))
            {
                return $"bottom {position.HorizontalPosition(ignoreCenter: false)}";
            }

            return string.Empty;
        }

        public static string ToAttachedClass(this Position position)
        {
            var @class = string.Empty;
            if (position.HasFlag(Top))
            {
                @class += "top" + position.AttachedHorizontal();
            }
            else if (position.HasFlag(Bottom))
            {
                @class += "bottom" + position.AttachedHorizontal();
            }

            return @class;
        }

        public static string ToLabelClass(this Position position)
        {
            return position.HasFlag(Right)
                ? "right"
                : string.Empty;
        }

        private static string HorizontalPosition(this Position position, bool ignoreCenter = false)
        {
            if (position.HasFlag(Left))
            {
                return "left";
            }

            if (position.HasFlag(Right))
            {
                return "right";
            }

            if (!ignoreCenter && position.HasFlag(Center))
            {
                return "center";
            }

            return "right";
        }

        private static string AttachedHorizontal(this Position position)
        {
            if (position.HasFlag(Left))
            {
                return " left";
            }

            if (position.HasFlag(Right))
            {
                return " right";
            }

            return string.Empty;
        }
    }
}
