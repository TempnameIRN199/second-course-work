using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IO;
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
using System.Xml.Linq;
using course_project.DB;
using course_project.MainWindows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OtherClass;

namespace course_project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для ProcessWindow.xaml
    /// </summary>
    public partial class ProcessWindow : Window
    {
        Student updStudent1 = new Student();
        Subject updSubject1 = new Subject();
        Teacher updTeacher1 = new Teacher();
        TypeSubject updTypeSubject1 = new TypeSubject();
        Attendance updAttendance1 = new Attendance();
        private int fileCount = 1;
        string folderPath = @"E:\Project VS\C#\course work\course-work\JSON";

        public ProcessWindow(Student updStundet = null, Subject updSubject = null, Teacher updTeacher = null, TypeSubject updTypeSubject = null, Attendance updAttendance = null)
        {
            InitializeComponent();

            updStudent1 = updStundet;
            updSubject1 = updSubject;
            updTeacher1 = updTeacher;
            updTypeSubject1 = updTypeSubject;
            updAttendance1 = updAttendance;

            Load_Windows() ;
        }

        public void Load_Windows()
        {
            using (NintendoContext db = new NintendoContext())
            {
                int? studentId = updStudent1?.Id;
                int? subjectId = updSubject1?.Id;
                int? teacherId = updTeacher1?.Id;

                var query = from attendance in db.Attendance
                            join typeSubject in db.TypeSubject on attendance.TypeSubjectId equals typeSubject.Id
                            join student in db.Student on attendance.StudentId equals student.Id
                            join subject in db.Subject on typeSubject.SubjectId equals subject.Id
                            join teacher in db.Teacher on typeSubject.TeacherId equals teacher.Id
                            where
                                (studentId == null || student.Id == studentId.Value) &&
                                (subjectId == null || subject.Id == subjectId.Value) &&
                                (teacherId == null || teacher.Id == teacherId.Value)
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
                            updAttendance1 = db.Attendance.Find(selectedItem.Id);
                        }
                        if (updAttendance1 == null)
                        {
                            MessageBox.Show("Не суй туди руки");
                            return;
                        }
                        else
                        {
                            EditWindow windowEdit = new EditWindow("InfoEdit", typeof(Attendance), updStudent1, updSubject1, updTeacher1, updTypeSubject1, updAttendance1);
                            windowEdit.ShowDialog();
                        }
                    }
                }
                Load_Windows();
            }
        }

        private void JSONButton_Click(object sender, RoutedEventArgs e)
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

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var viewModel = new AttendanceViewModel();

                viewModel.Attendance.Clear();

                foreach (var item in query)
                {
                    viewModel.Attendance.Add(item);
                }

                string filename = System.IO.Path.Combine(folderPath, $"day-{fileCount}.json");
                bool fileExists = File.Exists(filename);
                while (fileExists)
                {
                    fileCount++;
                    filename = System.IO.Path.Combine(folderPath, $"day-{fileCount}.json");
                    fileExists = File.Exists(filename);
                }

                string json = JsonConvert.SerializeObject(viewModel.Attendance, Formatting.Indented);
                File.WriteAllText(filename, json);
                MessageBox.Show("Файл збережено");
                fileCount++;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 mainWindow1 = new MainWindow1();
            mainWindow1.Show();
            this.Close();
        }
    }
}