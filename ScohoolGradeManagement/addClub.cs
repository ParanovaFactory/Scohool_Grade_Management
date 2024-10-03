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
    public partial class addClub : Form
    {
        public addClub()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SQLConnection conn = new SQLConnection();

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from TblSocialClubs", conn.conncetion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void club_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("insert into TblSocialClubs (clubName) values (@p1)", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtClub.Text);
                sql.ExecuteNonQuery();
                conn.conncetion().Close();
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
                SqlCommand sql = new SqlCommand("delete from TblSocialClubs where socialClubId = @p1", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtClubId.Text);
                sql.ExecuteNonQuery();
                conn.conncetion().Close();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value for socialClubId");

                throw;
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("update TblSocialClubs set clubName = @p1 where socialClubId = @p2", conn.conncetion());
                sql.Parameters.AddWithValue("@p1", TxtClub.Text);
                sql.Parameters.AddWithValue("@p2", TxtClubId.Text);
                sql.ExecuteNonQuery();
                conn.conncetion().Close();
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtClub.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
