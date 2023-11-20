using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabPage tab = tabControl1.SelectedTab;

            using (testContext db = new testContext())
            {
                try
                {
                    //Groups group = new Groups { Id = 1, Name = "3-007" };
                    //db.Groups.Add(group);
                    //db.SaveChanges();

                    //select * from Groups to dataGridView1
                    //var groups = db.Groups.ToList();
                    //dataGridView1.DataSource = groups;
                    dataWeekDay.DataSource = db.WeekDays.ToList();
                    dataSubject.DataSource = db.Subjects.ToList();
                    dataTeacher.DataSource = db.Teachers.ToList();
                    dataGroup.DataSource = db.Groups.ToList();
                    dataLesson.DataSource = db.Lessons.ToList();
                    dataStudent.DataSource = db.Students.ToList();
                    dataAttendance.DataSource = db.Attendance.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TabPage tab = tabControl1.SelectedTab;

            if (tab == PageWeekDay)
            {
                FromAdd form2 = new FromAdd(this, "PageWeekDay");
                form2.ShowDialog();
            }
            else if (tab == PageSubject)
            {
                FromAdd form2 = new FromAdd(this, "PageSubject");
                form2.ShowDialog();
            }
            else if (tab == PageTeacher)
            {
                FromAdd form2 = new FromAdd(this, "PageTeacher");
                form2.ShowDialog();
            }
            else if (tab == PageGroups)
            {
                FromAdd form2 = new FromAdd(this, "PageGroups");
                form2.ShowDialog();
            }
            else if (tab == PageLessons)
            {
                FromAdd form2 = new FromAdd(this, "PageLessons");
                form2.ShowDialog();
            }
            else if (tab == PageStudent)
            {
                FromAdd form2 = new FromAdd(this, "PageStudent");
                form2.ShowDialog();
            }
            else if (tab == PageAttendance)
            {
                FromAdd form2 = new FromAdd(this, "PageAttendance");
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete form3 = new FormDelete();
            form3.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit form4 = new FormEdit();
            form4.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TabPage tab = tabControl1.SelectedTab;

            using (testContext db = new testContext())
            {
                if (tab == PageWeekDay)
                {
                    dataWeekDay.DataSource = null;
                    dataWeekDay.Rows.Clear();
                    dataWeekDay.Columns.Clear();
                    dataWeekDay.Refresh();
                    dataWeekDay.DataSource = db.WeekDays.ToList();
                }
                else if (tab == PageSubject)
                {
                    dataSubject.DataSource = null;
                    dataSubject.Rows.Clear();
                    dataSubject.Columns.Clear();
                    dataSubject.Refresh();
                    dataSubject.DataSource = db.Subjects.ToList();
                }
                else if (tab == PageTeacher)
                {
                    dataTeacher.DataSource = null;
                    dataTeacher.Rows.Clear();
                    dataTeacher.Columns.Clear();
                    dataTeacher.Refresh();
                    dataTeacher.DataSource = db.Teachers.ToList();
                }
                else if (tab == PageGroups)
                {
                    dataGroup.DataSource = null;
                    dataGroup.Rows.Clear();
                    dataGroup.Columns.Clear();
                    dataGroup.Refresh();
                    dataGroup.DataSource = db.Groups.ToList();
                }
                else if (tab == PageLessons)
                {
                    dataLesson.DataSource = null;
                    dataLesson.Rows.Clear();
                    dataLesson.Columns.Clear();
                    dataLesson.Refresh();
                    dataLesson.DataSource = db.Lessons.ToList();
                }
                else if (tab == PageStudent)
                {
                    dataStudent.DataSource = null;
                    dataStudent.Rows.Clear();
                    dataStudent.Columns.Clear();
                    dataStudent.Refresh();
                    dataStudent.DataSource = db.Students.ToList();
                }
                else if (tab == PageAttendance)
                {
                    dataAttendance.DataSource = null;
                    dataAttendance.Rows.Clear();
                    dataAttendance.Columns.Clear();
                    dataAttendance.Refresh();
                    dataAttendance.DataSource = db.Attendance.ToList();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }
    }
}
