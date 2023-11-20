namespace test_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageWeekDay = new System.Windows.Forms.TabPage();
            this.PageSubject = new System.Windows.Forms.TabPage();
            this.PageTeacher = new System.Windows.Forms.TabPage();
            this.PageGroups = new System.Windows.Forms.TabPage();
            this.PageLessons = new System.Windows.Forms.TabPage();
            this.PageStudent = new System.Windows.Forms.TabPage();
            this.PageAttendance = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(702, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(86, 43);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(702, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageWeekDay);
            this.tabControl1.Controls.Add(this.PageSubject);
            this.tabControl1.Controls.Add(this.PageTeacher);
            this.tabControl1.Controls.Add(this.PageGroups);
            this.tabControl1.Controls.Add(this.PageLessons);
            this.tabControl1.Controls.Add(this.PageStudent);
            this.tabControl1.Controls.Add(this.PageAttendance);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // PageWeekDay
            // 
            this.PageWeekDay.Location = new System.Drawing.Point(4, 22);
            this.PageWeekDay.Name = "PageWeekDay";
            this.PageWeekDay.Padding = new System.Windows.Forms.Padding(3);
            this.PageWeekDay.Size = new System.Drawing.Size(676, 400);
            this.PageWeekDay.TabIndex = 0;
            this.PageWeekDay.Text = "Page Week Day";
            this.PageWeekDay.UseVisualStyleBackColor = true;
            // 
            // PageSubject
            // 
            this.PageSubject.Location = new System.Drawing.Point(4, 22);
            this.PageSubject.Name = "PageSubject";
            this.PageSubject.Padding = new System.Windows.Forms.Padding(3);
            this.PageSubject.Size = new System.Drawing.Size(676, 400);
            this.PageSubject.TabIndex = 1;
            this.PageSubject.Text = "Page Subject";
            this.PageSubject.UseVisualStyleBackColor = true;
            // 
            // PageTeacher
            // 
            this.PageTeacher.Location = new System.Drawing.Point(4, 22);
            this.PageTeacher.Name = "PageTeacher";
            this.PageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.PageTeacher.Size = new System.Drawing.Size(676, 400);
            this.PageTeacher.TabIndex = 2;
            this.PageTeacher.Text = "Page Teacher";
            this.PageTeacher.UseVisualStyleBackColor = true;
            // 
            // PageGroups
            // 
            this.PageGroups.Location = new System.Drawing.Point(4, 22);
            this.PageGroups.Name = "PageGroups";
            this.PageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.PageGroups.Size = new System.Drawing.Size(676, 400);
            this.PageGroups.TabIndex = 3;
            this.PageGroups.Text = "Page Group";
            this.PageGroups.UseVisualStyleBackColor = true;
            // 
            // PageLessons
            // 
            this.PageLessons.Location = new System.Drawing.Point(4, 22);
            this.PageLessons.Name = "PageLessons";
            this.PageLessons.Padding = new System.Windows.Forms.Padding(3);
            this.PageLessons.Size = new System.Drawing.Size(676, 400);
            this.PageLessons.TabIndex = 4;
            this.PageLessons.Text = "Page Lesson";
            this.PageLessons.UseVisualStyleBackColor = true;
            // 
            // PageStudent
            // 
            this.PageStudent.Location = new System.Drawing.Point(4, 22);
            this.PageStudent.Name = "PageStudent";
            this.PageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.PageStudent.Size = new System.Drawing.Size(676, 400);
            this.PageStudent.TabIndex = 5;
            this.PageStudent.Text = "Page Student";
            this.PageStudent.UseVisualStyleBackColor = true;
            // 
            // PageAttendance
            // 
            this.PageAttendance.Location = new System.Drawing.Point(4, 22);
            this.PageAttendance.Name = "PageAttendance";
            this.PageAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.PageAttendance.Size = new System.Drawing.Size(676, 400);
            this.PageAttendance.TabIndex = 6;
            this.PageAttendance.Text = "Page Attendance";
            this.PageAttendance.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(702, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(702, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageWeekDay;
        private System.Windows.Forms.TabPage PageSubject;
        private System.Windows.Forms.TabPage PageTeacher;
        private System.Windows.Forms.TabPage PageGroups;
        private System.Windows.Forms.TabPage PageLessons;
        private System.Windows.Forms.TabPage PageStudent;
        private System.Windows.Forms.TabPage PageAttendance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}

