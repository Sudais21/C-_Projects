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

namespace LINQTOSQL
{
    public partial class Form1 : Form
    {
        
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudais Khan\source\repos\LINQTOSQL\LINQTOSQL\student_db.mdf;Integrated Security=True";
        SqlConnection sqlCon;
        public Form1()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(connString);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentClassesDataContext dc = new StudentClassesDataContext(sqlCon);
            tb_student st = new tb_student();
            st.Id = 4;
            st.name = "Hazel";
            st.address = "Swabi";

            dc.tb_students.InsertOnSubmit(st);
            dc.SubmitChanges();

            var result = from i in dc.GetTable<tb_student>()
                         select i;
            dataGridView1.DataSource = result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentClassesDataContext dc = new StudentClassesDataContext(sqlCon);

            var result = from i in dc.GetTable<tb_student>()
                         select i;
            dataGridView1.DataSource = result;

            



        }
    }
}
