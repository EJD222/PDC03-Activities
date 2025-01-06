using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module03Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnStackLayoutPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }
        private async void OnAbsoluteLayoutPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
        private async void OnRelativeLayoutPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }
        private async void OnGridPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
    }
}
