﻿using System;
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
using course_project.DB;

namespace course_project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        //Student updStudent1 = new Student();
        //Subject updSubject1 = new Subject();
        //Teacher updTeacher1 = new Teacher();
        //TypeSubject updTypeSubject1 = new TypeSubject();
        //Attendance updAttendance1 = new Attendance();

        public CheckWindow()
        {
            InitializeComponent();
        }

        public void LoadDataIntoComboBoxes()
        {
            using (NintendoContext db = new NintendoContext())
            {
                var teachers = db.Teacher.ToList();
                TeacherComboBox.ItemsSource = teachers.Select(teacher => teacher.Name).ToList();

                var subjects = db.Subject.ToList();
                SubjectComboBox.ItemsSource = subjects.Select(subject => subject.Name).ToList();

                TeacherComboBox.SelectedIndex = 0;
                SubjectComboBox.SelectedIndex = 0;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (NintendoContext db = new NintendoContext())
            {
                // взять из ComboBox выбранные значения и передать их в ProcessWindow
                var teacherName = TeacherComboBox.SelectedItem.ToString();
                var subjectName = SubjectComboBox.SelectedItem.ToString();

                var teacher = db.Teacher.FirstOrDefault(t => t.Name == teacherName);
                var subject = db.Subject.FirstOrDefault(s => s.Name == subjectName);

                var typeSubject = db.TypeSubject.FirstOrDefault(ts => ts.TeacherId == teacher.Id && ts.SubjectId == subject.Id);

                var processWindow = new ProcessWindow(null, subject, teacher, null, null);

                processWindow.Show();

                this.Close();
            }
        }
    }
}
