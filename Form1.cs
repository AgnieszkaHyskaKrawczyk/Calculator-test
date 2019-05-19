using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_test
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            int number1;
            number1 = Convert.ToInt32(textNumber1.Text);

            int number2;
            number2 = Convert.ToInt32(textNumber2.Text);

            int result;
            result = number1 + number2;
            textResult.Text = Convert.ToString(result);

            //textResult.Text = textNumber1.Text + textNumber2.Text;
        }

        private void TextResult_TextChanged(object sender, EventArgs e)
        {

        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
