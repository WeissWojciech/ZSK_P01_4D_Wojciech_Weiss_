namespace Projekt01UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz tekst z richTextBox
            string tekst = richTextBox1.Text;

            // Oblicz d�ugo�� tekstu
            int dlugoscTekstu = tekst.Length;
            textBox1.Text = dlugoscTekstu.ToString();

            // Sprawd�, czy w tek�cie wyst�puj� litery
            bool wystepujaLitery = tekst.Any(char.IsLetter);
            textBox2.Text = wystepujaLitery ? "TAK" : "NIE";

            // Sprawd�, czy w tek�cie wyst�puj� cyfry
            bool wystepujaCyfry = tekst.Any(char.IsDigit);
            textBox3.Text = wystepujaCyfry ? "TAK" : "NIE";

            // Sprawd�, czy w tek�cie wyst�puj� znaki specjalne
            bool wystepujaZnakiSpecjalne = tekst.Any(c => !char.IsLetterOrDigit(c));
            textBox4.Text = wystepujaZnakiSpecjalne ? "TAK" : "NIE";
        }
    }
}