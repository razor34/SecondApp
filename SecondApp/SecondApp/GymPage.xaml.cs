using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GymPage : ContentPage
    {
        public GymPage()
        {
            InitializeComponent();


            GymView.ItemsSource = new List<Gym>
            {
                new Gym {Name = "Xtreme Fitness", Number = "33752"},
                new Gym {Name = "Olympus", Number = "19238"},
                new Gym {Name = "Sparta", Number = "34368"}

            };

        }
    }
}
