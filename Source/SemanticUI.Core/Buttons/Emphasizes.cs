namespace Sidea.SemanticUI.Core
{
    public enum Emphasizes
    {
        NoEmphasizes,
        Secondary,
        Primary,
        Positive,
        Negative
    }

    public static class EmphasizesExtensions
    {
        public static string ToClass(this Emphasizes emphasizes)
        {
            return emphasizes == Emphasizes.NoEmphasizes
                ? string.Empty
                : emphasizes.ToString().ToLower();
        }
    }
}
