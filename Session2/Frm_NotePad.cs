using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class Frm_NotePad : Form
    {
        public Frm_NotePad()
        {
            InitializeComponent();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment= HorizontalAlignment.Left;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment= HorizontalAlignment.Right;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Paste();   
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        // ;lkasjdf ;lkjasdfl; kjas;lkdfj ;alskdjf 
        // 
        // alskdjf 
    }
}
