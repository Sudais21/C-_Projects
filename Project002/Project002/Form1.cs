using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project002
{
    public partial class Form1 : Form
    {

        public List<Point> lines = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the TextBox controls
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);

            // Add the line coordinates to the List
            lines.Add(new Point(x1, y1));
            lines.Add(new Point(x2, y2));

            // Draw all the lines on a new Bitmap
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 2);

            for (int i = 0; i < lines.Count; i += 2)
            {
                graphics.DrawLine(pen, lines[i], lines[i + 1]);
            }

            // Display the Bitmap in the PictureBox control
            pictureBox1.Image = bitmap;

            // Add the values to the RichTextBox control
            listBox1.Items.Add($"({x1},{y1}) - ({x2},{y2})\n");

            foreach (var item in listBox1.Items)
            {
                dataGridView1.Rows.Add(item.ToString());
                dataGridView1.Rows[0].Cells[1].Style.BackColor = Color.Black;
               
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = color.Color;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a line to update.", "Error");
                return;
            }

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);

            // Update the selected line's endpoints
            lines[selectedIndex * 2] = new Point(x1, y1);
            lines[selectedIndex * 2 + 1] = new Point(x2, y2);

            // Redraw all the lines on a new Bitmap
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 2);

            for (int i = 0; i < lines.Count; i += 2)
            {
                graphics.DrawLine(pen, lines[i], lines[i + 1]);
            }

            // Display the new Bitmap in the PictureBox
            pictureBox1.Image = bitmap;

            // Update the selected line's string representation in the ListBox
            listBox1.Items[selectedIndex] = $"({x1},{y1}) - ({x2},{y2})";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a line to remove.", "Error");
                return;
            }

            listBox1.Items.RemoveAt(selectedIndex);

            if (selectedIndex < listBox1.Items.Count)
            {
                listBox1.SetSelected(selectedIndex, true);
            }
            else if (listBox1.Items.Count > 0)
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
            }

            pictureBox1.Invalidate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get the endpoints of the last two line segments added to the list
            int last = lines.Count - 1;
            Point p1 = lines[last - 3];
            Point p2 = lines[last - 2];
            Point p3 = lines[last - 1];
            Point p4 = lines[last];

            // Find the intersection point (if it exists)
            Point intersection = FindIntersection(p1, p2, p3, p4);

            if (intersection != Point.Empty)
            {
                // Draw a red dot at the intersection point
                Bitmap bitmap = (Bitmap)pictureBox1.Image;
                Graphics graphics = Graphics.FromImage(bitmap);
                Pen pen = new Pen(Color.Red, 5);
                graphics.DrawEllipse(pen, intersection.X - 2, intersection.Y - 2, 5, 5);
                pictureBox1.Image = bitmap;
            }
        }

        private Point FindIntersection(Point p1, Point p2, Point p3, Point p4)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;

            int denominator = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);

            if (denominator == 0)
            {
                // The two lines are parallel or coincident, so there is no intersection point
                return Point.Empty;
            }

            int numerator1 = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
            int numerator2 = (x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3);

            float t1 = (float)numerator1 / (float)denominator;
            float t2 = (float)numerator2 / (float)denominator;

            if (t1 >= 0 && t1 <= 1 && t2 >= 0 && t2 <= 1)
            {
                // There is an intersection point
                int x = (int)(x1 + t1 * (x2 - x1));
                int y = (int)(y1 + t1 * (y2 - y1));
                return new Point(x, y);
            }

            // The two line segments do not intersect
            return Point.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
