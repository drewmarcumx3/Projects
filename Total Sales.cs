using System.Windows.Markup;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7; //Array size 
                int index = 0;      // use to step through the array
                decimal total = 0m; // accumulator variable for sales totals

                // array to hold the sales amounts
                var sales = new decimal[SIZE];

                // open the sales.txt file
                StreamReader inputFile = File.OpenText("Sales.txt");

                //read the contrents of the file into the array
                while (!inputFile.EndOfStream && index < sales.Length)
                {
                    sales[index] = decimal.Parse(inputFile.ReadLine());
                    index++;
                }

                // close the file
                inputFile.Close();

                // display the array elements in the ListBox
                foreach (decimal value in sales)
                {
                    salesListBox.Items.Add(value.ToString("c"));
                }

                // calculate the total of the sales array 
                foreach (decimal value in sales)
                {
                    total += value;
                }

                // display the total
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
