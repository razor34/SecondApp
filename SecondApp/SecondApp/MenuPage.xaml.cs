using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new MainPage());


        }


        private void ChooseGymButton_OnClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GymPage());
            IsPresented = false;
        }
    }
}
