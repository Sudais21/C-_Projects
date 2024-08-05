using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;

            label3.Text = name;
            label4.Text = email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = "Male";
            }
            else if (radioButton2.Checked)
            {
                label5.Text = "Female";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked )
            {
                label6.Text = "Pencil";
              
            }
            if (checkBox2.Checked)
            {

                label7.Text = "Sharpner";
            }
            if (checkBox3.Checked)
            {
              
                label8.Text = "Geometry";
            }




        }
    }
}
