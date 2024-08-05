using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project003
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private Color lineColor = Color.Black;
        private List<Line> lines = new List<Line>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string name = tbName.Text;
            string x1 = tbX1.Text;
            string y1 = tbY1.Text;
            string x2 = tbX2.Text;
            string y2 = tbY2.Text;
            Color color = btnColor.BackColor;

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(x1) ||
                string.IsNullOrWhiteSpace(y1) || string.IsNullOrWhiteSpace(x2) ||
                string.IsNullOrWhiteSpace(y2))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse values to float
            if (!float.TryParse(x1, out float startX) ||
                !float.TryParse(y1, out float startY) ||
                !float.TryParse(x2, out float endX) ||
                !float.TryParse(y2, out float endY))
            {
                MessageBox.Show("Please enter valid numbers for the coordinates.");
                return;
            }

            // Create new line and add to list
            Line line = new Line(name, startX, startY, endX, endY, color);
            lines.Add(line);

            // Add line to ListView
            ListViewItem item = new ListViewItem(line.Name);
            item.SubItems.Add(line.Start.X.ToString());
            item.SubItems.Add(line.Start.Y.ToString());
            item.SubItems.Add(line.End.X.ToString());
            item.SubItems.Add(line.End.Y.ToString());
            item.BackColor = line.Color;
            lvLines.Items.Add(item);

            // Clear textboxes and set focus to Name textbox
            tbName.Clear();
            tbX1.Clear();
            tbY1.Clear();
            tbX2.Clear();
            tbY2.Clear();
            btnColor.BackColor = Color.Black;
            tbName.Focus();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            Line line = new Line(startPoint, endPoint, lineColor);
            lines.Add(line);
            pictureBox1.Invalidate();
            AddLineToListView(line);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Line line in lines)
            {
                Pen pen = new Pen(line.Color);
                e.Graphics.DrawLine(pen, line.StartPoint, line.EndPoint);
                pen.Dispose();
            }
        }
        private void AddLineToListView(Line line)
        {
            ListViewItem item = new ListViewItem();
            item.Text = line.StartPoint.ToString();
            item.SubItems.Add(line.EndPoint.ToString());
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lineColor = colorDialog.Color;
                button2.ForeColor = lineColor;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a line to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = listView1.SelectedIndices[0];
            if (selectedIndex < 0 || selectedIndex >= listView1.Items.Count)
            {
                MessageBox.Show("Invalid selected index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Line selectedLine = lines[selectedIndex];
            pictureBox1.Image = null;
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                foreach (Line line in lines)
                {
                    if (!line.Equals(selectedLine))
                    {
                        line.Draw(g);
                    }
                }
            }

            listView1.Items.RemoveAt(selectedIndex);
            int newSelectedIndex = selectedIndex == 0 ? 0 : selectedIndex - 1;
            if (listView1.Items.Count > 0)
            {
                listView1.Items[newSelectedIndex].Selected = true;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Line selectedLine = (Line)listView1.SelectedItems[0].Tag;
                textBox1.Text = selectedLine.StartPoint.ToString();
                textBox2.Text = selectedLine.EndPoint.ToString();
                colorDialog1.Color = selectedLine.LineColor;
                button1.ForeColor = (Color)selectedLine.LineColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Line selectedLine = (Line)listView1.SelectedItems[0].Tag;
                try
                {
                    selectedLine.StartPoint = Point.Parse(textBox1.Text);
                    selectedLine.EndPoint = Point.Parse(textBox2.Text);
                    selectedLine.LineColor = colorDialog1.Color;
                    listView1.SelectedItems[0].Text = $"{selectedLine.StartPoint} - {selectedLine.EndPoint}";
                    listView1.SelectedItems[0].ForeColor = (Color)selectedLine.LineColor;
                    pictureBox1.Invalidate();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid point format.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLines.Items.Count; i++)
            {
                for (int j = i + 1; j < lstLines.Items.Count; j++)
                {
                    var line1 = (Line)lstLines.Items[i];
                    var line2 = (Line)lstLines.Items[j];

                    if (line1.IntersectsWith(line2, out PointF intersection))
                    {
                        if (line1.IsOverlapping(line2))
                        {
                            // draw a line between the overlapping points
                            PointF start = PointF.Empty;
                            PointF end = PointF.Empty;

                            if (line1.IsHorizontal())
                            {
                                start = new PointF(line2.Start.X, line1.Start.Y);
                                end = new PointF(line2.End.X, line1.End.Y);
                            }
                            else if (line1.IsVertical())
                            {
                                start = new PointF(line1.Start.X, line2.Start.Y);
                                end = new PointF(line1.End.X, line2.End.Y);
                            }

                            using (var g = picCanvas.CreateGraphics())
                            {
                                g.DrawLine(Pens.Blue, start, end);
                            }
                        }
                        else
                        {
                            // draw a circle around the intersection point
                            using (var g = picCanvas.CreateGraphics())
                            {
                                g.DrawEllipse(Pens.Blue, intersection.X - 5, intersection.Y - 5, 10, 10);
                            }
                        }
                    }
                }
            }
        }
    }
}
