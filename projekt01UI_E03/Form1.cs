using projekt01UI_E03.Presenters;
using System.Windows.Forms;

namespace projekt01UI_E03
{
    public partial class Form1 : Form
    {

        TextAnalyzerDataPresenter textAnalyzerDataPresenter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox3, textBox4, richTextBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPath = Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = currentPath;
            openFileDialog1.Filter = "Pliki tekstowe|*.txt";

            var result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string fileText = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = fileText;
                textAnalyzerDataPresenter.PerformTextAnalysis(fileText);
            }
        }


    }
}