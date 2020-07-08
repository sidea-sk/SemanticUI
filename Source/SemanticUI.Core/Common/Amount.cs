namespace Sidea.SemanticUI.Core
{
    public enum Amount
    {
        Undefined,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Eleven,
        Twelve,
        Thirteen,
        Fourteen,
        Fifteen,
        Sixteen
    }

    public static class AmountExtensions
    {
        public static string ToClass(this Amount count, string of)
        {
            return count == Amount.Undefined
                ? string.Empty
                : count.ToString().ToLower() + " " + of;
        }
    }
}
