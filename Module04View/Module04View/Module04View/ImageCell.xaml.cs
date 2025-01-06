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
    public partial class ImageCell : ContentPage
    {
        //Characters
        ObservableCollection<SuperMarioCharacters> CharactersList = new ObservableCollection<SuperMarioCharacters>();
        public ObservableCollection<SuperMarioCharacters> SuperMarioCharactersList { get { return CharactersList; } }

        public ImageCell()
        {
            InitializeComponent();

            Characters.ItemsSource = CharactersList;

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Mario",
                Role = "Protagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/a/a9/MarioNSMBUDeluxe.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Luigi",
                Role = "Protagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/7/73/Luigi_NSMBUDX.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Princess Peach",
                Role = "Protagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/1/16/Princess_Peach_Stock_Art.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Toad",
                Role = "Protagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/d/d1/Toad_3D_Land.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Yoshi",
                Role = "Protagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/d/db/Yoshi_%28Nintendo_character%29.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Pauline",
                Role = "Supporting",
                Image = "https://upload.wikimedia.org/wikipedia/en/2/28/Pauline_Super_Mario_Odyssey.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Birdo",
                Role = "Supporting",
                Image = "https://upload.wikimedia.org/wikipedia/en/f/f9/Birdo-MP9.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Princess Daisy",
                Role = "Supporting",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/Daisy_%28Super_Mario_Party%29.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Rosalina",
                Role = "Supporting",
                Image = "https://upload.wikimedia.org/wikipedia/en/6/6e/Rosalina_Super_Mario_Party.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Bowser",
                Role = "Antagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/9/92/Bowser_Stock_Art_2021.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Koopalings",
                Role = "Antagonist",
                Image = "https://static.tvtropes.org/pmwiki/pub/images/koopalings_nsmbu.png"
            });

            SuperMarioCharactersList.Add(new SuperMarioCharacters
            {
                CharacterName = "Wario",
                Role = "Antagonist",
                Image = "https://upload.wikimedia.org/wikipedia/en/8/81/Wario.png"
            });
        }
    }
}