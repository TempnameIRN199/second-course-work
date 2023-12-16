using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherClass
{
    public class AttendanceViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AttendanceItem> _attendance = new ObservableCollection<AttendanceItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AttendanceItem> Attendance
        {
            get { return _attendance; }
            set
            {
                _attendance = value;
                OnPropertyChanged("Attendance");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class AttendanceItem
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string Skip11 { get; set; }
    }
}
