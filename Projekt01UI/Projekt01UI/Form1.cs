using Projekt01UI.Presenters;

namespace Projekt01UI
{
    public partial class Form1 : Form
    {
        private TextAnalyzerDataPresenter textAnalyzerDataPresenter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox3, textBox4, textBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //pobranie tekstu z reachTextBox
            string tekst = richTextBox1.Text;
            //obliczenie d�ugo�ci tekstu
            int dlugoscTekstu = tekst.Length;
            textBox1.Text = dlugoscTekstu.ToString();
            //sprawdzenie czy wyst�puj� w nim litery
            bool wystepujaLitery = tekst.Any(char.IsLetter);
            textBox2.Text = wystepujaLitery ? "TAK" : "NIE";
            //sprawdzenie czy wyst�puj� w nim cyfry
            bool wystepujaCyfry = tekst.Any(char.IsDigit);
            textBox3.Text = wystepujaCyfry ? "TAK" : "NIE";
            //sprawdzenie czy wyst�puj� w nim znaki specjalne
            bool wystepujaZnakiSpecjalne = tekst.Any(c => !char.IsLetterOrDigit(c));
            textBox4.Text = wystepujaZnakiSpecjalne ? "TAK" : "NIE"; */
            textAnalyzerDataPresenter.PerformTextAnalysis(text: richTextBox1.Text);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter.PerformTextAnalysis(richTextBox1.Text);
        }

    }
}