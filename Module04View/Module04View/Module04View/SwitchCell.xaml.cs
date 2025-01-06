using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchCell : ContentPage
	{
        //Levels
        ObservableCollection<SuperMarioLevels> LevelsList = new ObservableCollection<SuperMarioLevels>();
        public ObservableCollection<SuperMarioLevels> SuperMarioLevels { get { return LevelsList; } }
        public SwitchCell ()
		{
			InitializeComponent ();

            Levels.ItemsSource = LevelsList;

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Palm Beach",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Yoshi Woods",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Springwater Swamp",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Growing Greenwood",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Timber Tower",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Fuzzy Canyon",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Rainshed Pond",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Tangle Temple",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Switch Shift Grove",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Creepcrack Castle",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Derelict Airship",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Autumn Plateau",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Appletree Woods",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Fall Harvest",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Goldbuzz Forest",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Leafpile Fortress",
            });

            SuperMarioLevels.Add(new SuperMarioLevels
            {
                LevelName = "Cactus Cove",
            });
        }

        private void DisplayMessage(object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = new SwitchCell();
            bool isToggledOn = e.Value;

            if (isToggledOn)
            {
                DisplayAlert("Completed",
                             "Congratulations, you have successfully finished this level!", "OK");
            }
            else
            {
                DisplayAlert("Failed", "You have failed this level, please try again.", "Ok");
            }
        }
    }
}