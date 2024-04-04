using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string from = (string)FirstMon.SelectedItem;
            string to = (string)SecondMon.SelectedItem;
            webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from +"%D0%B2" + to);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
