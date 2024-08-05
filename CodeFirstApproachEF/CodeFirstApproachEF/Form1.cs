using CodeFirstApproachEF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstApproachEF
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        StudentDatabaseContext db = new StudentDatabaseContext();
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            dataGridView1.DataSource = db.students.ToList<Student>();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
