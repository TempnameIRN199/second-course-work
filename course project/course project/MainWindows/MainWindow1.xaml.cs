using course_project.DB;
using System;
using System.Collections.Generic;
using System.Linq;
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
using course_project.OtherWindows;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace course_project.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        Student updStudent = new Student();
        Subject updSubject = new Subject();
        Teacher updTeacher = new Teacher();
        TypeSubject updTypeSubject = new TypeSubject();
        Attendance updAttendance = new Attendance();

        public MainWindow1()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            using (NintendoContext db = new NintendoContext())
            {
                StudentListView.ItemsSource = null;
                SubjectListView.ItemsSource = null;
                TeacherListView.ItemsSource = null;
                TypeSubjectListView.ItemsSource = null;
                AttendanceListView.ItemsSource = null;

                db.Student.Load();
                db.Subject.Load();
                db.Teacher.Load();
                db.TypeSubject.Load();
                db.Attendance.Load();

                StudentListView.ItemsSource = db.Student.Local.ToBindingList();
                SubjectListView.ItemsSource = db.Subject.Local.ToBindingList();
                TeacherListView.ItemsSource = db.Teacher.Local.ToBindingList();
                TypeSubjectListView.ItemsSource = db.TypeSubject.Local.ToBindingList();
                AttendanceListView.ItemsSource = db.Attendance.Local.ToBindingList();
            }
        }

        private void Window_Loaded()
        {
            using (NintendoContext db = new NintendoContext())
            {
                StudentListView.ItemsSource = null;
                SubjectListView.ItemsSource = null;
                TeacherListView.ItemsSource = null;
                TypeSubjectListView.ItemsSource = null;
                AttendanceListView.ItemsSource = null;

                db.Student.Load();
                db.Subject.Load();
                db.Teacher.Load();
                db.TypeSubject.Load();
                db.Attendance.Load();

                StudentListView.ItemsSource = db.Student.Local.ToBindingList();
                SubjectListView.ItemsSource = db.Subject.Local.ToBindingList();
                TeacherListView.ItemsSource = db.Teacher.Local.ToBindingList();
                TypeSubjectListView.ItemsSource = db.TypeSubject.Local.ToBindingList();
                AttendanceListView.ItemsSource = db.Attendance.Local.ToBindingList();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (StudentPage.IsSelected)
            {
                AddWindow windowAdd = new AddWindow("StudentAdd");
                windowAdd.ShowDialog();
            }
            else if (SubjectPage.IsSelected)
            {
                AddWindow windowAdd = new AddWindow("SubjectAdd");
                windowAdd.ShowDialog();
            }
            else if (TeacherPage.IsSelected)
            {
                AddWindow windowAdd = new AddWindow("TeacherAdd");
                windowAdd.ShowDialog();
            }
            else if (TypeSubjectPage.IsSelected)
            {
                AddWindow windowAdd = new AddWindow("TypeSubjectAdd");
                windowAdd.ShowDialog();
            }
            else if (AttendancePage.IsSelected)
            {
                AddWindow windowAdd = new AddWindow("AttendanceAdd");
                windowAdd.ShowDialog();
            }
            Window_Loaded();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
