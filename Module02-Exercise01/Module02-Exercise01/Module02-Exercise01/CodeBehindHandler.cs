using System;
using Xamarin.Forms;

namespace Module02_Exercise01
{
    public partial class CodeBehindHandler
    {
        private CodeBehindBinding _currentPage;

        public CodeBehindHandler(CodeBehindBinding currentPage)
        {
            _currentPage = currentPage;
        }

        public void ShowFormDataAlert(string name, int age, DateTime birthday)
        {
            _currentPage.DisplayAlert("Form Data", $"Name: {name}\n" +
                         $"Age: {age}\n" +
                         $"Birthday: {birthday.Date.ToString("yyyy-MM-dd")}",
                         "OK");
        }
    }
}
