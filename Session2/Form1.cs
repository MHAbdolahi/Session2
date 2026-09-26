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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxBooks.Items.Clear(); 

            switch (comboBox1.SelectedItem.ToString())
            {
                case "هنری":
                    break;
                case "ورزشی":
                    break;
                case "سیاسی":
                    break;
                case "برنامه نویسی":
                    listBoxBooks.Items.Add("آموزش C#");
                    listBoxBooks.Items.Add("آموزش C++");
                    break;
                case "بانک اطلاعاتی":
                    listBoxBooks.Items.Add("آموزش SQL Server محمدحسین عبدالهی");
                    break; 
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // از مقصد شروع می کنیم 
            listBoxSelectedBook.Items.Add(listBoxBooks.SelectedItem.ToString());
        }
    }
}
