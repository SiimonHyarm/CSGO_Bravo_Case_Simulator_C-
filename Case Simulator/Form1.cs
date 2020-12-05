using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Weighted_Randomizer;
using System.Windows.Forms;


//will be using lists.
//each list will have a random choice.
//bla bla
namespace Case_Simulator
{

    public partial class Form1 : Form
    {
        Random rn = new Random();
        string rn_gun;
        Price pr = new Price();
        string quality;
        public Form1()
        {
            InitializeComponent();
            /*
             """ Prices in Euros 
             -------------------------
              Rarity     |      %    |
             -------------------------
             Mil-spec    |   79.92%  | <- blue 
             -------------------------
             Restricted  |   15.98%  | <- purple
             -------------------------
             Classified  |   3.2%    | <- pink
             -------------------------
             Covert      |   0.64%   | <- red
             -------------------------
             Knife/Glove |   0.26%   | <- gold
             -------------------------
             Stat- Track variant is 10% probability <- stat-track knife is 0.026%
             """
              */
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //We choose color randomly, based on probability
            IWeightedRandomizer<string> color_randomizer = new DynamicWeightedRandomizer<string>();
            color_randomizer.Add("Blue", 7992);
            color_randomizer.Add("Purple", 1598);
            color_randomizer.Add("Pink", 320);
            color_randomizer.Add("Red", 64);
            color_randomizer.Add("Gold", 26);
            string randomColor = color_randomizer.NextWithReplacement();

            //We choose the type of the weapon randomly based on probability
            IWeightedRandomizer<string> type_randomizer = new DynamicWeightedRandomizer<string>();
            type_randomizer.Add("Normal", 9);
            type_randomizer.Add("Stat-Track", 1);
            string randomType = type_randomizer.NextWithReplacement();

            //We choose the weapon randomly from blue guns
            List<string> blue_guns = new List<string>
            {
                "SG 553: Wave Spray",
                "Dual Berettas: Black Limba",
                "Nova: Tempest",
                "Galil AR: Shattered",
                "UMP-45: Bone Pile",
                "G3SG1: Demeter"
            };

            //We choose the weapon randomly from purple guns
            List<string> purple_guns = new List<string>
            {
                "USP-S: Overgrowth",
                "M4A4: Zirka",
                "MAC-10: Graven",
                "M4A1-S: Bright Water"
            };

            //We choose the weapon randomly from pink guns
            List<string> pink_guns = new List<string>
            {
                "P90: Emerald Dragon",
                "P2000: Ocean Foam",
                "AWP: Granite"
            };

            //We choose the weapon randomly from red guns
            List<string> red_guns = new List<string>
            {
                "AK-47: Fire Serpent",
                "Desert Eagle: Golden Koi"
            };

            //We choose the weapon randomly from gold guns
            List<string> gold_guns = new List<string>
            {
                "Gut Knife: safari mesh",
                "Gut Knife: Night",
                "Gut Knife: Forest DDpat",
                "Gut Knife: Boreal Forest",
                "Gut Knife: Scorched",
                "Gut Knife: Vanilla",
                "Flip Knife: Forest DDpat",
                "Flip Knife: Safari mesh",
                "Flip Knife: Boreal Forest",
                "Flip Knife: urban masked",
                "Flip Knife: Scorched",
                "Gut Knife: Crimson Web",
                "Gut Knife: Stained",
                "Flip Knife: Stained",
                "Gut Knife: Slaughter",
                "Flip Knife: Vanilla",
                "Gut Knife: Fade",
                "Flip Knife: Blue Steel",
                "Gut Knife: Blue Steel",
                "Bayonet: Urban Masked",
                "Bayonet: Safari Mesh",
                "Bayonet: Forest DDpat",
                "Bayonet: Boreal Forest",
                "Flip Knife: Case Hardened",
                "Flip Knife: Night",
                "M9 Bayonet: Forest DDpat",
                "Bayonet: Night",
                "M9 Bayonet: Scorched",
                "Bayonet: Stained",
                "M9 Bayonet: Boreal Forest",
                "M9 Bayonet: Urban Masked",
                "Bayonet: Blue Steel",
                "M9 Bayonet: Stained",
                "M9 Bayonet: Safari Mesh",
                "Karambit: Scorched",
                "M9 Bayonet: Night",
                "Karambit: Safari Mesh",
                "Karambit: Urban Masked",
                "Flip Knife: Slaughter",
                "Gut Knife: Urban Masked",
                "Karambit: Forest DDpat",
                "Karambit: Boreal Forest",
                "M9 Bayonet: Blue Steel",
                "Bayonet: Crimson Web",
                "Bayonet: Scorched",
                "Flip Knife: Crimson Web",
                "Bayonet: Case Hardened",
                "Karambit: Stained",
                "Bayonet: Vanilla",
                "Flip Knife: Fade",
                "Karambit: Blue Steel",
                "Bayonet: Slaughter",
                "M9 Bayonet: Vanilla",
                "Karambit: Night",
                "M9 Bayonet: Case Hardened",
                "M9 Bayonet: Crimson Web",
                "Karambit: Vanilla",
                "Karambit: Case Hardened",
                "M9 Bayonet: Slaughter",
                "Bayonet: Fade",
                "Karambit: Crimson Web",
                "Karambit: Slaughter",
                "M9 Bayonet: Fade",
                "Karambit: Fade"
            };



            //choose the random gun from the color
            if (randomColor == "Blue")
            {
                quality = "Mil-spec";
                rn_gun = blue_guns[rn.Next(blue_guns.Count)];
            }
            else if (randomColor == "Purple")
            {
                quality = "Restricted";
                rn_gun = purple_guns[rn.Next(purple_guns.Count)];
            }
            else if (randomColor == "Pink")
            {
                quality = "Classified";
                rn_gun = pink_guns[rn.Next(pink_guns.Count)];
            }
            else if (randomColor == "Red")
            {
                quality = "Covert";
                rn_gun = red_guns[rn.Next(red_guns.Count)];
            }
            else if (randomColor == "Gold")
            {
                quality = "Knife";
                rn_gun = gold_guns[rn.Next(gold_guns.Count)];
            }

            Dictionary<string, double> pricey = pr.price(rn_gun, randomType);
            foreach (var x in pricey)
                Console.WriteLine("Quality: {0}, Gun: {1}, Wear: {2}, Type: {3}, Price: {4}",quality,rn_gun, x.Key, randomType, x.Value);
        }
    }
}
