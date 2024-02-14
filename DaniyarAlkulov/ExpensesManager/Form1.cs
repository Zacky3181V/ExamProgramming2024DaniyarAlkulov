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

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            var path = pathBox.Text;
            var content = File.ReadAllLines(path);
            for(var i = 1; i < content.Length; i++)
            {
                var line = content[i];
                var lineCont = line.Split('|');
                resultBox.Text += string.Join("\t", lineCont);
                resultBox.Text += $"{Environment.NewLine}";
            }
            
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            var path = pathBox.Text;
            var content = File.ReadAllLines(path);
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
