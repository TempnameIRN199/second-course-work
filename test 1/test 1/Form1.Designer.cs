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
            this.dataWeekDay = new System.Windows.Forms.DataGridView();
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
            this.dataSubject = new System.Windows.Forms.DataGridView();
            this.dataTeacher = new System.Windows.Forms.DataGridView();
            this.dataGroup = new System.Windows.Forms.DataGridView();
            this.dataLesson = new System.Windows.Forms.DataGridView();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.dataAttendance = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataWeekDay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PageWeekDay.SuspendLayout();
            this.PageSubject.SuspendLayout();
            this.PageTeacher.SuspendLayout();
            this.PageGroups.SuspendLayout();
            this.PageLessons.SuspendLayout();
            this.PageStudent.SuspendLayout();
            this.PageAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataWeekDay
            // 
            this.dataWeekDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWeekDay.Location = new System.Drawing.Point(6, 6);
            this.dataWeekDay.Name = "dataWeekDay";
            this.dataWeekDay.Size = new System.Drawing.Size(664, 388);
            this.dataWeekDay.TabIndex = 0;
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
            this.PageWeekDay.Controls.Add(this.dataWeekDay);
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
            this.PageSubject.Controls.Add(this.dataSubject);
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
            this.PageTeacher.Controls.Add(this.dataTeacher);
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
            this.PageGroups.Controls.Add(this.dataGroup);
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
            this.PageLessons.Controls.Add(this.dataLesson);
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
            this.PageStudent.Controls.Add(this.dataStudent);
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
            this.PageAttendance.Controls.Add(this.dataAttendance);
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
            // dataSubject
            // 
            this.dataSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubject.Location = new System.Drawing.Point(6, 6);
            this.dataSubject.Name = "dataSubject";
            this.dataSubject.Size = new System.Drawing.Size(664, 388);
            this.dataSubject.TabIndex = 1;
            // 
            // dataTeacher
            // 
            this.dataTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeacher.Location = new System.Drawing.Point(6, 6);
            this.dataTeacher.Name = "dataTeacher";
            this.dataTeacher.Size = new System.Drawing.Size(664, 388);
            this.dataTeacher.TabIndex = 1;
            // 
            // dataGroup
            // 
            this.dataGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGroup.Location = new System.Drawing.Point(6, 6);
            this.dataGroup.Name = "dataGroup";
            this.dataGroup.Size = new System.Drawing.Size(664, 388);
            this.dataGroup.TabIndex = 1;
            // 
            // dataLesson
            // 
            this.dataLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLesson.Location = new System.Drawing.Point(6, 6);
            this.dataLesson.Name = "dataLesson";
            this.dataLesson.Size = new System.Drawing.Size(664, 388);
            this.dataLesson.TabIndex = 1;
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(6, 6);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.Size = new System.Drawing.Size(664, 388);
            this.dataStudent.TabIndex = 1;
            // 
            // dataAttendance
            // 
            this.dataAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAttendance.Location = new System.Drawing.Point(6, 6);
            this.dataAttendance.Name = "dataAttendance";
            this.dataAttendance.Size = new System.Drawing.Size(664, 388);
            this.dataAttendance.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(702, 234);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataWeekDay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PageWeekDay.ResumeLayout(false);
            this.PageSubject.ResumeLayout(false);
            this.PageTeacher.ResumeLayout(false);
            this.PageGroups.ResumeLayout(false);
            this.PageLessons.ResumeLayout(false);
            this.PageStudent.ResumeLayout(false);
            this.PageAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataWeekDay;
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
        private System.Windows.Forms.DataGridView dataSubject;
        private System.Windows.Forms.DataGridView dataTeacher;
        private System.Windows.Forms.DataGridView dataGroup;
        private System.Windows.Forms.DataGridView dataLesson;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.DataGridView dataAttendance;
        private System.Windows.Forms.Button btnRefresh;
    }
}

