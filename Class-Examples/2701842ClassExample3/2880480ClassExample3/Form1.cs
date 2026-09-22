using System;
using System.Windows.Forms;

namespace _2701842ClassExample3
{
    public partial class ClassEg3 : Form
    {
        public ClassEg3()
        {
            InitializeComponent();
        }
        // declare the constants
        const double VATRate = 0.15;
        const double CashDiscRate = 0.02;
        const double VIPDiscRate = 0.05;
        const int SMTHIPrice = 50;
        const int CAPPOPrice = 45;
        const int RATLLPrice = 100;
        const int COAUVPrice = 125;
        const int CHATBPrice = 150;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // declare the variables
            int intQty;
            double dblAmtOwing;
            double dblCashDisc = 0;
            double dblVIPDisc = 0;
            double dblTotDiscAmt;
            double dblVATAmt;

            // convert the input into numerics
            intQty = Convert.ToInt32(txtQty.Text);

            // perform the calculations
            if (txtItemCode.Text == "SMTHI")
            { dblAmtOwing = intQty * SMTHIPrice; }
            else
                if (txtItemCode.Text == "CAPPO")
            { dblAmtOwing = intQty * CAPPOPrice; }
            else
                    if (txtItemCode.Text == "RATLL")
            { dblAmtOwing = intQty * RATLLPrice; }
            else
                        if (txtItemCode.Text == "COAUV")
            { dblAmtOwing = intQty * COAUVPrice; }
            else
            { dblAmtOwing = intQty * CHATBPrice; }

            if (radCash.Checked)
            {
                dblCashDisc = dblAmtOwing * CashDiscRate;
                dblAmtOwing = dblAmtOwing - dblCashDisc;
            }

            if (chkVIPcard.Checked)
            {
                dblVIPDisc = dblAmtOwing * VIPDiscRate;
                dblAmtOwing = dblAmtOwing - dblVIPDisc;
            }

            dblTotDiscAmt = dblCashDisc + dblVIPDisc;
            dblVATAmt = dblAmtOwing * VATRate;
            dblAmtOwing = dblAmtOwing + dblVATAmt;

            // convert the calculated values into text in the required format (currency with 2 decimals)
            lblAmtOwing.Text = dblAmtOwing.ToString("C2");
            lblVATAmt.Text = dblVATAmt.ToString("C2");
            lblTotDiscAmt.Text = dblTotDiscAmt.ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAmtOwing.Text = "0.00";
            lblVATAmt.Text = "0.00";
            lblTotDiscAmt.Text = "0.00";
            txtTableNo.Text = "";
            txtItemCode.Text = "";
            txtQty.Text = "";
            radCard.Checked = false;
            radCash.Checked = false;
            chkVIPcard.Checked = false;
        }
    }
}
