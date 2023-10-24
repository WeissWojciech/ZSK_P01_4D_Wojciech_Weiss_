using projekt01UI_E03.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Shared.Entities
{
    public class TextStatisticsData
    {
        public int AllSymbolCount { get; set; }

        public int UniqueSymbolCount { get; set; }

        public double Entropy { get; set; }

        public List<SymbolStatisticsData>? SymbolStatistics { get; set; }
    }
}
