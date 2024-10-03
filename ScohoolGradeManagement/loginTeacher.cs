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
    public partial class loginTeacher : Form
    {
        public loginTeacher()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select teacherId, teacherUserName, teacherPassword from TblTeachers where teacherUserName = @p1 and teacherPassword = @p2", conn.conncetion());
            cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                Teacher teacher = new Teacher();
                teacher.id = dr.GetInt32(0);
                this.Hide();
                teacher.Show();
            }
            else
            {
                MessageBox.Show("User name or password wrong");
            }
            conn.conncetion().Close();
        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerTeacher registerTeacher = new registerTeacher();
            this.Hide();
            registerTeacher.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
