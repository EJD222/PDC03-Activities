using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        private int _age;
        public PersonalInfoPage()
        {
            InitializeComponent();

        }

        private void OnMiddleNameSwitchToggled(object sender, ToggledEventArgs e)
        {
            MiddleNameSwitch.IsEnabled = e.Value;
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime Birthdate = e.NewDate;
            DateTime DateToday = DateTime.Today;
            int age = DateToday.Year - Birthdate.Year;
            if (Birthdate > DateToday.AddYears(-age))
                age--;

            AgeInitialLabel.IsVisible = false;
            AgeDynamicLabel.IsVisible = true;
            AgeDynamicLabel.Text = $"Age: {age}";
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {

        }
    }
}