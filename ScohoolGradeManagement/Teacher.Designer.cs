namespace ScohoolGradeManagement
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtAssignmet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtStd = new System.Windows.Forms.TextBox();
            this.CmbCourse = new System.Windows.Forms.ComboBox();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.TxtGradeId = new System.Windows.Forms.TextBox();
            this.TxtStdId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCourseId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnClub = new System.Windows.Forms.Button();
            this.BtnCourse = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1085, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(112, 54);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 266);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1175, 241);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(731, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 54);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtAssignmet
            // 
            this.TxtAssignmet.Location = new System.Drawing.Point(576, 78);
            this.TxtAssignmet.Name = "TxtAssignmet";
            this.TxtAssignmet.Size = new System.Drawing.Size(149, 26);
            this.TxtAssignmet.TabIndex = 39;
            this.TxtAssignmet.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(483, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Assignment";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(576, 46);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(149, 26);
            this.TxtExam3.TabIndex = 37;
            this.TxtExam3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(483, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Exam 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(483, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Exam 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(258, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Exam 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(258, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(258, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Course";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 266);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1179, 241);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(731, 72);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 54);
            this.BtnDelete.TabIndex = 44;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(849, 12);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 54);
            this.BtnUpdate.TabIndex = 45;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtStd
            // 
            this.TxtStd.Location = new System.Drawing.Point(325, 46);
            this.TxtStd.Name = "TxtStd";
            this.TxtStd.ReadOnly = true;
            this.TxtStd.Size = new System.Drawing.Size(149, 26);
            this.TxtStd.TabIndex = 33;
            // 
            // CmbCourse
            // 
            this.CmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCourse.FormattingEnabled = true;
            this.CmbCourse.Location = new System.Drawing.Point(325, 12);
            this.CmbCourse.Name = "CmbCourse";
            this.CmbCourse.Size = new System.Drawing.Size(149, 28);
            this.CmbCourse.TabIndex = 46;
            this.CmbCourse.SelectedIndexChanged += new System.EventHandler(this.CmbCourse_SelectedIndexChanged);
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(325, 78);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(149, 26);
            this.TxtExam1.TabIndex = 47;
            this.TxtExam1.Text = "0";
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(576, 12);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(149, 26);
            this.TxtExam2.TabIndex = 48;
            this.TxtExam2.Text = "0";
            // 
            // TxtGradeId
            // 
            this.TxtGradeId.Location = new System.Drawing.Point(103, 12);
            this.TxtGradeId.Name = "TxtGradeId";
            this.TxtGradeId.ReadOnly = true;
            this.TxtGradeId.Size = new System.Drawing.Size(149, 26);
            this.TxtGradeId.TabIndex = 56;
            // 
            // TxtStdId
            // 
            this.TxtStdId.Location = new System.Drawing.Point(103, 78);
            this.TxtStdId.Name = "TxtStdId";
            this.TxtStdId.ReadOnly = true;
            this.TxtStdId.Size = new System.Drawing.Size(149, 26);
            this.TxtStdId.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Student Id";
            // 
            // TxtCourseId
            // 
            this.TxtCourseId.Location = new System.Drawing.Point(103, 46);
            this.TxtCourseId.Name = "TxtCourseId";
            this.TxtCourseId.ReadOnly = true;
            this.TxtCourseId.Size = new System.Drawing.Size(149, 26);
            this.TxtCourseId.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Course Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Grade Id";
            // 
            // BtnClub
            // 
            this.BtnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClub.ForeColor = System.Drawing.Color.White;
            this.BtnClub.Location = new System.Drawing.Point(849, 72);
            this.BtnClub.Name = "BtnClub";
            this.BtnClub.Size = new System.Drawing.Size(112, 54);
            this.BtnClub.TabIndex = 57;
            this.BtnClub.Text = "Club";
            this.BtnClub.UseVisualStyleBackColor = true;
            this.BtnClub.Click += new System.EventHandler(this.BtnClubAdd_Click);
            // 
            // BtnCourse
            // 
            this.BtnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCourse.ForeColor = System.Drawing.Color.White;
            this.BtnCourse.Location = new System.Drawing.Point(967, 12);
            this.BtnCourse.Name = "BtnCourse";
            this.BtnCourse.Size = new System.Drawing.Size(112, 54);
            this.BtnCourse.TabIndex = 58;
            this.BtnCourse.Text = "Course";
            this.BtnCourse.UseVisualStyleBackColor = true;
            this.BtnCourse.Click += new System.EventHandler(this.BtnCourse_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacher.ForeColor = System.Drawing.Color.White;
            this.BtnTeacher.Location = new System.Drawing.Point(967, 72);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(112, 54);
            this.BtnTeacher.TabIndex = 59;
            this.BtnTeacher.Text = "Teacher";
            this.BtnTeacher.UseVisualStyleBackColor = true;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // BtnStudent
            // 
            this.BtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudent.ForeColor = System.Drawing.Color.White;
            this.BtnStudent.Location = new System.Drawing.Point(1085, 72);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(112, 54);
            this.BtnStudent.TabIndex = 60;
            this.BtnStudent.Text = "Student";
            this.BtnStudent.UseVisualStyleBackColor = true;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1207, 683);
            this.Controls.Add(this.BtnStudent);
            this.Controls.Add(this.BtnTeacher);
            this.Controls.Add(this.BtnCourse);
            this.Controls.Add(this.BtnClub);
            this.Controls.Add(this.TxtGradeId);
            this.Controls.Add(this.TxtStdId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCourseId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtExam2);
            this.Controls.Add(this.TxtExam1);
            this.Controls.Add(this.CmbCourse);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtAssignmet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtExam3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Teacher";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtAssignmet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtStd;
        private System.Windows.Forms.ComboBox CmbCourse;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.TextBox TxtGradeId;
        private System.Windows.Forms.TextBox TxtStdId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCourseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnClub;
        private System.Windows.Forms.Button BtnCourse;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button BtnStudent;
    }
}