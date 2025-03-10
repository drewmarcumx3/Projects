using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class JoesAutomotive : Form
    {
        // variables being declared 
        private const double PARTS_TAX = 0.07;
        private const double OIL_CHANGE = 50.00;
        private const double LUBE_JOB = 40.00;
        private const double RADIATOR_FLUSH = 100.00;
        private const double TRANSMISSION_FLUSH = 120.00;
        private const double INSPECTION = 35.00;
        private const double REPLACE_MUFFLER = 150.00;
        private const double TIRE_ROTATION = 25.00;
        private double partsTax = 0.0;
        private double parts = 0.0;
        private double labor = 0.0;

        public JoesAutomotive()
        {
            InitializeComponent();
        }

        private double OilChangeCharges()
        {
            //formula for my returning method 
            double oilCharges = 50.0;

            if (cboxOilChange.Checked)
            {
                return oilCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double LubeCharges()
        {
            // formula that is returning a value from method 
            double lubeCharges = 40.0;

            if (cboxLubeJob.Checked)
            {
                return lubeCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double RadiatorFlushCharges()
        {
            // formula that is returning a value from method 
            double radiatorCharges = 100.00;

            if (cboxRadiatorFlush.Checked)
            {
                return radiatorCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double TransmissionFlushCharges()
        {
            // formula that is returning a value from method 
            double transmissionCharges = 120.0;

            if (cboxTransmissionFlush.Checked)
            {
                return transmissionCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double InspectionCharges()
        {
            // formula that is returning a value from method 
            double inspectionCharges = 35.0;

            if (cboxInspection.Checked)
            {
                return inspectionCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double MufflerCharges()
        {
            // formula that is returning a value from method 
            double mufflerCharges = 150.0;

            if (cboxReplaceMuffler.Checked)
            {
                return mufflerCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double TireRotationCharges()
        {
            // formula that is returning a value from method 
            double rotationCharges = 25.0;

            if (cboxTireRotation.Checked)
            {
                return rotationCharges;
            }
            else
            {
                return 0.0;
            }
        }

        private double PartsCharges()
        {
            // formula that is returning a value from method 
            double parts = 0.0;

            if (tboxParts.Text == "")
            {
                return parts;
            }
            else
            {
                parts = Convert.ToDouble(tboxParts.Text);
                return parts;
            }

        }

        private double LaborCharges()
        {
            double labor = 0.0;
            double rate = 75.0;

            if (tboxLabor.Text == "")
            {
                return labor;

            }
            else
            {
                labor = Convert.ToDouble(tboxLabor.Text);
                return labor * rate;
            }
        }

        private double TaxCharges()
        {
            // formula for my taxcharges value returning method 
            double tax = 0.0;
            double taxRate = 0.07;
            double parts = PartsCharges();

            if (parts > 0)
            {
                return parts * taxRate;
            }
            else
            {
                return 0.0;

            }

        }

        private double TotalCharges()
        {
            // code for my total charges value returning method 
            double total = 0.0;
            total += OilChangeCharges();
            total += LubeCharges();
            total += RadiatorFlushCharges();
            total += TransmissionFlushCharges();
            total += InspectionCharges();
            total += MufflerCharges();
            total += TireRotationCharges();
            total += PartsCharges();
            total += LaborCharges();
            total += TaxCharges();
            return total;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }


        private void joesautomotive_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            {
                //formula for the clear button to clear all of the users input
                cboxOilChange.Checked = false;
                cboxLubeJob.Checked = false;

                cboxRadiatorFlush.Checked = false;
                cboxTransmissionFlush.Checked = false;

                cboxInspection.Checked = false;
                cboxReplaceMuffler.Checked = false;
                cboxTireRotation.Checked = false;

                tboxParts.Text = "";
                tboxLabor.Text = "";

                lblOutServiceLabor.Text = "";
                lblOutParts.Text = "";
                lblOutTax.Text = "";
                lblOutTotalFees.Text = "";

                cboxOilChange.Focus();
            }

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double service = 0.0;
            double labor = LaborCharges();
            service += OilChangeCharges();
            service += LubeCharges();
            service += RadiatorFlushCharges();
            service += TransmissionFlushCharges();
            service += InspectionCharges();
            service += MufflerCharges();
            service += TireRotationCharges();
            service += labor;
            lblOutServiceLabor.Text = "$" + String.Format("{0:0.00}", service);
            double parts = PartsCharges();
            lblOutParts.Text = "$" + String.Format("{0:0.00}", parts);
            double tax = TaxCharges();
            lblOutTax.Text = "$" + String.Format("{0:0.00}", tax);
            double total = TotalCharges();
            lblOutTotalFees.Text = "$" + String.Format("{0:0.00}", total);
        }
    }
}
