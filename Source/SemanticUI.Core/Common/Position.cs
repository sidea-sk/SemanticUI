using System;

namespace Perun.Presentation.Semantic.Core
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
}
