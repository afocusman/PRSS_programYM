using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "3s1022")
            {
                ParentForm frm = new ParentForm();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码不正确！");
                textBox2.Text = "";
            }
        }              
    }
}
