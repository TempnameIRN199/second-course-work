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
using System.Windows.Navigation;
using System.Windows.Shapes;
using course_project.DB;
using course_project.OtherWindows;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using course_project.MainWindows;

namespace course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Diagnostics.Process.GetCurrentProcess().MaxWorkingSet = new IntPtr(1024 * 1024 * 1024);
            using (NintendoContext db = new NintendoContext())
            {
                db.Student.Load();
                db.Teacher.Load();
                db.Subject.Load();
                db.TypeSubject.Load();
                db.Attendance.Load();
            }

            // еще больше ускорить загрузку данных
            using (NintendoContext db = new NintendoContext())
            {
                db.Configuration.AutoDetectChangesEnabled = false; // отключаем отслеживание изменений
                db.Configuration.ValidateOnSaveEnabled = false; // отключаем валидацию при сохранении
                db.Configuration.LazyLoadingEnabled = false; // отключаем ленивую загрузку
                db.Configuration.ProxyCreationEnabled = false; // отключаем создание прокси-объектов
                db.Configuration.UseDatabaseNullSemantics = false; // отключаем использование базовой семантики null
                db.Configuration.EnsureTransactionsForFunctionsAndCommands = false; // отключаем транзакции для команд и функций
                db.Configuration.UseDatabaseNullSemantics = false; // отключаем использование базовой семантики null
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (button.Content.ToString() == "Звичайна")
            {
                MainWindow1 mainWindow1 = new MainWindow1();
                mainWindow1.Show();
                this.Close();
            }
            else
            {
                //MainWindow2 mainWindow2 = new MainWindow2();
                //mainWindow2.Show();
                //this.Close();
            }
        }
    }
}
