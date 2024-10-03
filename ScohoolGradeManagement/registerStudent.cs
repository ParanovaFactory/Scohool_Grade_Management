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
    public partial class registerStudent : Form
    {
        public registerStudent()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginStudent loginStudent = new loginStudent();
            this.Hide();
            loginStudent.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblStudents (stdName, stdSurname, stdSocialClub, stdGender, stdUserName, stdPassword) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.conncetion());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p3", CmbClub.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@p5", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@p6", TxtPassword.Text);
                if (CmbGender.SelectedIndex == 0)
                {
                    cmd.Parameters.AddWithValue("@p4", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@p4", "Female");
                }
                cmd.ExecuteNonQuery();
                conn.conncetion().Close();
                MessageBox.Show("Registered succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void registerStudent_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select clubName from TblSocialClubs",conn.conncetion());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                CmbClub.Items.Add(reader.GetString(0));
            }
            conn.conncetion().Close();
        }
    }
}
