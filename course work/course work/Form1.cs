using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (hentuhoContext db = new hentuhoContext())
            {
                Group groups = new Group { Name = "3-007" };
                db.Groups.Add(groups);
                db.SaveChanges();
            }
        }
    }
}
