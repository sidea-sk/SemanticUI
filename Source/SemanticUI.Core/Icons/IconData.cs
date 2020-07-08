using System.Collections.Generic;

namespace Sidea.SemanticUI.Core
{
    public class IconData
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; } = Color.Default;

        public bool Link { get; set; }

        public string ToClass() => this.Classes().ToClass();

        private IEnumerable<string> Classes()
        {
            yield return this.Name;
            yield return this.Size.ToClass();
            yield return this.Color.ToClass();
            yield return "link".ToClassIf(this.Link);
        }
    }
}
