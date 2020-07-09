using static Sidea.SemanticUI.Core.ButtonState;

namespace Sidea.SemanticUI.Core
{
    public enum  ButtonState
    {
        Enabled,
        Active,
        Disabled,
        Loading
    }

    public static class ButtonStateExtensions
    {
        public static string ToClass(this ButtonState state)
        {
            return state == Enabled
                ? string.Empty
                : state.ToString().ToLower();
        }
    }
}
