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
    public partial class Student : Form
    {
        public int id;
        public Student()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        void info()
        {
            SqlCommand cmd = new SqlCommand("select stdName,stdSurname,clubName,stdGender,stdUserName,stdPassword from TblStudents inner join TblSocialClubs on TblSocialClubs.socialClubId = TblStudents.stdSocialClub where stdId = @p1", conn.conncetion());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr.GetString(0);
                TxtSurname.Text = dr.GetString(1);
                CmbClub.Text = dr.GetString(2);
                CmbGender.Text = dr.GetString(3);
                TxtUserName.Text = dr.GetString(4);
                TxtPassword.Text = dr.GetString(5);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select clubName from TblSocialClubs", conn.conncetion());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbClub.Items.Add(sqlDataReader.GetString(0));
            }

            SqlCommand cmd1 = new SqlCommand("select gradeId, courseName, teacherName + ' ' + teacherSurname as 'Teacher', stdName + ' ' + stdSurname as 'Student', exam1, exam2, exam3, assignment, average, status from TblGrades inner join TblTeachers on TblTeachers.teacherId = TblGrades.tchId inner join TblStudents on TblStudents.stdId = TblGrades.studentId inner join TblCourses on TblCourses.courseId = TblGrades.courseId where studentId = @p1", conn.conncetion());
            cmd1.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.conncetion().Close();

            info();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblStudents set stdSocialClub = @p1, stdUserName=@p2, stdPassword=@p3 where stdId = @p4", conn.conncetion());
                cmd.Parameters.AddWithValue("@p1", CmbClub.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@p2", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@p3", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@p4", id);
                cmd.ExecuteNonQuery();
                conn.conncetion().Close();
                MessageBox.Show("Information Updated");
                info();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");
                throw;
            }
        }
    }
}
