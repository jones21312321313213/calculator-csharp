using System.Linq.Expressions;

namespace CalculatorC_
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        bool isResDisplayed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show(text);
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void number1Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number2Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number3Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number4Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number5Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number6Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number7Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number8Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number9Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void number0Btn(object sender, EventArgs e)
        {
            if (isResDisplayed)
            {
                currentInput = "";
                textBox1.Text = "";
                isResDisplayed = false;
            }
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void AddBtn(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            currentInput += button.Text;
            textBox1.Text = currentInput;
            currentInput = "";
            operationPending = true;
        }

        private void DivideBtn(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            currentInput += button.Text;
            textBox1.Text = currentInput;
            currentInput = "";
            operationPending = true;
        }

        private void minusBtn(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            currentInput += button.Text;
            textBox1.Text = currentInput;
            currentInput = "";
            operationPending = true;
        }

        private void multiplyBtn(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            currentInput += button.Text;
            textBox1.Text = currentInput;
            currentInput = "";
            operationPending = true;
        }

        private void equalBtn(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void clearBtn(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void squareBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                double number = double.Parse(currentInput);
                result = number * number;
                textBox1.Text = result.ToString();
                operationPending = false;
                currentInput = result.ToString();
            }
            else
            {
                textBox1.Text = "Please enter a number";
            }
        }

        private void oneHalfBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                double number = double.Parse(currentInput);

                if (number != 0)
                {
                    result = 1 / number;
                    textBox1.Text = result.ToString();
                    currentInput = result.ToString();
                    operationPending = false;
                }
                else
                {
                    textBox1.Text = "Error";
                }
            }
            else
            {
                textBox1.Text = "Please enter a number";
            }
        }


        private void sqrtBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                double number = double.Parse(currentInput);

                if (number >= 0)
                {
                    result = Math.Sqrt(number); 
                    textBox1.Text = result.ToString();
                    currentInput = result.ToString();
                    operationPending = false;
                }
                else
                {
                    textBox1.Text = "Error"; 
                }
            }
            else
            {
                textBox1.Text = "Please enter a number";
            }
        }

        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                }

                textBox1.Text = result.ToString();
                currentInput = result.ToString();
                operationPending = false;
                isResDisplayed = true;
            }
        }

    }
}
