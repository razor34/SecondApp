using System.ComponentModel;
using System.Runtime.CompilerServices;
using SecondApp.Annotations;
using SecondApp.Models;
using Xamarin.Forms;

namespace SecondApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private PersonModel _personModel;
        private string _personInfo;


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

        public string PersonInfo        
        {
            get { return _personInfo; }
            set
            {
                _personInfo = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    PersonInfo = "Name is: " + PersonModel.Name + " , Age is: " + PersonModel.Age;


                });
            }
            
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }

}