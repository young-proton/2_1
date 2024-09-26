using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int classAAmount = int.Parse(class_a_value.Text);
                int classBAmount = int.Parse(class_b_value.Text);
                int classCAmount = int.Parse(class_c_value.Text);

                int classAPrice = classAAmount * 15;
                int classBPrice = classBAmount * 12;
                int classCPrice = classCAmount * 9;
                int totalPrice = classAPrice + classBPrice + classCPrice;

                class_a_answer.Text = $"{classAPrice: 0.00}$";
                class_b_answer.Text = $"{classBPrice: 0.00}$";
                class_c_answer.Text = $"{classCPrice: 0.00}$";

                total_answer.Text = $"{totalPrice: 0.00}$";
            }
            catch 
            {
                MessageBox.Show("Please enter valid numbers for class amounts", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            class_a_answer.Text = "";
            class_b_answer.Text = "";
            class_c_answer.Text = "";
            total_answer.Text = "";

            class_a_value.Text = "";
            class_b_value.Text = "";
            class_c_value.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
