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

namespace course_project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Student updStudent1 = new Student();
        Subject updSubject1 = new Subject();
        Teacher updTeacher1 = new Teacher();
        TypeSubject updTypeSubject1 = new TypeSubject();
        Attendance updAttendance1 = new Attendance();

        public EditWindow(string title, Type type, Student updStundet = null, Subject updSubject = null, Teacher updTeacher = null, TypeSubject updTypeSubject = null, Attendance updAttendance = null)
        {
            InitializeComponent();
            if (type == typeof(Student) && updStundet != null)
            {
                updStudent1 = updStundet;
                LoadedGrid(title, type);
            }
            else if (type == typeof(Subject) && updSubject != null)
            {
                updSubject1 = updSubject;
                LoadedGrid(title, type);
            }
            else if (type == typeof(Teacher) && updTeacher != null)
            {
                updTeacher1 = updTeacher;
                LoadedGrid(title, type);
            }
            else if (type == typeof(TypeSubject) && updTypeSubject != null)
            {
                updTypeSubject1 = updTypeSubject;
                LoadedGrid(title, type);
            }
            else if (type == typeof(Attendance) && updAttendance != null)
            {
                updAttendance1 = updAttendance;
                LoadedGrid(title, type);
            }
        }

        private void LoadedGrid(string title, Type type)
        {
            if (title == "StudentEdit" && type == typeof(Student))
            {
                this.Title = "Редагування студента";

                Label label = new Label();
                label.Content = "Surname: ";
                label.Margin = new Thickness(10);
                Grid.SetRow(label, 0);

                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(10, 10, -40, 10);
                textBox.Width = 200;
                Grid.SetRow(textBox, 0);

                Label label1 = new Label();
                label1.Content = "Name: ";
                label1.Margin = new Thickness(10);
                Grid.SetRow(label1, 1);

                TextBox textBox1 = new TextBox();
                textBox1.Margin = new Thickness(10, 10, -40, 10);
                textBox1.Width = 200;
                Grid.SetRow(textBox1, 1);

                Label label2 = new Label();
                label2.Content = "RBNumber: ";
                label2.Margin = new Thickness(10);
                Grid.SetRow(label2, 2);

                TextBox textBox2 = new TextBox();
                textBox2.Margin = new Thickness(10, 10, -40, 10);
                textBox2.Width = 200;
                Grid.SetRow(textBox2, 2);

                grid.Children.Add(label);
                grid.Children.Add(textBox);
                grid.Children.Add(label1);
                grid.Children.Add(textBox1);
                grid.Children.Add(label2);
                grid.Children.Add(textBox2);

                textBox.Text = updStudent1.Surname;
                textBox1.Text = updStudent1.Name;
                textBox2.Text = updStudent1.RBNumber.ToString();
            }
            else if (title == "SubjectEdit" && type == typeof(Subject))
            {
                this.Title = "Редагування предмета";

                Label label = new Label();
                label.Content = "Name: ";
                label.Margin = new Thickness(10);
                Grid.SetRow(label, 0);

                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(10, 10, -40, 10);
                textBox.Width = 200;
                Grid.SetRow(textBox, 0);

                Label label1 = new Label();
                label1.Content = "Semester: ";
                label1.Margin = new Thickness(10);
                Grid.SetRow(label1, 1);

                TextBox textBox1 = new TextBox();
                textBox1.Margin = new Thickness(10, 10, -40, 10);
                textBox1.Width = 200;
                Grid.SetRow(textBox1, 1);

                Label label2 = new Label();
                label2.Content = "TotalHours: ";
                label2.Margin = new Thickness(10);
                Grid.SetRow(label2, 2);

                TextBox textBox2 = new TextBox();
                textBox2.Margin = new Thickness(10, 10, -40, 10);
                textBox2.Width = 200;
                Grid.SetRow(textBox2, 2);

                grid.Children.Add(label);
                grid.Children.Add(textBox);
                grid.Children.Add(label1);
                grid.Children.Add(textBox1);
                grid.Children.Add(label2);
                grid.Children.Add(textBox2);

                textBox.Text = updSubject1.Name;
                textBox1.Text = updSubject1.Semester.ToString();
                textBox2.Text = updSubject1.TotalHours.ToString();
            }
            else if (title == "TeacherEdit" && type == typeof(Teacher))
            {
                this.Title = "Редагування викладача";

                Label label = new Label();
                label.Content = "Surname: ";
                label.Margin = new Thickness(10);
                Grid.SetRow(label, 0);

                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(10, 10, -40, 10);
                textBox.Width = 200;
                Grid.SetRow(textBox, 0);

                Label label1 = new Label();
                label1.Content = "Name: ";
                label1.Margin = new Thickness(10);
                Grid.SetRow(label1, 1);

                TextBox textBox1 = new TextBox();
                textBox1.Margin = new Thickness(10, 10, -40, 10);
                textBox1.Width = 200;
                Grid.SetRow(textBox1, 1);

                grid.Children.Add(label);
                grid.Children.Add(textBox);
                grid.Children.Add(label1);
                grid.Children.Add(textBox1);

                textBox.Text = updTeacher1.Surname;
                textBox1.Text = updTeacher1.Name;
            }
            else if (title == "TypeSubjectEdit" && type == typeof(TypeSubject))
            {
                this.Title = "Редагування типу предмета";

                Label label = new Label();
                label.Content = "SubjectId: ";
                label.Margin = new Thickness(10);
                Grid.SetRow(label, 0);

                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(10, 10, -40, 10);
                textBox.Width = 200;
                Grid.SetRow(textBox, 0);

                Label label1 = new Label();
                label1.Content = "TeacherId: ";
                label1.Margin = new Thickness(10);
                Grid.SetRow(label1, 1);

                TextBox textBox1 = new TextBox();
                textBox1.Margin = new Thickness(10, 10, -40, 10);
                textBox1.Width = 200;
                Grid.SetRow(textBox1, 1);

                Label label2 = new Label();
                label2.Content = "Type: ";
                label2.Margin = new Thickness(10);
                Grid.SetRow(label2, 2);

                ComboBox comboBox = new ComboBox();
                comboBox.Margin = new Thickness(10, 10, -40, 10);
                comboBox.Width = 200;
                Grid.SetRow(comboBox, 2);

                Label label3 = new Label();
                label3.Content = "Hours: ";
                label3.Margin = new Thickness(10);
                Grid.SetRow(label3, 3);

                TextBox textBox3 = new TextBox();
                textBox3.Margin = new Thickness(10, 10, -40, 10);
                textBox3.Width = 200;
                Grid.SetRow(textBox3, 3);

                grid.Children.Add(label);
                grid.Children.Add(textBox);
                grid.Children.Add(label1);
                grid.Children.Add(textBox1);
                grid.Children.Add(label2);
                grid.Children.Add(comboBox);
                grid.Children.Add(label3);
                grid.Children.Add(textBox3);

                foreach (var item in Enum.GetValues(typeof(DB.EnumType)))
                {
                    comboBox.Items.Add(item);
                }

                textBox.Text = updTypeSubject1.SubjectId.ToString();
                textBox1.Text = updTypeSubject1.TeacherId.ToString();
                comboBox.SelectedItem = updTypeSubject1.Type;
                textBox3.Text = updTypeSubject1.Hours.ToString();
            }
            else if (title == "AttendanceEdit" && type == typeof(Attendance))
            {
                this.Title = "Редагування відвідування";

                Label label = new Label();
                label.Content = "TypeSubjectId: ";
                label.Margin = new Thickness(10);
                Grid.SetRow(label, 0);

                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(10, 10, -40, 10);
                textBox.Width = 200;
                Grid.SetRow(textBox, 0);

                Label label1 = new Label();
                label1.Content = "StudentId: ";
                label1.Margin = new Thickness(10);
                Grid.SetRow(label1, 1);

                TextBox textBox1 = new TextBox();
                textBox1.Margin = new Thickness(10, 10, -40, 10);
                textBox1.Width = 200;
                Grid.SetRow(textBox1, 1);

                Label label2 = new Label();
                label2.Content = "Skip: ";
                label2.Margin = new Thickness(10);
                Grid.SetRow(label2, 2);

                ComboBox comboBox = new ComboBox();
                comboBox.Margin = new Thickness(10, 10, -40, 10);
                comboBox.Width = 200;
                Grid.SetRow(comboBox, 2);

                Label label3 = new Label();
                label3.Content = "Date: ";
                label3.Margin = new Thickness(10);
                Grid.SetRow(label3, 3);

                DatePicker datePicker = new DatePicker();
                datePicker.Margin = new Thickness(10, 10, -40, 10);
                datePicker.Width = 200;
                Grid.SetRow(datePicker, 3);

                Label label4 = new Label();
                label4.Content = "NumberLesson: ";
                label4.Margin = new Thickness(10);
                Grid.SetRow(label4, 4);

                TextBox textBox4 = new TextBox();
                textBox4.Margin = new Thickness(10, 10, -40, 10);
                textBox4.Width = 200;
                Grid.SetRow(textBox4, 4);

                grid.Children.Add(label);
                grid.Children.Add(textBox);
                grid.Children.Add(label1);
                grid.Children.Add(textBox1);
                grid.Children.Add(label2);
                grid.Children.Add(comboBox);
                grid.Children.Add(label3);
                grid.Children.Add(datePicker);
                grid.Children.Add(label4);
                grid.Children.Add(textBox4);

                foreach (var item in Enum.GetValues(typeof(DB.EnumSkip)))
                {
                    comboBox.Items.Add(item);
                }

                textBox.Text = updAttendance1.TypeSubjectId.ToString();
                textBox1.Text = updAttendance1.StudentId.ToString();
                comboBox.SelectedItem = updAttendance1.Skip;
                datePicker.SelectedDate = updAttendance1.Date;
                textBox4.Text = updAttendance1.NumberLesson.ToString();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (NintendoContext db = new NintendoContext())
            {
                if (this.Title == "Редагування студента")
                {
                    updStudent1.Surname = ((TextBox)grid.Children[2]).Text;
                    updStudent1.Name = ((TextBox)grid.Children[4]).Text;
                    updStudent1.RBNumber = Convert.ToInt32(((TextBox)grid.Children[6]).Text);

                    var student = db.Student.Where(x => x.Id == updStudent1.Id).FirstOrDefault();
                    student.Surname = updStudent1.Surname;
                    student.Name = updStudent1.Name;
                    student.RBNumber = updStudent1.RBNumber;

                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Дані успішно оновлені!");
                    this.Close();
                }
                else if (this.Title == "Редагування предмета")
                {
                }
                else if (this.Title == "Редагування викладача")
                {
                }
                else if (this.Title == "Редагування типу предмета")
                {
                }
                else if (this.Title == "Редагування відвідування")
                {
                }
            }
        }
    }
}
