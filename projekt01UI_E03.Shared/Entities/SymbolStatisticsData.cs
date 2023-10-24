using projekt01UI_E03.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Shared.Entities
{
    public class SymbolStatisticsData
    {
        public char Symbol { get; set; }

        public int Frequency { get; set; }

        public double Probability { get; set; }

        public double InformationQuantity { get; set; }
    }
}
