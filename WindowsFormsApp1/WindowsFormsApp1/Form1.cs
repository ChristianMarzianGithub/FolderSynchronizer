using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if(folderBrowserDialog1.SelectedPath != "")
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            folderBrowserDialog2.ShowDialog();
            if ((folderBrowserDialog1.SelectedPath != "") && (folderBrowserDialog2.SelectedPath != ""))
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgrammCalc pc = new ProgrammCalc(folderBrowserDialog1.SelectedPath, folderBrowserDialog2.SelectedPath);
            if ((folderBrowserDialog1.SelectedPath != "") && (folderBrowserDialog2.SelectedPath != "") && (folderBrowserDialog2.SelectedPath != folderBrowserDialog1.SelectedPath))
            {
                pc.synchronize();
            }
        }
    }
}
