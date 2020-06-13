namespace Sidea.SemanticUI.Core.Tooltips
{
    public class Tooltip
    {
        public string Content { get; set; }

        public Position Position { get; set; } = Position.TopRight;

        public bool InvertedTooltip { get; set; }
    }
}
