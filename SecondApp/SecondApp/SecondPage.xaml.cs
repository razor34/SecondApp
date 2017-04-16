
using SecondApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
