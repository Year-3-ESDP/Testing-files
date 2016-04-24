using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_D_FangXiaoCheng_140368P
{
    public partial class QuickPay_Credit_Cards : Form
    {
        public QuickPay_Credit_Cards()
        {
            InitializeComponent();
        }
        //creating an object from class CreditCard
        CreditCard infoA;
        //creating an object from class CalculationOfCreditLimits
        CalculationOfCreditLimits calculationa;
        //creating an array
        CreditCard[] customers;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            float salarys, creditlimits;
            int contactnumber;
            //use to check if there is imformation in the array
            bool occupied = false;
            //validations
            if (cbTypeOfCard.Text != "  -- Please Select --"&& cbTypeOfCard.Text== "Corporate"||cbTypeOfCard.Text=="International"||cbTypeOfCard.Text=="Individual")
            {
                if (cbSalutation.Text != "  -- Please Select --" && cbSalutation.Text == "Mr. " || cbSalutation.Text == "Mrs. "
                    || cbSalutation.Text == "Ms. " || cbSalutation.Text == "Dr. " || cbSalutation.Text == "Madam ")
                {
                    if (tbName.Text != "")
                    {
                        if (float.TryParse(tbSalary.Text, out salarys) == true)
                        {
                            if (tbAddress.Text != "")
                            {
                                occupied = true;
                                //creating an object
                                calculationa = new CalculationOfCreditLimits();
                                //create an objec using constructor with parameter
                                creditlimits = calculationa.CalculateCreditLimit(cbTypeOfCard.Text, salarys);
                                infoA = new CreditCard(cbTypeOfCard.Text,cbSalutation.Text, tbName.Text, salarys, tbAddress.Text, occupied, creditlimits);
                                tbDisplay.Clear();
                                tbDisplay.Text += infoA.detailSalutation + " " + infoA.detailName + Environment.NewLine
                                    + "Salary: " + infoA.detailSalary.ToString("C") + Environment.NewLine
                                    + "Address: " + infoA.detailAddress + Environment.NewLine
                                    + "Credit Limit: " + infoA.detailCreditLimits.ToString("C") + Environment.NewLine
                                    + "Type of credit card: " + infoA.detailCardType + Environment.NewLine;
                                if (int.TryParse(tbContactNo.Text, out contactnumber) == true)
                                {
                                    occupied = true;
                                    creditlimits = calculationa.CalculateCreditLimit(cbTypeOfCard.Text, salarys);
                                    infoA = new CreditCard(cbTypeOfCard.Text,cbSalutation.Text, tbName.Text, salarys, contactnumber, tbAddress.Text, occupied, creditlimits);
                                    tbDisplay.Clear();
                                    tbDisplay.Text += infoA.detailSalutation + " " + infoA.detailName + Environment.NewLine
                                        + "Salary: " + infoA.detailSalary.ToString("C") + Environment.NewLine
                                        + "Address: " + infoA.detailAddress + Environment.NewLine
                                        + "Contact No: " + infoA.detailContactNo.ToString() + Environment.NewLine
                                        + "Credit Limit: " + infoA.detailCreditLimits.ToString("C") + Environment.NewLine+ "Type of credit card: " + infoA.detailCardType + Environment.NewLine;
                                    
                                }
                                //storing of information into the array using for loop
                                for (int i = 0; i < customers.Length; i++)
                                {
                                    if (customers[i].detailOccupation == false)
                                    {
                                        customers[i] = infoA;
                                        break;
                                    }
                                }
                                MessageBox.Show("Application succeed!");

                            }

                            else
                            {
                                MessageBox.Show("Please enter your address");
                                tbAddress.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter your salary");
                            tbSalary.Clear();
                            tbSalary.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter your name");
                        tbName.Clear();
                        tbName.Focus();
                    }
                }
                else { MessageBox.Show("Please select the salutation of your title");
                cbSalutation.Text = "  -- Please Select --";
                }
            }
            else { MessageBox.Show("Please select the type of credit card you wish to apply");
            cbTypeOfCard.Text = "  -- Please Select --";
            }
        }

        private void QuickPay_Credit_Cards_Load(object sender, EventArgs e)
        {
            //creating a new array
            customers = new CreditCard[3];
            // use null constructor to create an object and store it into array
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new CreditCard();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            //display informations in the array 
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].detailOccupation == true)
                {
                    tbDisplay.Text += customers[i].detailSalutation + " " + customers[i].detailName + Environment.NewLine
                                        + "Salary: " + customers[i].detailSalary.ToString("C") + Environment.NewLine
                                        + "Address: " + customers[i].detailAddress + Environment.NewLine
                                        + "Contact No: " + customers[i].detailContactNo.ToString() + Environment.NewLine
                                        + "Credit Limit: " + customers[i].detailCreditLimits.ToString("C") + Environment.NewLine
                                        + "Type of credit card: " + infoA.detailCardType + Environment.NewLine +Environment.NewLine;
                }


            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tbName.Focus();
            //removing the informations in a particular array by using the name
            if (tbName.Text != "")
            { bool check =false;
                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i].detailName == tbName.Text)
                    {
                        check=true;
                        customers[i].detailName = "";
                        customers[i].detailSalutation = "";
                        customers[i].detailAddress = "";
                        customers[i].detailContactNo = 0;
                        customers[i].detailOccupation = false;
                        customers[i].detailSalary = 0;
                        customers[i].detailCreditLimits = 0;
                        customers[i].detailCardType = "";
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("There is no name matched");
                }
                if (check ==true)
                {
                    MessageBox.Show("The record has been successfully removed");
                }
            }
            else { MessageBox.Show("Please enter the name you want to remove"); }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//clear textbox of display data
            tbDisplay.Clear();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            //clear input
            cbTypeOfCard.Text = "  -- Please Select --";
            cbSalutation.Text = "  -- Please Select --";
            tbName.Clear();
            tbSalary.Clear();
            tbContactNo.Clear();
            tbAddress.Clear();
            tbDisplay.Clear();
        }

        

    }
}
