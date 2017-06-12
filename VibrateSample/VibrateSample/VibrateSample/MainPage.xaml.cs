using Plugin.Vibrate;
using System;
using Xamarin.Forms;

namespace VibrateSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            var v = CrossVibrate.Current;
            v.Vibration(100);
            await System.Threading.Tasks.Task.Delay(100);
            v.Vibration(200);
        }
    }
}
