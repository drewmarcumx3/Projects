using System.Diagnostics.Eventing.Reader;

namespace Hospital_Charges
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }

        // declare the field variables
        private int numDays, stayCharge;
        private decimal medCharge, surgCharge, labCharge, ptCharge, miscCharge, totalCharge;

        // create CalcstayCharge method
        private int CalcStayCharge(int num1)
        {
            return num1 * 350;
        }

        // create CalcMiscCharge method
        private decimal CalcMiscCharge(decimal num2, decimal num3, decimal num4, decimal num5)
        {
            return num2 + num3 + num4 + num5;
        }

        // create CalcTotal method
        private decimal CalcTotal(decimal num6, decimal num7)
        {
            return num6 + num7;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // get the users num of days
            if (int.TryParse(numDaysTextBox.Text, out numDays))
            {
                // call the calcstaycharge method 
                stayCharge = CalcStayCharge(numDays);

                //Display the stay charge in $
                staychargeTextBox.Text = stayCharge.ToString("c");

                // get the users number of miscellaneous charges
                if (decimal.TryParse(medsTextBox.Text, out medCharge) &&
                decimal.TryParse(surgicalTextBox.Text, out surgCharge) &&
                decimal.TryParse(labfeesTextBox.Text, out labCharge) &&
                decimal.TryParse(rehabTextBox.Text, out ptCharge))
                {
                    // call the CalcMiscCharge method
                    miscCharge = CalcMiscCharge(medCharge, surgCharge, labCharge, ptCharge);

                    // display the miscellaneous charges
                    miscTextBox.Text = miscCharge.ToString("c");

                    // verify that all text boxes are entered correctly
                    if (stayCharge >= 0 && medCharge >= 0 && surgCharge >= 0
                        && labCharge >= 0 && ptCharge >= 0)
                    {
                        // call the calctotal method
                        totalCharge = CalcTotal(stayCharge, miscCharge);

                        // display the total charge
                        totalchargeTextBox.Text = totalCharge.ToString("c");
                    }
                    else if (medCharge > 0 && stayCharge > 0 && surgCharge > 0)
                    {
                        // display error message
                        MessageBox.Show("You must enter only positive values");
                    }
                }
                else
                {
                    // display an error message 
                    MessageBox.Show("You must enter your charges as '8' " +
                        "or ' 88.88'.");
                }
            }
            else
            {
                //error message
                MessageBox.Show("You must enter your number of days as '8'.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear the form
            numDaysTextBox.Text = "";
            medsTextBox.Text = "";
            surgicalTextBox.Text = "";
            labfeesTextBox.Text = "";
            rehabTextBox.Text = "";
            totalchargeTextBox.Text = "";
            miscTextBox.Text = "";
            staychargeTextBox.Text = "";

            // reset the focus
            numDaysTextBox.Focus();
        }
    }
}
   
