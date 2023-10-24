using projekt01UI_E03.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Shared.Entities
{
    public class TextPrintingData
    {
        public string? AllSymbolCount { get; set; }

        public string? UniqueSymbolCount { get; set; }

        public string? Entropy { get; set; }

        public List<SymbolPrintingData>? SymbolStatistics { get; set; }
    }
}
