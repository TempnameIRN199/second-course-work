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
using System.Data.SqlClient;

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
            if (StudentPage.IsSelected)
            {
                if (StudentListView.SelectedItems != null)
                {
                    if (StudentListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Ну і що ти тут забув?");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            foreach (Student students in StudentListView.SelectedItems)
                            {
                                updStudent = db.Student.Find(students.Id);
                            }
                            if (updStudent == null)
                            {
                                MessageBox.Show("Не суй туди руки");
                                return;
                            }
                            else
                            {
                                EditWindow windowEdit = new EditWindow("StudentEdit", typeof(Student), updStudent);
                                windowEdit.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (SubjectPage.IsSelected)
            {
                if (SubjectListView.SelectedItems != null)
                {
                    if (SubjectListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Ну і що ти тут забув?");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            foreach (Subject subjects in SubjectListView.SelectedItems)
                            {
                                updSubject = db.Subject.Find(subjects.Id);
                            }
                            if (updSubject == null)
                            {
                                MessageBox.Show("Не суй туди руки");
                                return;
                            }
                            else
                            {
                                EditWindow windowEdit = new EditWindow("SubjectEdit", typeof(Subject), updStudent, updSubject);
                                windowEdit.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (TeacherPage.IsSelected)
            {
                if (TeacherListView.SelectedItems != null)
                {
                    if (TeacherListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Ну і що ти тут забув?");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            foreach (Teacher teachers in TeacherListView.SelectedItems)
                            {
                                updTeacher = db.Teacher.Find(teachers.Id);
                            }
                            if (updTeacher == null)
                            {
                                MessageBox.Show("Не суй туди руки");
                                return;
                            }
                            else
                            {
                                EditWindow windowEdit = new EditWindow("TeacherEdit", typeof(Teacher), updStudent, updSubject, updTeacher);
                                windowEdit.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (TypeSubjectPage.IsSelected)
            {
                if (TypeSubjectListView.SelectedItems != null)
                {
                    if (TypeSubjectListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Ну і що ти тут забув?");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            foreach (TypeSubject typeSubjects in TypeSubjectListView.SelectedItems)
                            {
                               updTypeSubject = db.TypeSubject.Find(typeSubjects.Id);
                            }
                            if (updTypeSubject == null)
                            {
                                MessageBox.Show("Не суй туди руки");
                                return;
                            }
                            else
                            {
                                EditWindow windowEdit = new EditWindow("TypeSubjectEdit", typeof(TypeSubject), updStudent, updSubject, updTeacher, updTypeSubject);
                                windowEdit.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (AttendancePage.IsSelected)
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
                            foreach (Attendance attendances in AttendanceListView.SelectedItems)
                            {
                                updAttendance = db.Attendance.Find(attendances.Id);
                            }
                            if (updAttendance == null)
                            {
                                MessageBox.Show("Не суй туди руки");
                                return;
                            }
                            else
                            {
                                EditWindow windowEdit = new EditWindow("AttendanceEdit", typeof(Attendance), updStudent, updSubject, updTeacher, updTypeSubject, updAttendance);
                                windowEdit.ShowDialog();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ну і що ти тут забув?");
            }
            Window_Loaded();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (StudentPage.IsSelected)
            {
                if (StudentListView.SelectedItems != null)
                {
                    if (StudentListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Виберіть для видалення");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            for (int i = 0; i < StudentListView.SelectedItems.Count; i++)
                            {
                                Student students = StudentListView.SelectedItems[i] as Student;
                                if (students != null)
                                {
                                    db.Student.Attach(students);
                                    try
                                    {
                                        db.Student.Remove(students);
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show($"Не можна видалити цей елемент, оскільки він пов'язаний із сутністю. ex: {ex}");
                                    }
                                    finally
                                    {
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (SubjectPage.IsSelected)
            {
                if (SubjectListView.SelectedItems != null)
                {
                    if (SubjectListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Виберіть для видалення");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            for (int i = 0; i < SubjectListView.SelectedItems.Count; i++)
                            {
                                Subject subjects = SubjectListView.SelectedItems[i] as Subject;
                                if (subjects != null)
                                {
                                    db.Subject.Attach(subjects);
                                    try
                                    {
                                        db.Subject.Remove(subjects);
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show($"Не можна видалити цей елемент, оскільки він пов'язаний із сутністю. ex: {ex}");
                                    }
                                    finally
                                    {
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (TeacherPage.IsSelected)
            {
                if (TeacherListView.SelectedItems != null)
                {
                    if (TeacherListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Виберіть для видалення");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            for (int i = 0; i < TeacherListView.SelectedItems.Count; i++)
                            {
                                Teacher teachers = TeacherListView.SelectedItems[i] as Teacher;
                                if (teachers != null)
                                {
                                    db.Teacher.Attach(teachers);
                                    try
                                    {
                                        db.Teacher.Remove(teachers);
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show($"Не можна видалити цей елемент, оскільки він пов'язаний із сутністю. ex: {ex}");
                                    }
                                    finally
                                    {
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (TypeSubjectPage.IsSelected)
            {
                if (TypeSubjectListView.SelectedItems != null)
                {
                    if (TypeSubjectListView.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Виберіть для видалення");
                        return;
                    }
                    else
                    {
                        using (NintendoContext db = new NintendoContext())
                        {
                            for (int i = 0; i < TypeSubjectListView.SelectedItems.Count; i++)
                            {
                                TypeSubject typeSubjects = TypeSubjectListView.SelectedItems[i] as TypeSubject;
                                if (typeSubjects != null)
                                {
                                    db.TypeSubject.Attach(typeSubjects);
                                    try
                                    {
                                        db.TypeSubject.Remove(typeSubjects);
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show($"Не можна видалити цей елемент, оскільки він пов'язаний із сутністю. ex: {ex}");
                                    }
                                    finally
                                    {
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (AttendancePage.IsSelected)
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
                            for (int i = 0; i < AttendanceListView.SelectedItems.Count; i++)
                            {
                                Attendance attendances = AttendanceListView.SelectedItems[i] as Attendance;
                                if (attendances != null)
                                {
                                    db.Attendance.Attach(attendances);
                                    try
                                    {
                                        db.Attendance.Remove(attendances);
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show($"Не можна видалити цей елемент, оскільки він пов'язаний із сутністю. ex: {ex}");
                                    }
                                    finally
                                    {
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Window_Loaded();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckWindow checkWindow = new CheckWindow();
            checkWindow.LoadDataIntoComboBoxes();
            checkWindow.Show();
            this.Close();
        }
    }
}
