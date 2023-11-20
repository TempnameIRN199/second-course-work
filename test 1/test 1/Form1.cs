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
            //else if (tab == PageSubject)
            //{
            //    FromAdd form2 = new FromAdd(this, "PageSubject");
            //    form2.ShowDialog();
            //}
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
    }
}
