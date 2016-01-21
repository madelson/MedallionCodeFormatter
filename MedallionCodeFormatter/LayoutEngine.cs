using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    class LayoutEngine
    {
        private readonly LayoutOptions options;

        public LayoutEngine(LayoutOptions options)
        {
            this.options = options;
        }

        public SyntaxNode PerformLayout(SyntaxNode node)
        {
            var annotated = MultiLineConstructAnnotator.Annotate(node);
            var collapsed = Collapser.Collapse(annotated);
            var uncollapsed = Uncollapser.Uncollapse(collapsed, this.options);

            return uncollapsed;
        }
    }
}
