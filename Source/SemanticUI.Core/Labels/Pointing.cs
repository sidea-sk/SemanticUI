namespace Sidea.SemanticUI.Core
{
    public enum Pointing
    {
        NoPointing,
        UpPointing,
        LeftPointing,
        RightPointing,
        BellowPointing
    }

    public static class PointingExtensions
    {
        public static string ToClass(this Pointing pointing)
        {
            return pointing switch
            {
                Pointing.UpPointing => "pointing",
                Pointing.LeftPointing => "left poingin",
                Pointing.RightPointing => "right pointing",
                Pointing.BellowPointing => "pointing bellow",
                _ => string.Empty
            };
        }
    }
}
