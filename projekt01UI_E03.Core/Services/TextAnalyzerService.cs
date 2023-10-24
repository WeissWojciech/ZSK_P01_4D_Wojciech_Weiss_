using projekt01UI_E03.Shared.Entities;
using projekt01UI_E03.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01UI_E03.Core.Services
{
    public class TextAnalyzerService:ITextAnalyzerService
    {
        public TextAnalyzerService() { }
        public TextAnalyzeResult PerformAnalysis(string text)
        {
            TextAnalyzeResult result = new TextAnalyzeResult();

            //obliczenie długości tekstu
            int dlugoscTekstu = text.Length;
            result.TextLength = dlugoscTekstu;

            bool wystepujaLitery = false;
            bool wystepujaCyfry = false;
            bool wystepujaZnakiSpecjalne = false;

            if (text.Any(char.IsLetter))
            {
                wystepujaLitery |= true;
            }
            if (text.Any(char.IsDigit))
            {
                wystepujaCyfry |= true;
            }
            if (text.Any(c => !char.IsLetterOrDigit(c)))
            {
                wystepujaZnakiSpecjalne |= true;
            }

            result.ContainsLetters = wystepujaCyfry;
            
            result.ContainsDigits = wystepujaCyfry;
            
            result.ContainsSpecial = wystepujaZnakiSpecjalne;

            return result;
        }
    }
}
