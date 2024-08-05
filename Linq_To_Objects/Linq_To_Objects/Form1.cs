using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Linq_To_Objects
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContextStudent dc = new DataContextStudent(conString);
            var result=from i in dc.Table<tb_students>();
            Select i;

            dataGridView1.DataSource = result;
            dc.tb_students.InsertOnSubmit(stu);
            dc.SubmitChanges();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
