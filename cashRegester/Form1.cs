using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegester
{
    public partial class Form1 : Form
    {
        double buckethat = 12.00;
        double cargopants = 15.25;
        double graphictees = 10.50;

        int numOfhats = 0;
        int numOfpants = 0;
        int numOftees = 0;

        double subtotal = 0;
        double totalprice = 0;

        double taxrate = 0.13;
        double taxamount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfhats = Convert.ToInt32(hatsInput.Text);
                numOfpants = Convert.ToInt32(hatsInput.Text);
                numOftees = Convert.ToInt32(hatsInput.Text);

                subtotal = numOfhats * buckethat + numOfpants * cargopants + numOftees * graphictees;
                taxamount = taxrate;
                totalprice = subtotal * taxamount;

            }
            catch
            {

            }
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
