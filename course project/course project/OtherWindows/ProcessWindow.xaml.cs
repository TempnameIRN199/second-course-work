using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using course_project.DB;
//using EnvDTE;
using OtherClass;

namespace course_project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для ProcessWindow.xaml
    /// </summary>
    public partial class ProcessWindow : Window
    {

        Student updStudent = new Student();
        Subject updSubject = new Subject();
        Teacher updTeacher = new Teacher();
        TypeSubject updTypeSubject = new TypeSubject();
        Attendance updAttendance = new Attendance();

        public ProcessWindow()
        {
            InitializeComponent();
            Load_Windows();
        }

        public void Load_Windows()
        {
            using (NintendoContext db = new NintendoContext())
            {
                var query = from attendance in db.Attendance
                            join typeSubject in db.TypeSubject on attendance.TypeSubjectId equals typeSubject.Id
                            join student in db.Student on attendance.StudentId equals student.Id
                            join subject in db.Subject on typeSubject.SubjectId equals subject.Id
                            select new AttendanceItem
                            {
                                Id = attendance.Id,
                                StudentName = student.Surname + " " + student.Name,
                                SubjectName = subject.Name,
                                Skip11 = attendance.Skip.ToString()
                            };

                var viewModel = new AttendanceViewModel();

                viewModel.Attendance.Clear();

                foreach (var item in query)
                {
                    viewModel.Attendance.Add(item);
                }

                this.DataContext = viewModel;
            }
        }


        //public void Load_Windows()
        //{


        //    using (NintendoContext db = new NintendoContext())
        //    {
        //        var query = from attendance in db.Attendance
        //                    join typeSubject in db.TypeSubject on attendance.TypeSubjectId equals typeSubject.Id
        //                    join student in db.Student on attendance.StudentId equals student.Id
        //                    join subject in db.Subject on typeSubject.SubjectId equals subject.Id
        //                    select new AttendanceItem
        //                    {
        //                        Id = attendance.Id, // Ідентифікатор з таблиці Attendance
        //                        StudentName = student.Surname + " " + student.Name,
        //                        SubjectName = subject.Name,
        //                        Skip11 = attendance.Skip.ToString()
        //                    };

        //        var viewModel = new AttendanceViewModel
        //        {
        //            Attendance = new ObservableCollection<AttendanceItem>(query.ToList())
        //        };

        //        this.DataContext = viewModel;
        //    }
        //}

        private void AttendanceListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (AttendanceListView.SelectedItems != null)
            {
                if (AttendanceListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Ну і що ти тут забув?");
                    return;
                }
                else
                {
                    using (NintendoContext db = new NintendoContext())
                    {
                        foreach (AttendanceItem selectedItem in AttendanceListView.SelectedItems)
                        {
                            updAttendance = db.Attendance.Find(selectedItem.Id);
                        }
                        if (updAttendance == null)
                        {
                            MessageBox.Show("Не суй туди руки");
                            return;
                        }
                        else
                        {
                            EditWindow windowEdit = new EditWindow("InfoEdit", typeof(Attendance), updStudent, updSubject, updTeacher, updTypeSubject, updAttendance);
                            windowEdit.ShowDialog();
                        }
                    }
                }
                Load_Windows();
            }
        }
    }
}