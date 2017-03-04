using System;
using System.Windows.Forms;

namespace GUI__alculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "0" || operation_pressed)
                textBoxValue.Clear();
            Button bottonValue = (Button)sender;
            textBoxValue.Text = textBoxValue.Text + bottonValue.Text;
            //textBoxValue.Text = textBoxValue.Text + "1";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text != "0")
                textBoxValue.Text = "0";
            value = 0;
            labelOperatie.Text = "";
        }

        private void button_Operation(object sender, EventArgs e) //operatiile
        {
            if (!operation_pressed)//daca avem operatii multiple calc. pasul precedent
                switch (operation)
                {
                    case "+":
                        textBoxValue.Text = (value + Double.Parse(textBoxValue.Text)).ToString();
                        value = Double.Parse(textBoxValue.Text);
                        break;
                    case "-":
                        textBoxValue.Text = (value - Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    case "*":
                        textBoxValue.Text = (value * Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    case "/":
                        textBoxValue.Text = (value / Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    case "p":
                        textBoxValue.Text = (value + Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    case "sqrt":
                        textBoxValue.Text = (value + Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    case "+/-":
                        textBoxValue.Text = (value + Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    default:
                        break;
                }
            Button buttonValue = (Button)sender;
            operation = buttonValue.Text;
            labelOperatie.Text = buttonValue.Text;
            //value = Double.Parse(textBoxValue.Text);//stocam valoarea din textBox->value
            operation_pressed = true;//setam actiunea de operatie
        }

        private void button_Eqal(object sender, EventArgs e)
        {
            button_Operation(sender, e);
            labelOperatie.Text = "";
            operation_pressed = false;
        }
    }
}
