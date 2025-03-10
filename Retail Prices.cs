namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void retailpriceButton_Click(object sender, EventArgs e)
        {
            // variables created for our arguments that will pass in function 
            double wholesale;
            double markup;

            // validating our arguments 
            if (double.TryParse(wholesaleTextBox.Text, out wholesale) && double.TryParse(markupTextBox.Text, out markup))
            {
                double retailPrice;
                retailPrice = CalculateRetail(wholesale, markup);
                retailpriceTextBox.Text = retailPrice.ToString("C");
                
            }
            else
                MessageBox.Show("Please enter valid numbers", "invalid Input");
        }

        // created a function for the retail price
        private double CalculateRetail(double wholesale, double markup)
        {
            double markupPercent = markup / 100;
            double retailPrice;

            retailPrice = wholesale + (wholesale * markupPercent);
            return retailPrice;

        }
    }
}
