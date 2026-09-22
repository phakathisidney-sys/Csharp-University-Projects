using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample1
{
    public partial class ClassEg1 : Form
    {
        public ClassEg1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblMessage1.Text = "Welcome to So Yum! " + txtName.Text;
            lblMessage2.Text = "You are assigned Table " + txtTableNo.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtTableNo.Text = "";
            lblMessage1.Text = "";
            lblMessage2.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMessage1_Click(object sender, EventArgs e)
        {
            lblMessage1.Text = "XXXXX";
        }

        private void lblMessage2_Click(object sender, EventArgs e)
        {
            lblMessage2.Text = "XXXXX";
        }
    }
}
