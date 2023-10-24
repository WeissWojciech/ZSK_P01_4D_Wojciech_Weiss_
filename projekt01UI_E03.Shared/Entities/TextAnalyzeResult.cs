using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Shared.Entities
{
    public class TextAnalyzeResult
    {
        public int TextLength { get; set; }

        public bool ContainsLetters { get; set; }

        public bool ContainsDigits { get; set; }

        public bool ContainsSpecial { get; set; }
    }
}
