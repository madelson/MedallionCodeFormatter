using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    class LayoutOptions
    {
        public static readonly LayoutOptions Default = new LayoutOptions(maxLineWidth: 120);

        public LayoutOptions(int maxLineWidth)
        {
            this.MaxLineWidth = maxLineWidth;
        }

        public int MaxLineWidth { get; }
    }
}
