using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScohoolGradeManagement
{
    public partial class addTeacher : Form
    {
        public addTeacher()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select teacherId, teacherName, teacherSurname, courseName, teacherUserName, teacherPassword from TblTeachers inner join TblCourses on TblCourses.courseId = TblTeachers.teacherDepartment", conn.conncetion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addTeacher_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select courseName from TblCourses", conn.conncetion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbDep.Items.Add(reader.GetString(0));
            }
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtThcId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbDep.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("insert into TblTeachers (teacherName, teacherSurname, teacherDepartment, teacherUserName, teacherPassword) values (@p1,@p2,@p3,@p4,@p5)", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtName.Text);
                sql.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sql.Parameters.AddWithValue("@p3", CmbDep.SelectedIndex + 1);
                sql.Parameters.AddWithValue("@p4", TxtUserName.Text);
                sql.Parameters.AddWithValue("@p5", TxtPassword.Text);
                sql.ExecuteNonQuery();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("update TblTeachers set teacherName = @p1, teacherSurname = @p2, teacherDepartment = @p3, teacherUserName = @p4, teacherPassword = @p5 where teacherId = @p6", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtName.Text);
                sql.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sql.Parameters.AddWithValue("@p3", CmbDep.SelectedIndex + 1);
                sql.Parameters.AddWithValue("@p4", TxtUserName.Text);
                sql.Parameters.AddWithValue("@p5", TxtPassword.Text);
                sql.Parameters.AddWithValue("@p6", TxtThcId.Text);
                sql.ExecuteNonQuery();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("delete from TblTeachers where teacherId = @p1", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtThcId.Text);
                sql.ExecuteNonQuery();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value for teacherId.");

                throw;
            }
            
        }
    }
}
