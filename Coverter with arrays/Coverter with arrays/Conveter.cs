using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coverter_with_arrays
{
    public partial class Conveter : Form
    {
        public double[] measurements = new double[10];

        public Conveter()
        {
            InitializeComponent();
            //Cm To Inch 
            measurements[0] = 0.3937;
            //metres to feet
            measurements[1] = 3.28084;
            //c to f
            measurements[2] = 32;
            //kilometre to miles
            measurements[3] = 0.621371;
        }

        //Global Variables and Constants
        double dbl_UofM, dbl_Convert;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_cm_i_Click(object sender, EventArgs e)
        {

            // validate user entry and convert to a double
            if (!double.TryParse(textBox1.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                textBox1.Clear();
                textBox1.Focus();
                richTextBox1.Clear();
            }
            else
            {
                dbl_Convert = dbl_UofM * measurements[0];
                richTextBox1.Text = dbl_Convert.ToString() + " inches";
            }
        }

        private void btn_m_f_Click(object sender, EventArgs e)
        {
            // validate user entry and convert to a double
            if (!double.TryParse(textBox2.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                textBox2.Clear();
                textBox2.Focus();
                richTextBox1.Clear();
            }
            else
            {
                dbl_Convert = dbl_UofM * measurements[1];
                richTextBox1.Text = dbl_Convert.ToString() + " Feet";
            }
        }

        private void btn_c_f_Click(object sender, EventArgs e)
        {
            // validate user entry and convert to a double
            if (!double.TryParse(textBox3.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                textBox3.Clear();
                textBox3.Focus();
                richTextBox1.Clear();
            }
            else
            {
                dbl_Convert = (((dbl_UofM *9)/5) + measurements[2]);
                richTextBox1.Text = dbl_Convert.ToString() + " Fahrenheit";
            }
        }

        private void btn_k_m_Click(object sender, EventArgs e)
        {
            // validate user entry and convert to a double
            if (!double.TryParse(textBox4.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                textBox4.Clear();
                textBox4.Focus();
                richTextBox1.Clear();
            }
            else
            {
                dbl_Convert = dbl_UofM * measurements[3];
                richTextBox1.Text = dbl_Convert.ToString() + " Miles";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
        }


        //Teach the user to not press random buttons, loops message "Hello"
        private void btn_hehe_Click(object sender, EventArgs e)
        {
            while (true)
            {
                MessageBox.Show("Hello", "Why", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
