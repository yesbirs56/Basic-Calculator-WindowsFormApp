using System;
using System.Windows.Forms;

namespace DemoApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);
            lblResult.Text = num1 - num2 + "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);
            lblResult.Text = num1 + num2 + "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);
            lblResult.Text = num1 * num2 + "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);
            if (num2 == 0)
            {
                lblResult.Text = "Inf";
                return;
            }
            lblResult.Text = num1 / num2 + "";
        }
        private string oldValue1 = "";
        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            string num = txtNumber1.Text;

            bool isValidInt = Int32.TryParse(num, out int number1);
            if (txtNumber1.Text == "")
            {
                oldValue1 = num;
            }
            else if (!isValidInt)
            {
                txtNumber1.Text = oldValue1;
            }
            else
            {
                oldValue1 = txtNumber1.Text;
            }
        }

        private string oldValue2 = "";

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            string num = txtNumber2.Text;

            bool isValidInt = Int32.TryParse(num, out int number2);
            if (txtNumber2.Text == "")
            {
                oldValue2 = num;
            }
            else if ( !isValidInt)
            {
                txtNumber2.Text = oldValue2;
            }
            else
            {
                oldValue2 = txtNumber2.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}