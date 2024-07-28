using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFGridRowNColumnFix
{
    public partial class Form1 : Form
    {
        const int N = 100;
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void btnGMinus_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            for (int i = 0; i <= N; i++)
            {
                s = s.Replace("Grid.Row=\"" + i + "\"", "Grid.Row=\"" + (i - 1) + "\"");
            }
            textBox1.Text = s;
        }

        private void btnGPlus_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            for (int i = N; i >= 0; i--)
            {
                s = s.Replace("Grid.Row=\"" + i + "\"", "Grid.Row=\"" + (i + 1) + "\"");
            }
            textBox1.Text = s;
        }

        private void btnCMinus_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            for (int i = 0; i <= N; i++)
            {
                s = s.Replace("Grid.Column=\"" + i + "\"", "Grid.Column=\"" + (i - 1) + "\"");
            }
            textBox1.Text = s;
        }

        private void btnCPlus_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            for (int i = N; i >= 0; i--)
            {
                s = s.Replace("Grid.Column=\"" + i + "\"", "Grid.Column=\"" + (i + 1) + "\"");
            }
            textBox1.Text = s;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }
    }
}
