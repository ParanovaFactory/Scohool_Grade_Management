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
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        void list()
        {
            SqlCommand cmd1 = new SqlCommand("select stdId, stdName, stdSurname, clubName, stdGender, stdUserName, stdPassword from TblStudents inner join TblSocialClubs on TblSocialClubs.socialClubId = TblStudents.stdSocialClub", conn.conncetion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select clubName from TblSocialClubs", conn.conncetion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbClub.Items.Add(reader.GetString(0));
            }
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("insert into TblStudents (stdName, stdSurname, stdSocialClub, stdGender, stdUserName, stdPassword) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtName.Text);
                sql.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sql.Parameters.AddWithValue("@p3", CmbClub.SelectedIndex + 1);
                sql.Parameters.AddWithValue("@p4", CmbGender.Text);
                sql.Parameters.AddWithValue("@p5", TxtUserName.Text);
                sql.Parameters.AddWithValue("@p6", TxtPassword.Text);
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
                SqlCommand sql = new SqlCommand("update TblStudents set stdName = @p1, stdSurname = @p2, stdSocialClub = @p3, stdGender = @p4, stdUserName = @p5, stdPassword = @p6 where stdId = @p7", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtName.Text);
                sql.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sql.Parameters.AddWithValue("@p3", CmbClub.SelectedIndex + 1);
                sql.Parameters.AddWithValue("@p4", CmbGender.Text);
                sql.Parameters.AddWithValue("@p5", TxtUserName.Text);
                sql.Parameters.AddWithValue("@p6", TxtPassword.Text);
                sql.Parameters.AddWithValue("@p7", TxtStdId.Text);
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
                SqlCommand sql = new SqlCommand("delete from TblStudents where stdId = @p1", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtStdId.Text);
                sql.ExecuteNonQuery();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value for gradeId.");

                throw;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStdId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbClub.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            CmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
