using System.ComponentModel;
using System.Runtime.CompilerServices;
using SecondApp.Annotations;
using SecondApp.Models;

namespace SecondApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private PersonModel _personModel;


        public PersonModel PersonModel
        {
            get { return _personModel; }
            set
            {
                _personModel = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            PersonModel = new PersonModel
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