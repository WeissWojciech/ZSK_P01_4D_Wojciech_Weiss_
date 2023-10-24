using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Shared.Interfaces
{
    public interface ITextStatisticsService
    {
         TextStatisticsData CountStatistics(string text);
         TextPrintingData FillPrintingData(TextStatisticsData statistics);
    }
}
