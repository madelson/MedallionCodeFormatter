using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    interface ISyntaxRule
    {
        SyntaxNode Process(SyntaxNode root);
    }
}
