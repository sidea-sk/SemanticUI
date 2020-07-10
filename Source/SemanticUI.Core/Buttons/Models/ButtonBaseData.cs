namespace Sidea.SemanticUI.Core
{
    public abstract class ButtonBaseData
    {
        public Color Color { get; set; }

        public Size Size { get; set; }

        public ButtonDecoration Decoration { get; set; }

        public bool Fluid { get; set; } = false;
    }
}
