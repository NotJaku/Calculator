namespace Calculator
{
    public partial class fMain : Form
    {
        string first, second;
        double num1, num2, score;
        char sign;
        bool isUsedDot;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            calcText.Enabled = false;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            sign = '+';
            charLabel.Text = "+";
            first = Convert.ToString(calcText.Text);
            calcText.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            sign = '-';
            charLabel.Text = "-";
            first = Convert.ToString(calcText.Text);
            calcText.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            sign = '/';
            charLabel.Text = "÷";
            first = Convert.ToString(calcText.Text);
            calcText.Clear();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            sign = '*';
            charLabel.Text = "*";
            first = Convert.ToString(calcText.Text);
            calcText.Clear();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            sign = '%';
            charLabel.Text = "%";
            first = Convert.ToString(calcText.Text);
            calcText.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            first = Convert.ToString(0);
            second = Convert.ToString(0);
            num1 = 0;
            num2 = 0;
            charLabel.Text = "";
            calcText.Clear();
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            first = Convert.ToString(calcText.Text);
            num1 = Convert.ToDouble(first);
            score = Math.Sqrt(num1);
            calcText.Text = Convert.ToString(score);
        }

        private void buttonCaret_Click(object sender, EventArgs e)
        {
            first = Convert.ToString(calcText.Text);
            num1 = Convert.ToDouble(first);
            score = num1 * num1;
            calcText.Text = Convert.ToString(score);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            isUsedDot = calcText.Text.Contains(',');

            if (isUsedDot)
            {

            }
            else
            {
                calcText.Text = calcText.Text + ",";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                second = Convert.ToString(calcText.Text);
                num1 = Convert.ToDouble(first);
                num2 = Convert.ToDouble(second);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }


            switch (sign)
            {
                case '+':
                    score = num1 + num2;
                    calcText.Text = Convert.ToString(score);
                    break;

                case '-':
                    score = num1 - num2;
                    calcText.Text = Convert.ToString(score);
                    break;

                case '/':
                    score = num1 / num2;
                    calcText.Text = Convert.ToString(score);
                    break;

                case '*':
                    score = num1 * num2;
                    calcText.Text = Convert.ToString(score);
                    break;

                case '%':
                    score = num1 % num2;
                    calcText.Text = Convert.ToString(score);
                    break;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            calcText.Text = calcText.Text + "0";
        }
    }
}