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
    public partial class FromAdd : Form
    {
        private Form1 frm1;

        public FromAdd(Form1 form1, string tabPageName)
        {
            InitializeComponent();
            frm1 = form1;
            if (tabPageName == "PageWeekDay")
            {
                this.Text = "WeekDay";

                Label label = new Label();
                label.Text = "Week Day:";
                label.Location = new Point(10, 10);
                label.Size = new Size(100, 30);
                this.Controls.Add(label);

                TextBox txt = new TextBox();
                txt.Location = new Point(10, 50);
                txt.Size = new Size(100, 30);
                this.Controls.Add(txt);

                Button btn = new Button();
                btn.Text = "Add";
                btn.Location = new Point(10, 90);
                btn.Size = new Size(100, 30);
                btn.Click += btnAdd_Click;
                this.Controls.Add(btn);
            }
            else if (tabPageName == "PageSubject")
            {
                this.Text = "PageSubject";
            }
            else if (tabPageName == "PageTeacher")
            {
                this.Text = "PageTeacher";
            }
            else if (tabPageName == "PageGroups")
            {
                this.Text = "PageGroups";
            }
            else if (tabPageName == "PageLessons")
            {
                this.Text = "PageLessons";
            }
            else if (tabPageName == "PageStudent")
            {
                this.Text = "PageStudent";
            }
            else if (tabPageName == "PageAttendance")
            {
                this.Text = "PageAttendance";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (testContext db = new testContext())
            {
                if (this.Text == "PageWeekDay")
                {
                    WeekDays weekDay = new WeekDays();
                    weekDay.Name = this.Controls[1].Text;
                    db.WeekDays.Add(weekDay);
                    db.SaveChanges();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
