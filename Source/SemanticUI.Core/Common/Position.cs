using System;

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
                case Position.Left:
                case Position.Right:
                case Position.Center:
                    return position.ToString().ToLower() + " aligned";
                default:
                    return string.Empty;
            }
        }

        public static string ToFloatedClass(this Position position)
        {
            switch (position)
            {
                case Position.Left:
                case Position.Right:
                    return position.ToString().ToLower() + " floated";
                default:
                    return string.Empty;
            }
        }

        public static string ToPositionClass(this Position position)
        {
            if (position.HasFlag(Position.Top))
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

            if (!ignoreCenter && position.HasFlag(Position.Center))
            {
                return "center";
            }

            return "right";
        }
    }
}
