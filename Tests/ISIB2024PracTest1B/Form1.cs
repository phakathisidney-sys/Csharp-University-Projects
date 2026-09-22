using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISIB2024PracTest1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // enter your student number as a comment

        const double VATRATE = 0.1;
        const double TenPrice = 50;
        const double ThreePrice = 100;
        const double EightPrice = 150;


        private void btnProcess_Click(object sender, EventArgs e)
        {
            // declare the local variables 
            double dblMovieCost = 0;
            bool blnValidInput = true;
            int intNoTickets;

            //convert input into numeric
            intNoTickets = Convert.ToInt16(txtNoTickets.Text = "");
            



            // validate the input 
            if ( intNoTickets < 0)
            {
                blnValidInput = false;
                MessageBox.Show("Invalid number of tickets", "ERROR");
            }
            if (rad10h00.Checked && rad15h00.Checked && rad20h00.Checked != true)
            {
                blnValidInput = false;
                MessageBox.Show("Please select movie time", "ERROR");
            }
            if (radTarot.Checked == true && rad10h00.Checked == true)
            {
                blnValidInput = false;
                MessageBox.Show("Invalid movie choice at that time", "ERROR");
            }
            // continue processing if the input is valid 
            if (blnValidInput == true)
            {
                if (rad10h00.Checked == true)
                {
                    dblMovieCost = TenPrice * intNoTickets;
                }

                if (rad15h00.Checked == true)
                {
                    dblMovieCost = ThreePrice * intNoTickets;
                }

                if (rad20h00.Checked ==  true)
                {
                    dblMovieCost = EightPrice * intNoTickets;
                }

                dblMovieCost = dblMovieCost * VATRATE;
          //lMovieCost = dblMovieCost.ToString("C2");




            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the form and place focus at the number of tickets
            rad10Lives.Checked = false;
            radHitman.Checked = false;
            radTarot.Checked = false;
            rad10h00.Checked = false;
            rad15h00.Checked = false;
            rad20h00.Checked = false;
            txtNoTickets.Text = "";
            lblMovieCost.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
