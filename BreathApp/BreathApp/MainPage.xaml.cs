using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BreathApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LearnMore());
        }

        private async void Button_FunctionCheck(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FunctionCheck());
        }
    }
}
