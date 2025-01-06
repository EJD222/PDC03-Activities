using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCell : ContentPage
    {
        //Arcade Games
        ObservableCollection<SuperMarioArcadeGameName> superMarioArcadeGamesList = new ObservableCollection<SuperMarioArcadeGameName>();
        public ObservableCollection<SuperMarioArcadeGameName> SuperMarioArcadeGames { get { return superMarioArcadeGamesList; } }

        //Nintendo Games
        ObservableCollection<SuperMarioNintendoGameName> superMarioNintendoGamesList = new ObservableCollection<SuperMarioNintendoGameName>();
        public ObservableCollection<SuperMarioNintendoGameName> SuperMarioNintendoGames { get { return superMarioNintendoGamesList; } }

        //WII Games
        ObservableCollection<SuperMarioWIIGameName> superMarioWIIGamesList = new ObservableCollection<SuperMarioWIIGameName>();
        public ObservableCollection<SuperMarioWIIGameName> SuperMarioWIIGames { get { return superMarioWIIGamesList; } }

        public TextCell()
        {
            InitializeComponent();

            //Arcade Games List

            ArcadeGames.ItemsSource = superMarioArcadeGamesList;

            SuperMarioArcadeGames.Add(new SuperMarioArcadeGameName
            { 
                GameName = "Donkey Kong", 
                Year = "1981" 
            });

            SuperMarioArcadeGames.Add(new SuperMarioArcadeGameName
            {
                GameName = "Mario's Cement Factory",
                Year = "1983"
            });

            SuperMarioArcadeGames.Add(new SuperMarioArcadeGameName
            {
                GameName = "Vs. Super Mario Bros.",
                Year = "1986"
            });

            SuperMarioArcadeGames.Add(new SuperMarioArcadeGameName
            {
                GameName = "Mario Kart Arcade GP", 
                Year = "2005" 
            });

            SuperMarioArcadeGames.Add(new SuperMarioArcadeGameName
            {
                GameName = "Luigi's Mansion Arcade",
                Year = "2015"
            });

            //Nintendo Games List

            NintendoGames.ItemsSource = superMarioNintendoGamesList;

            SuperMarioNintendoGames.Add(new SuperMarioNintendoGameName
            {
                GameName = "Yoshi's Island DS",
                Year = "2006"
            });

            SuperMarioNintendoGames.Add(new SuperMarioNintendoGameName
            {
                GameName = "Mario & Sonic at the Olympic Games",
                Year = "2008"
            });

            SuperMarioNintendoGames.Add(new SuperMarioNintendoGameName
            {
                GameName = "Mario vs. Donkey Kong: Mini-Land Mayhem",
                Year = "2010"
            });

            SuperMarioNintendoGames.Add(new SuperMarioNintendoGameName
            {
                GameName = "Luigi's Mansion",
                Year = "2018"
            });

            //Wii Games List

            WIIGames.ItemsSource = superMarioWIIGamesList;

            SuperMarioWIIGames.Add(new SuperMarioWIIGameName
            {
                GameName = "Dr. Mario Online Rx",
                Year = "2008"
            });

            SuperMarioWIIGames.Add(new SuperMarioWIIGameName
            {
                GameName = "Mario Sports Mix",
                Year = "2010"
            });

            SuperMarioWIIGames.Add(new SuperMarioWIIGameName
            {
                GameName = "Super Smash Bros. for Wii U",
                Year = "2014"
            });

            SuperMarioWIIGames.Add(new SuperMarioWIIGameName
            {
                GameName = "Paper Mario",
                Year = "2016"
            });

        }
        private void MenuDelete(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "You pressed delete.", "OK");
        }

        private void MenuMore(object sender, EventArgs e)
        {
            DisplayAlert("More", "You pressed more.", "OK");
        }

    }
}
