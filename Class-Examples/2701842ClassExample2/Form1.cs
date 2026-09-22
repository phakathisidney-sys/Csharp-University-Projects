using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2701842ClassExample2
{
    public partial class Form1 : Form
    {
        //declare constant
        const double VATRate = 0.15;
        const IntroPrice = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        //declare variables
        double dblTableNo;
        double dblItemCode;
        double dblQuantity;
        double dblAmountOwing;
        double dblVATAmount;

        //convert input into numeric
        dblTableNo = Convert.ToDouble(txtTableNo, Text);
        dblQty = Convert.ToDouble(txtQty.Text);




    }
}
