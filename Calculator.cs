namespace Calculator
{
    public partial class Calculator : Form
    {
        private double firstNumber;
        private double secondNumber;
        private string operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void ClickNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tbxDisplay.Text += button.Text;
        }

        private void ClickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(tbxDisplay.Text);
            operation = button.Text; // Spara operator (+, -, *, /)
            tbxDisplay.Clear();
        }

        private void ClickCalculate(object sender, EventArgs e)
        {
            secondNumber = double.Parse(tbxDisplay.Text);

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        MessageBox.Show("Omöjligt att dela med noll!");
                        return;
                    }
                    break;
            }

            tbxDisplay.Text = result.ToString();
        }

        private void ClickClear(object sender, EventArgs e)
        {
            tbxDisplay.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
        }
    }
}
