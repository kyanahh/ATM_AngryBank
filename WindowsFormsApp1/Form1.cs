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
        public static int Balance = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            int Account = Convert.ToInt32(txtAccount.Text);
            int PIN = Convert.ToInt32(txtPin.Text);

            if(Account == 1234567890 && PIN == 1234)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Visible = false;
            }
            else
            {
                txtNot.Text = "Wrong Account No./PIN";
                Clear();
            }

        }

        public void Clear()
        {
            txtAccount.Clear();
            txtPin.Clear();
        }

        public void ClearAll()
        {
            txtAccount.Clear();
            txtPin.Clear();
            txtNot.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
