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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        public int id;
        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select courseName from TblCourses", conn.conncetion());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbCourse.Items.Add(dr.GetSqlString(0));
            }

            SqlCommand cmd2 = new SqlCommand("select stdId,stdName,stdSurname from TblStudents", conn.conncetion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd3 = new SqlCommand("select gradeId, courseName, teacherName + ' ' + teacherSurname as 'Teacher', stdName + ' ' + stdSurname as 'Student', exam1, exam2, exam3, assignment, average, status, crsId, studentId from TblGrades inner join TblTeachers on TblTeachers.teacherId = TblGrades.tchId inner join TblStudents on TblStudents.stdId = TblGrades.studentId inner join TblCourses on TblCourses.courseId = TblGrades.crsId where tchId = @p1", conn.conncetion());
            cmd3.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into TblGrades (crsId, tchId, studentId, exam1, exam2, exam3, assignment) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.conncetion());
            sqlCommand.Parameters.AddWithValue("@p1", TxtCourseId.Text);
            sqlCommand.Parameters.AddWithValue("@p2", id);
            sqlCommand.Parameters.AddWithValue("@p3", TxtStdId.Text);
            sqlCommand.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtExam1.Text));
            sqlCommand.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtExam2.Text));
            sqlCommand.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtExam3.Text));
            sqlCommand.Parameters.AddWithValue("@p7", Convert.ToDecimal(TxtAssignmet.Text));
            sqlCommand.ExecuteNonQuery();
            list();
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtStdId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CmbCourse.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtExam1.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtExam2.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtExam3.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtAssignmet.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtGradeId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCourseId.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
            TxtStdId.Text = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
            TxtStd.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void CmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCourseId.Text = (CmbCourse.SelectedIndex + 1).ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("update TblGrades set exam1 = @p1, exam2 = @p2, exam3 = @p3, assignment = @p4 where gradeId = @p5", conn.conncetion());
                sqlCommand.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtExam1.Text));
                sqlCommand.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtExam2.Text));
                sqlCommand.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtExam3.Text));
                sqlCommand.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtAssignmet.Text));
                sqlCommand.Parameters.AddWithValue("@p5", TxtGradeId.Text);
                sqlCommand.ExecuteNonQuery();
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
                SqlCommand sqlCommand = new SqlCommand("delete from TblGrades where gradeId = @p1", conn.conncetion());
                sqlCommand.Parameters.AddWithValue("@p1", TxtGradeId.Text);
                sqlCommand.ExecuteNonQuery();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value for gradeId.");
                throw;
            }
            
        }

        private void BtnClubAdd_Click(object sender, EventArgs e)
        {
            addClub club = new addClub();
            club.Show();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            addCourse course = new addCourse();
            course.Show();
        }

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            addTeacher teacher = new addTeacher();
            teacher.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            addStudent student = new addStudent();
            student.Show();
        }
    }
}
