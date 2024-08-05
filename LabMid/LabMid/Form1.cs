using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace LabMid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
            
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Pakistan"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Swabi");
                comboBox2.Items.Add("Islamabad");
                comboBox2.Items.Add("Faisalabad");
            }
            if (comboBox1.SelectedItem.Equals("America"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Newyork");
                comboBox2.Items.Add("los Angeles");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor= color.Color;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }
        private void button1_Click(object sender, EventArgs e)

        {
            Form2 frm = new Form2(this);
            frm.Show();

            frm.listView1.Items.Add(textBox1.Text);
            frm.listView1.Items.Add(textBox2.Text);
            frm.listView1.Items.Add(textBox3.Text);

            

            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                frm.listView2.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                frm.listView2.Items.Add(radioButton2.Text);
            }
            if (checkBox1.Checked)
            {
                frm.listView3.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                frm.listView3.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                frm.listView3.Items.Add(checkBox3.Text);
            }
            if (comboBox1.SelectedItem.Equals( "Pakistan"))
            {
                frm.listView4.Items.Add(comboBox1.Text);
                frm.listView4.Items.Add(comboBox2.Text);
               
            }
            if (comboBox1.SelectedItem.Equals("America"))
            {
                frm.listView4.Items.Add(comboBox1.Text);
                frm.listView4.Items.Add(comboBox2.Text);
            }
            frm.listView5.Items.Add(dateTimePicker1.Text);
           
            frm.pictureBox2.Image= pictureBox1.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}
