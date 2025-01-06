using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var BackgroundURL = "https://images.hdqwalls.com/download/the-super-mario-bros-5k-0i-1440x2960.jpg";
            SuperMarioBackground.Source = ImageSource.FromUri(new Uri(BackgroundURL));

            var LogoURL = "https://seeklogo.com/images/S/super-mario-logo-A8E04F3EC2-seeklogo.com.png";
            SuperMarioLogo.Source = ImageSource.FromUri(new Uri(LogoURL));
        }
        private async void OnTextCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCell());
        }
        private async void OnImageCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCell());
        }
        private async void OnSwitchCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCell());
        }
        private async void OnEntryCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCell());
        }
        private async void OnCollectionViewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SuperMarioCollectionView());
        }
        private async void OnExitButtonClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Exit", "Are you sure you want to exit?", "Yes", "No");
            if (answer)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
