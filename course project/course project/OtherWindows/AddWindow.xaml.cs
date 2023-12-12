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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow(string title)
        {
            InitializeComponent();
            LoadedGrid(title);
        }

        private void LoadedGrid(string title)
        {
            if (title == "StudentAdd")
            {
                this.Title = "Додати студента";

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
            }
            else if (title == "SubjectAdd")
            {
                this.Title = "Додати предмет";

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
            }
            else if (title == "TeacherAdd")
            {
                this.Title = "Додати викладача";

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
            }
            else if (title == "TypeSubjectAdd")
            {
                this.Title = "Додати тип предмету";

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
            }
            else if (title == "AttendanceAdd")
            {
                this.Title = "Додати відвідування";

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
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (NintendoContext db = new NintendoContext())
            {
                if (this.Title == "Додати студента")
                {
                    Student student = new Student();
                    student.Surname = grid.Children.OfType<TextBox>().First().Text;
                    student.Name = grid.Children.OfType<TextBox>().ElementAt(1).Text;
                    student.RBNumber = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(2).Text);

                    db.Student.Add(student);
                    db.SaveChanges();
                    MessageBox.Show("Дані збережено");
                    this.Close();
                }
                else if (this.Title == "Додати предмет")
                {
                    Subject subject = new Subject();
                    subject.Name = grid.Children.OfType<TextBox>().First().Text;
                    subject.Semester = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(1).Text);
                    subject.TotalHours = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(2).Text);

                    db.Subject.Add(subject);
                    db.SaveChanges();
                    MessageBox.Show("Дані збережено");
                    this.Close();
                }
                else if (this.Title == "Додати викладача")
                {
                    Teacher teacher = new Teacher();
                    teacher.Surname = grid.Children.OfType<TextBox>().First().Text;
                    teacher.Name = grid.Children.OfType<TextBox>().ElementAt(1).Text;

                    db.Teacher.Add(teacher);
                    db.SaveChanges();
                    MessageBox.Show("Дані збережено");
                    this.Close();
                }
                else if (this.Title == "Додати тип предмету")
                {
                    TypeSubject typeSubject = new TypeSubject();
                    typeSubject.SubjectId = Convert.ToInt32(grid.Children.OfType<TextBox>().First().Text);
                    typeSubject.TeacherId = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(1).Text);
                    typeSubject.Type = (DB.EnumType)grid.Children.OfType<ComboBox>().First().SelectedItem;
                    typeSubject.Hours = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(2).Text);

                    db.TypeSubject.Add(typeSubject);
                    db.SaveChanges();
                    MessageBox.Show("Дані збережено");
                    this.Close();
                }
                else if (this.Title == "Додати відвідування")
                {
                    Attendance attendance = new Attendance();
                    attendance.TypeSubjectId = Convert.ToInt32(grid.Children.OfType<TextBox>().First().Text);
                    attendance.StudentId = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(1).Text);
                    attendance.Skip = (DB.EnumSkip)grid.Children.OfType<ComboBox>().First().SelectedItem;
                    attendance.Date = Convert.ToDateTime(grid.Children.OfType<DatePicker>().First().Text);
                    attendance.NumberLesson = Convert.ToInt32(grid.Children.OfType<TextBox>().ElementAt(2).Text);

                    db.Attendance.Add(attendance);
                    db.SaveChanges();
                    MessageBox.Show("Дані збережено");
                    this.Close();
                }
            }

        }
    }
}
