using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxDisplay.Text += button.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {            
            //Button button = sender as Button;
            //textBoxDisplay.Text += button.Text;
            try
            {
                // Evaluate the expression in the text box
                var result = new DataTable().Compute(textBoxDisplay.Text, null);
                textBoxDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Handle invalid expressions by showing an error message and clearing the display
                MessageBox.Show("Invalid expression");
                textBoxDisplay.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Button button = sender as Button;
           // textBoxDisplay.Text += button.Text;
        }

        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }
    }
}
