namespace CalculatorMAUI;

public partial class MainPage : ContentPage
{
    int currentState = 1;
    string operatorMath;
    double num1, num2;

	public MainPage()
	{
		InitializeComponent();
        ClearPressed(this, null);
	}

	void ClearPressed(object sender, EventArgs e)
	{
        num1 = 0;
        num2 = 0;
        currentState = 1;
        LabelOutput.Text = "0";
	}

    void SquarePressed(object sender, EventArgs e)
    {
        if(num1 == 0)
        {
            return;
        }
        num1 = num1 * num1;
        LabelOutput.Text = num1.ToString();
    }

    void NumberPressed(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string btnPressed = button.Text;
        if(LabelOutput.Text == "0" || currentState < 0)
        {
            LabelOutput.Text = string.Empty;
            if(currentState < 0)
            {
                currentState *= -1;
            }
        }
        LabelOutput.Text += btnPressed;
        double number;
        if(double.TryParse(LabelOutput.Text, out number))
        {
            LabelOutput.Text = number.ToString("N0");
            if(currentState == 1)
            {
                num1 = number;
            }
            else
            {
                num2 = number;
            }
        }
    }

    void OperatorPressed(object sender, EventArgs e)
    {
        currentState = -2;
        Button button = (Button)sender;
        string btnPressed = button.Text;
        operatorMath = btnPressed;
    }

    void EqualsPressed(object sender, EventArgs e)
    {
        if(currentState == 2)
        {
            var result = Calculation.Calculate(num1, num2, operatorMath);
            LabelOutput.Text = result.ToString();
            num1 = result;
            currentState = -1;
        }
    }

}

