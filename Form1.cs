﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Lab
{
    public partial class Form1 : Form

    {

        //Name : Sudhir /ID: N01324321
       //Variable Defined and value assigned globally
        public double result = 0;
        public double HamburgerPrice = 6.95 ;
        public double PizzaPrice = 5.95;
        public double SaladPrice = 4.95;
        public double AddOnItemPrice = 0.75;
        public double TaxPercent = 7.75;
        public double totaltax;
        public double OrderTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdobtnHamburger_CheckedChanged(object sender, EventArgs e)
        {
           // result = HamburgerPrice;
           //txtSubtotal.Text = result.ToString();
            
        }


        // For Window form exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdobtnPizza_CheckedChanged(object sender, EventArgs e)
        {
         //   result = PizzaPrice;
         //   txtSubtotal.Text = result.ToString();

        }

        private void rdobtnSalad_CheckedChanged(object sender, EventArgs e)
        {
         //   result = SaladPrice;
         //   txtSubtotal.Text = result.ToString();
        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {

            
            if (chkboxLettuce.Checked)
            {
                result += AddOnItemPrice;
            }
            if (chkboxKetchup.Checked) {
                result +=  AddOnItemPrice;
            }
            if (chkboxFrenchFries.Checked)
            {
                result += AddOnItemPrice;
            }
            if (rdobtnHamburger.Checked)
            {

                result +=  HamburgerPrice;
            }

            else if (rdobtnPizza.Checked)
            {
                result +=  PizzaPrice;

            }

            else if (rdobtnSalad.Checked)
            {
                result += SaladPrice;

            }

            if (cboBoxQuantity.SelectedItem != null)
            {
                int selectedvalue = int.Parse(cboBoxQuantity.SelectedItem.ToString());
              
              //for Loop using selected item through combobox.  
               for (int i = 0; i <selectedvalue; i++)
                {
                    if (selectedvalue == 1)
                    {
                        result = result * 1;
                    }
                   else if (selectedvalue == 2)
                    {
                        result = result * 2;
                    }

                    else
                        result = result * 3;
                    selectedvalue = 0;
                }
            }


            //Final calculations.
            txtSubtotal.Text = result.ToString("C");
            totaltax = (result * TaxPercent) / 100;
            txtTaxtotal.Text = totaltax.ToString("C");

            OrderTotal = totaltax + result;
            txtOrderTotal.Text = OrderTotal.ToString("C");
            result = 0;


            //textbox disabaled.
            txtOrderTotal.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTaxtotal.Enabled = false;


            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
          
        }

        private void cboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
