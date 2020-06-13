namespace Perun.Presentation.Semantic.Core
{
    public class MessageData
    {
        public Severity Severity { get; set; } = Severity.None;

        public Size Size { get; set; } = Size.Default;

        public Color Color { get; set; } = Color.Default;

        public string Icon { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public bool CanClose { get; set; }

        public string[] Items { get; set; }
    }
}
