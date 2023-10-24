using projekt01UI_E03.Core.Services;
using projekt01UI_E03.Shared.Entities;
using projekt01UI_E03.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Presenters
{
    public class TextAnalyzerDataPresenter
    {
        private TextBox _tb_AllSymbols;
        private TextBox _tb_UniqueItems;
        private TextBox _tb_Entropy;
        private TextBox _tb_Time;
        private RichTextBox _rtb_Statistics;
        private ITextStatisticsService _myTextService;

        public TextAnalyzerDataPresenter(TextBox tb_AllSymbols, TextBox tb_UniqueItems, TextBox tb_Entropy,
            TextBox tb_Time, RichTextBox rtb_Statistics)
        {

            _tb_AllSymbols = tb_AllSymbols;
            _tb_UniqueItems = tb_UniqueItems;
            _tb_Entropy = tb_Entropy;
            _tb_Time = tb_Time;
            _rtb_Statistics = rtb_Statistics;
            _myTextService = new TextStatisticsSevice();
        }

        public void PerformTextAnalysis(string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            TextStatisticsData textStatisticsData = _myTextService.CountStatistics(text);
            sw.Stop();
            TextPrintingData textPrintingData = _myTextService.FillPrintingData(textStatisticsData);

            _tb_AllSymbols.Text = textPrintingData.AllSymbolCount;
            _tb_UniqueItems.Text = textPrintingData.UniqueSymbolCount;
            _tb_Entropy.Text = textPrintingData.Entropy;
            _tb_Time.Text = sw.Elapsed.ToString();
            StringBuilder sb = new StringBuilder();
            string mask = "{0}|{1}|{2}|{3}|{4}|{5}";
            int colWidth = 25;
            sb.AppendLine(string.Format(mask,
                    "Zapis binarny".PadRight(colWidth, ' '),
                    "Zapis dziesiętny".PadRight(colWidth, ' '),
                    "Symbol".PadRight(colWidth, ' '),
                    "Częstość".PadRight(colWidth, ' '),
                    "Prawdopodobieństwo".PadRight(colWidth, ' '),
                    "Ilość informacji".PadRight(colWidth, ' ')));
            for (int i = 0; i < textPrintingData?.SymbolStatistics?.Count; i++)
            {
                sb.AppendLine(string.Format(mask,
                    textPrintingData.SymbolStatistics[i].BinaryNotation?.PadRight(colWidth, ' '),
                    textPrintingData.SymbolStatistics[i].DecimalNotation?.ToString().PadRight(colWidth, ' '),
                    textPrintingData.SymbolStatistics[i].Symbol?.PadRight(colWidth, ' '),
                    textPrintingData.SymbolStatistics[i].Frequency?.ToString().PadRight(colWidth, ' '),
                    textPrintingData.SymbolStatistics[i].Probability?.ToString().PadRight(colWidth, ' '),
                    textPrintingData.SymbolStatistics[i].InformationQuantity?.ToString().PadRight(colWidth, ' ')));
            }
            _rtb_Statistics.Text = sb.ToString();
        }
    }
}
