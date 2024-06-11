using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Small_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op;
        public int Number1, Number2;
        void ShowNumbersInScreen(Button btn)
        {
            tbShow.Text += btn.Text;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbShow.Text=string.Empty;
        }
        private void button_Click(object sender, EventArgs e)
        {
            ShowNumbersInScreen((Button)sender);
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            

            
      Number1 = int.Parse(tbShow.Text.ToString());
            op = "+";
            tbShow.Text = string.Empty;
        }
        private void btnSUB_Click(object sender, EventArgs e)
        {
            Number1 = int.Parse(tbShow.Text.ToString());
            tbShow.Text = string.Empty;
            op = "-";
        }
        private void btnMUL_Click(object sender, EventArgs e)
        {
            Number1 = int.Parse(tbShow.Text.ToString());
            tbShow.Text = string.Empty;
            op = "*";
        }
        private void btnEcol_Click(object sender, EventArgs e)
        {
            float rus;
            Number2 = int.Parse(tbShow.Text.ToString());
            tbShow.Text = string.Empty;
            if(op=="+")
            {
               rus= Number1 + Number2;
            }
            else if (op=="-")
            {
                rus = Number1- Number2;
            }
            else if (op=="*")
            {
                rus=Number1 * Number2;
            }
            else
            {
                rus = Number1 / Number2;
            }


            tbShow.Text = rus.ToString();
        }
        private void btnDIV_Click(object sender, EventArgs e)
        {
            Number1 = int.Parse(tbShow.Text.ToString());
            tbShow.Text = string.Empty;
            op = "/";
        }
    }
}
