using Microsoft.AspNetCore.Mvc.ViewFeatures;
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
using OtherClass;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;
using course_project.MainWindows;

namespace course_project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для ConvertWindow.xaml
    /// </summary>
    public partial class ConvertWindow : Window
    {
        public List<AttendanceItem> Attendance { get; set; }

        public ConvertWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            AttendanceListView.ItemsSource = null;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string selectedFilePath = openFileDialog.FileName;

                if (System.IO.Path.GetExtension(selectedFilePath).Equals(".json", System.StringComparison.OrdinalIgnoreCase))
                {
                    string jsonContent = File.ReadAllText(selectedFilePath);
                    Attendance = JsonConvert.DeserializeObject<List<AttendanceItem>>(jsonContent);
                    AttendanceListView.ItemsSource = Attendance;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не является файлом формата JSON.");
                }
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
