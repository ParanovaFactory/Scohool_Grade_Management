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
    public partial class registerTeacher : Form
    {
        public registerTeacher()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginTeacher loginTeacher = new loginTeacher();
            this.Hide();
            loginTeacher.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblTeachers (teacherName, teacherSurname, teacherDepartment, teacherUserName, teacherPassword) values (@p1,@p2,@p3,@p4,@p5)", conn.conncetion());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p3", CmbDepartment.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@p4", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered sucesfully");
                conn.conncetion().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void registerTeacher_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select courseName from TblCourses", conn.conncetion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbDepartment.Items.Add(reader.GetString(0));
            }
            conn.conncetion().Close();
        }
    }
}
