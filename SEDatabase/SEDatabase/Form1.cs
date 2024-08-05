using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SEDatabase
{
    public partial class Form1 : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudais Khan\source\repos\SEDatabase\SEDatabase\SEDatabase.mdf;Integrated Security = false";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            string query = "INSERT INTO teacher VALUES (1,'ubaid','comsats')";
            SqlCommand command = new SqlCommand(query, con);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            string query = "SELECT * From teacher";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                string sqlquery = "DELETE FROM delete WHERE teacherId = teacherId";
                    SqlCommand command = new SqlCommand(sqlquery, con);
                    command.ExecuteNonQuery();
                    string CmdString = "SELECT * FROM teacher";
                    SqlDataAdapter sda = new SqlDataAdapter(CmdString, con);
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
           
                string query = "UPDATE teacher SET teacherName=@name,teacherUni =@uni where teacherId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@uni", textBox2.Text);

                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();
                adapter.Update(dt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}
