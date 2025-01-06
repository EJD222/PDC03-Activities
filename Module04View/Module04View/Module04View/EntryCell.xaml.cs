using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCell : ContentPage
    {
        public EntryCell()
        {
            InitializeComponent();
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string Answer1 = Q1.Text;
            string Answer2 = Q2.Text;
            string Answer3 = Q3.Text;
            string Answer4 = Q4.Text;
            string Answer5 = Q5.Text;
            string Answer6 = Q6.Text;
            string Answer7 = Q7.Text;
            string Answer8 = Q8.Text;
            string Answer9 = Q9.Text;
            string Answer10 = Q10.Text;
            DisplayAlert("Entered Values", $"Answer 1: {Answer1}\n" +
                         $"Answer 2: {Answer2}\n" +
                         $"Answer 3: {Answer3}\n" +
                         $"Answer 4: {Answer4}\n" +
                         $"Answer 5: {Answer5}\n" +
                         $"Answer 6: {Answer6}\n" +
                         $"Answer 7: {Answer7}\n" +
                         $"Answer 8: {Answer8}\n" +
                         $"Answer 9: {Answer9}\n" +
                         $"Answer 10: {Answer10}\n\n" +
                         "Are you sure you want to submit?",
                         "Ok", "Cancel");
        }
    }
}