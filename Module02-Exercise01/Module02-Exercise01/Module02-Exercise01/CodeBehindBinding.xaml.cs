using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module02_Exercise01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeBehindBinding : ContentPage
    {
        private CodeBehindHandler _codeBehindHandler;

        public CodeBehindBinding()
        {
            InitializeComponent();
            _codeBehindHandler = new CodeBehindHandler(this);
        }
        
        void OnAgeSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            int value = (int)args.NewValue;
            AgeLabel.Text = String.Format("{0} years old.", value);
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            int age = (int)AgeSlider.Value;
            DateTime birthday = BirthdayDatePicker.Date;

            _codeBehindHandler.ShowFormDataAlert(name, age, birthday);
        }
    }
}   