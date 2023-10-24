namespace projekt01UI_E03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(567, 61);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(25, 165);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(567, 273);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 2;
            label1.Text = "Tekst wejściowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("NSimSun", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 135);
            label2.Name = "label2";
            label2.Size = new Size(177, 27);
            label2.TabIndex = 3;
            label2.Text = "Statystyka:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(598, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(598, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(598, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(598, 345);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(598, 374);
            button1.Name = "button1";
            button1.Size = new Size(190, 64);
            button1.TabIndex = 8;
            button1.Text = "Przeprowadź analizę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 36);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 9;
            label3.Text = "Liczba wszystkich znaków:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 98);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 10;
            label4.Text = "Liczba unikatowych znaków:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 164);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Entropia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 327);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 12;
            label6.Text = "Czas wykonania:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private OpenFileDialog openFileDialog1;
    }
}