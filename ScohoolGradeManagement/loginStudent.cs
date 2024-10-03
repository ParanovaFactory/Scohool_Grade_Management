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
    public partial class loginStudent : Form
    {
        public loginStudent()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerStudent registerStudent = new registerStudent();
            this.Hide();
            registerStudent.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select stdId, stdUserName, stdPassword from TblStudents where stdUserName = @p1 and stdPassword = @p2", conn.conncetion());
            cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            {
                Student student = new Student();
                student.id = dr.GetInt32(0);
                this.Hide();
                student.Show();
            }
            else
            {
                MessageBox.Show("User name or password wrong");
            }
            conn.conncetion().Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
