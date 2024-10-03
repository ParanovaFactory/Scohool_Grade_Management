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
    public partial class addCourse : Form
    {
        public addCourse()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TblCoursesTableAdapter ds = new DataSet1TableAdapters.TblCoursesTableAdapter();

        private void addCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetCourse();           
            //list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ds.InsertCourse(TxtCourse.Text);
            dataGridView1.DataSource = ds.GetCourse();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.DeleteCourse(byte.Parse(TxtCourseId.Text));
            dataGridView1.DataSource = ds.GetCourse();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdateCourse(TxtCourse.Text,byte.Parse(TxtCourseId.Text));
            dataGridView1.DataSource = ds.GetCourse();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCourseId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCourse.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
