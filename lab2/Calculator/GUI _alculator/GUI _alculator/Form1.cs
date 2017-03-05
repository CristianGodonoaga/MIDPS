using System;
using System.Windows.Forms;

namespace GUI__alculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        int numbers_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "0" || operation_pressed)
            {
                textBoxValue.Clear();
                labelOperatie.Text = "";
                operation_pressed = false;
            }
            if (numbers_count < 16)
            {
                numbers_count++;
                Button bottonValue = (Button)sender;
                textBoxValue.Text = textBoxValue.Text + bottonValue.Text;
            }
            //textBoxValue.Text = textBoxValue.Text + "1";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text != "0")
                textBoxValue.Text = "0";
            value = 0;
            numbers_count = 0;
            labelOperatie.Text = "";
            operation = "";
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(operation);
            Button buttonValue = (Button)sender;
            if (!operation_pressed)
            {
                switch (operation)
                {
                    case "+":
                        textBoxValue.Text = (value + Double.Parse(textBoxValue.Text)).ToString();
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
                    case "^":
                        textBoxValue.Text = Math.Pow(value, Double.Parse(textBoxValue.Text)).ToString();
                        break;
                    default:
                        break;
                }
                value = Double.Parse(textBoxValue.Text);
                labelOperatie.Text = buttonValue.Text;
            }
            switch (buttonValue.Text)
            {
                case "+/-":
                    textBoxValue.Text = ((Double.Parse(textBoxValue.Text) * (-1))).ToString();
                    value = Double.Parse(textBoxValue.Text);
                    labelOperatie.Text = "";
                    break;
                case "√":
                    textBoxValue.Text = Math.Sqrt(Double.Parse(textBoxValue.Text)).ToString();
                    labelOperatie.Text = buttonValue.Text;
                    break;
            }
            operation = buttonValue.Text;
            
            operation_pressed = true;//setam actiunea de operatie
            numbers_count = 0;
        }

        private void buttonEqal_Click(object sender, EventArgs e)
        {
            //operation_pressed = true;
            buttonOperations_Click(sender, e);
            labelOperatie.Text = "";
            operation_pressed = false;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if(!textBoxValue.Text.Contains(","))
            {
                textBoxValue.Text = textBoxValue.Text + ",";
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case ".":
                    point.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
