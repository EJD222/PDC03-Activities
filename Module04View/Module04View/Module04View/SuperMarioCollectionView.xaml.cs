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
    public partial class SuperMarioCollectionView : ContentPage
    {
        public IList<SuperMarioPowerUps> PowerUps { get; private set; }

        public SuperMarioCollectionView()
        {
            InitializeComponent();

            PowerUps = new List<SuperMarioPowerUps>();

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Super Mushroom",
                Effect = "Mario increases in height, turning him into Super Mario.",
                Image = "https://static.wikia.nocookie.net/mario/images/9/94/MushroomMarioKart8.png/revision/latest/scale-to-width-down/1000?cb=20190428183737"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Fire Flower",
                Effect = "Mario turns into Fire Mario, allowing him to throw bouncing fireballs from his hands.",
                Image = "https://static.wikia.nocookie.net/mario/images/2/24/NSMBUD_Fire_Flower.png/revision/latest/scale-to-width-down/1000?cb=20190730173640"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Starman",
                Effect = "Mario turns into Star Mario, making him invulnerable to nearly everything.",
                Image = "https://static.wikia.nocookie.net/mario/images/1/17/Star3dworld.png/revision/latest?cb=20131129223338"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Cape Feather",
                Effect = "Mario turns into Cape Mario, gaining him a cool yellow cape and the ability to take to the skies.",
                Image = "https://static.wikia.nocookie.net/mario/images/5/5b/Feather_MK8D.png/revision/latest/scale-to-width-down/1000?cb=20190718013241"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Super Leaf",
                Effect = "Mario turns into Raccoon Mario, allowing him to use his tail to hit enemies. ",
                Image = "https://static.wikia.nocookie.net/mario/images/9/96/SM3DW_Super_Leaf.png/revision/latest?cb=20131129221714"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Mega Mushroom",
                Effect = "Mario turns into Mega Mario, allowing him to wreak havoc through the level by breaking bricks, pipes and even Flagpoles.",
                Image = "https://static.wikia.nocookie.net/mario/images/b/bf/Mega_Mushroom_MTUS.png/revision/latest?cb=20230512193311"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Blue Shell",
                Effect = "Mario turns into Shell Mario, giving him a blue shell which allows him to use new abilities.",
                Image = "https://static.wikia.nocookie.net/mario/images/1/1b/ShellNSMB.png/revision/latest/scale-to-width-down/1000?cb=20170814212225"
            });

            PowerUps.Add(new SuperMarioPowerUps
            {
                PowerUpName = "Blue Shell",
                Effect = "Mario turns into Ice Mario, gaining him the ability to skate on bodies of water.",
                Image = "https://static.wikia.nocookie.net/mario/images/0/07/NSMBUD_Ice_Flower.png/revision/latest/scale-to-width-down/1000?cb=20190730173715"
            });

            BindingContext = this;
        }
    }
}