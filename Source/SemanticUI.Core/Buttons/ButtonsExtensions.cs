namespace Perun.Presentation.Semantic.Core.Buttons
{
    public static class ButtonsExtensions
    {
        public static string ToAttribute(this ButtonType buttonType)
        {
            return buttonType.ToString().ToLower();
        }
    }
}
