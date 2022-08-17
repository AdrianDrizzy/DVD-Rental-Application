using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Form_MLLAD007
{
    public partial class Form1 : Form
    {
        decimal DVDPrice;

        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            
            decimal TaxPercentage = 0;
            decimal Taxes;
            decimal Amountdue;
            var Name = Convert.ToString(txtBoxCustomerName.Text);
            try
            {
                //if (DVDPrice <= 0 && DVDPrice >= 100)
                //{
                //    MessageBox.Show("The DVD Price should be between 1 to 100.", "Entry Error ");
                //}


                if (radiobtnAction.Checked || radiobtnChildren.Checked || radiobtnAdventure.Checked || radiobtnComedy.Checked)
                {

                    DVDPrice  = Convert.ToDecimal(txtBoxDVDPrice.Text);


                    if (radiobtnChildren.Checked)
                    {
                        TaxPercentage = .05m;
                        Amountdue = (DVDPrice + (TaxPercentage * DVDPrice));
                        Taxes = (TaxPercentage * DVDPrice);
                        txtBoxTaxes.Text = Taxes.ToString();
                        txtBoxAmountDue.Text = Amountdue.ToString("c");

                    }


                    else if (radiobtnComedy.Checked)
                    {
                        TaxPercentage = .07m;
                        Amountdue = (DVDPrice + (TaxPercentage * DVDPrice));
                        Taxes = (TaxPercentage * DVDPrice);
                        txtBoxTaxes.Text = Taxes.ToString();
                        txtBoxAmountDue.Text = Amountdue.ToString("c");
                    }


                    else if (radiobtnAction.Checked || radiobtnAdventure.Checked)
                    {
                        TaxPercentage = .10m;
                        Amountdue = (DVDPrice + (TaxPercentage * DVDPrice));
                        Taxes = (TaxPercentage * DVDPrice);
                        txtBoxTaxes.Text = Taxes.ToString();
                        txtBoxAmountDue.Text = Amountdue.ToString("c");
                    }
                    grpBoxCustomerDetails.Visible = true;
                    grpBoxGenreType.Enabled = false;
                    txtBoxCustomerDetails.BackColor = Color.Lavender;
                    txtBoxCustomerDetails.Text = "Hi" + " " + Name + "\n" + " " + "Your total account accrued is " + "\n" + txtBoxAmountDue.Text;
                    txtBoxCustomerName.BackColor = Color.Lavender;


            }
                else
            {
                MessageBox.Show("Please check the genre type.", "Entry Error");
            }
        }
            catch(FormatException)
            {
                MessageBox.Show("The Genre type, Price and Customer Name are required fields.", "Entry Error");
            }

            try
            {

             decimal DVDPrice = Convert.ToDecimal(txtBoxDVDPrice.Text);
                if (DVDPrice <= 0)
             {
                    MessageBox.Show("DVDPrice must be greater than 0.", "Entry Error");
                    txtBoxDVDPrice.Focus();
                    txtBoxAmountDue.Enabled = false;
                    txtBoxCustomerName.Enabled = false;
                    txtBoxDVDPrice.Enabled = false;
                    txtBoxTaxes.Enabled = false;
                    txtBoxCustomerName.Focus();

             }
             else if (DVDPrice>= 100)
             {
                    txtBoxAmountDue.Enabled = false;
                    txtBoxCustomerDetails.Enabled = false;
                    txtBoxDVDPrice.Enabled = false;
                    txtBoxTaxes.Enabled = false; 
                    MessageBox.Show("DVDPrice must be less than 100.", "Entry Error");
                    txtBoxDVDPrice.Focus();
                    txtBoxCustomerName.Focus();
                    

             }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String clear = ("");
            txtBoxAmountDue.Text = clear;
            txtBoxCustomerName.Text = clear;
            txtBoxDVDPrice.Text = clear;
            txtBoxTaxes.Text = clear;
            txtBoxCustomerDetails.Text = clear;
            txtBoxCustomerName.Focus();


            radiobtnChildren.Checked = false;
            radiobtnAction.Checked = false;
            radiobtnAdventure.Checked = false;
            radiobtnComedy.Checked = false;
        }

        private void txtBoxCustomerName_TextChanged(object sender, EventArgs e)
        {
            string customerName = Convert.ToString(Name);
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void grpBoxCustomerDetails_Enter(object sender, EventArgs e)
        {
            grpBoxCustomerDetails.Visible = false;
        }

        private void txtBoxDVDPrice_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
