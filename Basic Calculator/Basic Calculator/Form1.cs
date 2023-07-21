namespace Basic_Calculator
{
    public partial class BasicCalculator : Form
    {
        private double? FirstNumber;
        private string? Operation;

        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void LoadApp(object sender, EventArgs e)
        {

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            inputField.Text += "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "1";
            else
                inputField.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "2";
            else
                inputField.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "3";
            else
                inputField.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "4";
            else
                inputField.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "5";
            else
                inputField.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "6";
            else
                inputField.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "7";
            else
                inputField.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "8";
            else
                inputField.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (inputField.Text == "0" && inputField.Text != null)
                inputField.Text = "9";
            else
                inputField.Text += "9";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            Operation = "+";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            Operation = "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            Operation = "*";
        }

        private void dividedByButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            Operation = "/";
        }

        private void xSquareButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputField.Text);
            inputField.Text = "0";
            Operation = "X^2";

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(inputField.Text);

            if (Operation == "+")
            {
                Result = ((double)(FirstNumber + SecondNumber));
                inputField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = ((double)(FirstNumber - SecondNumber));
                inputField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (double)(FirstNumber * SecondNumber);
                inputField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    inputField.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = ((double)(FirstNumber / SecondNumber));
                    inputField.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if(Operation == "X^2")
            {
                Result = (double)(FirstNumber * FirstNumber);
                inputField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation == "1/X")
            {
                Result = (1 / SecondNumber);
                inputField.Text = Convert.ToString(Result);
            }
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            bool isTrue = true;
            if (isTrue.ToString() == Operation)
            {

            }
            else if (inputField.Text.Length > 0)
            {
                inputField.Text = inputField.Text.Remove(inputField.Text.Length - 1);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputField.Text = "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            inputField.Text += ".";
        }

        private void userInputField(object sender, EventArgs e)
        {

        }

    }
}