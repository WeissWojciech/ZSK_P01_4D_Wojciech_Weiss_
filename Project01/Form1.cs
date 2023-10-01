namespace Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrzeprowadzAnalize_Click(object sender, EventArgs e)
        {
            // Pobierz tekst z richTextBox
            string tekst = richTextBox1.Text;

            // Oblicz d³ugoœæ tekstu
            int dlugoscTekstu = tekst.Length;
            textBoxDlugoscTekstu.Text = dlugoscTekstu.ToString();

            // SprawdŸ, czy w tekœcie wystêpuj¹ litery
            bool wystepujaLitery = tekst.Any(char.IsLetter);
            textBoxWystepowanieLiter.Text = wystepujaLitery ? "TAK" : "NIE";

            // SprawdŸ, czy w tekœcie wystêpuj¹ cyfry
            bool wystepujaCyfry = tekst.Any(char.IsDigit);
            textBoxWystepowanieCyfr.Text = wystepujaCyfry ? "TAK" : "NIE";

            // SprawdŸ, czy w tekœcie wystêpuj¹ znaki specjalne
            bool wystepujaZnakiSpecjalne = tekst.Any(c => !char.IsLetterOrDigit(c));
            textBoxWystepowanieZnakowSpecjalnych.Text = wystepujaZnakiSpecjalne ? "TAK" : "NIE";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}