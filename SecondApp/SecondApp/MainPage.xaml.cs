using SecondApp.ViewModels;
using Xamarin.Forms;

namespace SecondApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

    }
}

