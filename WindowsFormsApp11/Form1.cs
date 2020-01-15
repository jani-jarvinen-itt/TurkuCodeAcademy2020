using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int summa = a + b;
            MessageBox.Show("Summa on: " + summa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nimi = nimiTextBox.Text;
            string email = sähköpostiTextBox.Text.ToLower();

            string data = $"{nimi}\r\n{email}\r\n";
            File.WriteAllText(@"C:\Temp\Data.txt", data);
        }
    }
}
