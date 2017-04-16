using System.ComponentModel;
using System.Runtime.CompilerServices;
using SecondApp.Annotations;
using SecondApp.Models;

namespace SecondApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private TaskModel _taskModel;


        public TaskModel TaskModel
        {
            get { return _taskModel; }
            set
            {
                _taskModel = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            TaskModel = new TaskModel
            {
                Name = "Damian",
                Age = 24
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }

}