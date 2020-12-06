using System;
using System.Collections.Generic;
using System.Drawing;
using Weighted_Randomizer;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data;

namespace Case_Simulator
{

    public partial class Form1 : Form
    {
        int opened = 0;
        double profit = 0;
        double case_price = 29.62; //29.62
        double key_price = 2.49; //2.49
        double loss = 0;
        double full_price;
        double percent;
        double earned;
        int knives = 0;
        int blue_am = 0;
        int purple_am = 0;
        int pink_am = 0;
        int red_am = 0;
        int gold_am = 0;
        int blue_s = 0;
        int purple_s = 0;
        int pink_s = 0;
        int red_s = 0;
        int gold_s = 0;
        string quality;
        int musical = 0;
        Random rn = new Random();
        string rn_gun;
        Price pr = new Price();
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\User\source\repos\Case Simulator\Case Simulator\db.db");
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

            read_from_db();
            music();
            clear_labels();
            full_price = case_price + key_price;
            total_opened.Text = opened.ToString();
            profit_percentage.Text = percent.ToString() + "%";
            spent_amount.Text = loss.ToString();
            earned_amount.Text = earned.ToString();
            label33.Text = blue_am.ToString();
            label34.Text = purple_am.ToString();
            label35.Text = pink_am.ToString();
            label36.Text = red_am.ToString();
            label37.Text = gold_am.ToString();
            label38.Text = blue_s.ToString();
            label39.Text = purple_s.ToString();
            label40.Text = pink_s.ToString();
            label41.Text = red_s.ToString();
            label42.Text = gold_s.ToString();

        }
        public void read_from_db()
        {
            //read from database and fill
            string query = "SELECT* from numbers";
            string query2 = "SELECT* from received";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            adapter.Fill(dt);
            adapter2.Fill(dt2);

            //get all the numeric values from the db
            opened = Convert.ToInt32(dt.Rows[0]["spent"]);
            profit = Convert.ToDouble(dt.Rows[0]["percentage"]);
            earned = Convert.ToDouble(dt.Rows[0]["earned"]);
            loss = Convert.ToDouble(dt.Rows[0]["spent"]);
            blue_am = Convert.ToInt32(dt.Rows[0]["items_blue"]);
            purple_am = Convert.ToInt32(dt.Rows[0]["items_purple"]);
            pink_am = Convert.ToInt32(dt.Rows[0]["items_pink"]);
            red_am = Convert.ToInt32(dt.Rows[0]["items_red"]);
            gold_am = Convert.ToInt32(dt.Rows[0]["items_gold"]);
            blue_s = Convert.ToInt32(dt.Rows[0]["blue_s"]);
            purple_s = Convert.ToInt32(dt.Rows[0]["purple_s"]);
            pink_s = Convert.ToInt32(dt.Rows[0]["pink_s"]);
            red_s = Convert.ToInt32(dt.Rows[0]["red_s"]);
            gold_s = Convert.ToInt32(dt.Rows[0]["gold_s"]);

            for (int index = 0; index < dt2.Rows.Count; index++)
            {
                //get with the background color
                listView1.Items.Insert(0, dt2.Rows[index]["gun"].ToString());
                if (dt2.Rows[index]["back_color"].ToString() == "Blue")
                {
                    listView1.Items[0].BackColor = Color.Blue;
                } else if (dt2.Rows[index]["back_color"].ToString() == "Purple")
                {
                    listView1.Items[0].BackColor = Color.Purple;
                }
                else if (dt2.Rows[index]["back_color"].ToString() == "Pink")
                {
                    listView1.Items[0].BackColor = Color.Pink;
                }
                else if (dt2.Rows[index]["back_color"].ToString() == "Red")
                {
                    listView1.Items[0].BackColor = Color.Red;
                }
                else if (dt2.Rows[index]["back_color"].ToString() == "Gold")
                {
                    listView1.Items[0].BackColor = Color.Gold;
                }

                //get with font color
                if (dt2.Rows[index]["fore_color"].ToString() == "Orange")
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                } else
                {
                    listView1.Items[0].ForeColor = Color.White;
                }
            }
        }
        public void write_to_db()
        {

            //write to database all the guns that are opened one by one
            
            string populate_received = "INSERT INTO received (gun, back_color, fore_color) values (@gun, @back, @fore)";
            string empty_numbers = "DELETE FROM numbers";
            string populate_numbers = "INSERT INTO numbers(spent, earned, percentage, opened, items_blue, items_purple, items_pink, items_red, items_gold, blue_s, purple_s, pink_s, red_s, gold_s) values(@spent, @earned, @percentage, @opened, @items_blue, @items_purple, @items_pink, @items_red, @items_gold, @blue_s, @purple_s, @pink_s, @red_s, @gold_s)";
            SQLiteCommand cmd = new SQLiteCommand(populate_numbers, con);
            SQLiteCommand cmd2 = new SQLiteCommand(populate_received, con);
            SQLiteCommand cmd3 = new SQLiteCommand(empty_numbers, con);
            cmd2.Parameters.AddWithValue("@gun", rn_gun);
            cmd2.Parameters.AddWithValue("@back", listView1.Items[0].BackColor);
            cmd2.Parameters.AddWithValue("@fore", listView1.Items[0].ForeColor);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            adapter2.Fill(dt3);
            var result1 = cmd2.ExecuteNonQuery();
            //write to database the state of numbers at the gun opening,
            //first delete them

            cmd.Parameters.AddWithValue("@spent", loss);
            cmd.Parameters.AddWithValue("@earned", earned);
            cmd.Parameters.AddWithValue("@percentage", profit);
            cmd.Parameters.AddWithValue("@opened", opened);
            cmd.Parameters.AddWithValue("@items_blue", blue_am);
            cmd.Parameters.AddWithValue("@items_purple", purple_am);
            cmd.Parameters.AddWithValue("@items_pink",pink_am);
            cmd.Parameters.AddWithValue("@items_red",red_am);
            cmd.Parameters.AddWithValue("@items_gold",gold_am);
            cmd.Parameters.AddWithValue("@blue_s",blue_s);
            cmd.Parameters.AddWithValue("@purple_s",purple_s);
            cmd.Parameters.AddWithValue("@pink_s",pink_s);
            cmd.Parameters.AddWithValue("@red_s",red_s);
            cmd.Parameters.AddWithValue("@gold_s",gold_s);
            
            var result2 = cmd2.ExecuteNonQuery();
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        public void clear_db()
        {
            //clear db values or set to 0
            string empty_numbers = "DELETE FROM numbers";
            string empty_received = "DELETE FROM received";
            SQLiteCommand cmd = new SQLiteCommand(empty_numbers, con);
            SQLiteCommand cmd2 = new SQLiteCommand(empty_received, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            write_to_db();
        }

        public void music()
        {
            SoundPlayer player = new SoundPlayer();
            if (musical == 0)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\loop.wav";
                player.Play();
                musical = 1;
            } else
            {
                player.Stop();
            }
        }

        public void clear_labels()
        {
            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Transparent;
            pic4.BackColor = Color.Transparent;
            pic5.BackColor = Color.Transparent;
            pic6.BackColor = Color.Transparent;
            pic7.BackColor = Color.Transparent;
            pic8.BackColor = Color.Transparent;
            pic9.BackColor = Color.Transparent;
            pic10.BackColor = Color.Transparent;
            pic11.BackColor = Color.Transparent;
            pic12.BackColor = Color.Transparent;
            pic13.BackColor = Color.Transparent;
            pic14.BackColor = Color.Transparent;
            pic15.BackColor = Color.Transparent;
            pic16.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_labels();
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
                listView1.Items.Insert(0, rn_gun);
                listView1.Items[0].BackColor = Color.Blue;
                if (randomType == "Normal")
                {
                    blue_am += 1;
                } else
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                    blue_s += 1;
                }
                
            }
            else if (randomColor == "Purple")
            {
                quality = "Restricted";
                rn_gun = purple_guns[rn.Next(purple_guns.Count)];
                listView1.Items.Insert(0, rn_gun);
                listView1.Items[0].BackColor = Color.Purple;
                if (randomType == "Normal")
                {
                    purple_am += 1;
                }
                else
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                    purple_s += 1;
                }
                
            }
            else if (randomColor == "Pink")
            {
                quality = "Classified";
                rn_gun = pink_guns[rn.Next(pink_guns.Count)];
                listView1.Items.Insert(0, rn_gun);
                listView1.Items[0].BackColor = Color.Pink;
                if (randomType == "Normal")
                {
                    pink_am += 1;
                }
                else
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                    pink_s += 1;
                }
                
            }
            else if (randomColor == "Red")
            {
                quality = "Covert";
                rn_gun = red_guns[rn.Next(red_guns.Count)];
                listView1.Items.Insert(0, rn_gun);
                listView1.Items[0].BackColor = Color.Red;
                if (randomType == "Normal")
                {
                    red_am += 1;
                }
                else
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                    red_s += 1;
                }
                
            }
            else if (randomColor == "Gold")
            {
                quality = "Knife";
                knives += 1;
                rn_gun = gold_guns[rn.Next(gold_guns.Count)];
                listView1.Items.Insert(0, rn_gun);
                listView1.Items[0].BackColor = Color.Gold;
                if (randomType == "Normal")
                {
                    gold_am += 1;
                }
                else
                {
                    listView1.Items[0].ForeColor = Color.Orange;
                    gold_s += 1;
                }
                
            }


            //light-up the correct picturebox
            if (rn_gun == "SG 553: Wave Spray")
            {
                pic1.BackColor = Color.Blue;
            } else if (rn_gun == "Dual Berettas: Black Limba")
            {
                pic2.BackColor = Color.Blue;
            } else if (rn_gun == "Nova: Tempest")
            {
                pic3.BackColor = Color.Blue;
            }
            else if (rn_gun == "Galil AR: Shattered")
            {
                pic4.BackColor = Color.Blue;
            }
            else if (rn_gun == "UMP-45: Bone Pile")
            {
                pic5.BackColor = Color.Blue;
            }
            else if (rn_gun == "G3SG1: Demeter")
            {
                pic6.BackColor = Color.Blue;
            }
            else if (rn_gun == "USP-S: Overgrowth")
            {
                pic7.BackColor = Color.Blue;
            }
            else if (rn_gun == "M4A4: Zirka")
            {
                pic8.BackColor = Color.Blue;
            }
            else if (rn_gun == "MAC-10: Graven")
            {
                pic9.BackColor = Color.Blue;
            }
            else if (rn_gun == "M4A1-S: Bright Water")
            {
                pic10.BackColor = Color.Blue;
            }
            else if (rn_gun == "P90: Emerald Dragon")
            {
                pic11.BackColor = Color.Blue;
            }
            else if (rn_gun == "P2000: Ocean Foam")
            {
                pic12.BackColor = Color.Blue;
            }
            else if (rn_gun == "AWP: Granite")
            {
                pic13.BackColor = Color.Blue;
            }
            else if (rn_gun == "AK-47: Fire Serpent")
            {
                pic14.BackColor = Color.Blue;
            }
            else if (rn_gun == "Desert Eagle: Golden Koi")
            {
                pic15.BackColor = Color.Blue;
            }
            else if (randomColor == "Gold")
            {
                pic16.BackColor = Color.Blue;
            }

            // Get the wear + price of the item that was chosen from Price class.
            Dictionary<string, double> pricey = pr.price(rn_gun, randomType);

            // calculate profit - price
            foreach (var x in pricey)
                profit += -full_price + x.Value;

            // calculate profit
            foreach (var x in pricey)
                earned += x.Value;

            //calculations plus numbers
            opened += 1;
            loss = Math.Round(loss - full_price, 2);
            percent = -Math.Round(profit * 100 / loss, 2);
            total_opened.Text = opened.ToString();
            profit_percentage.Text = percent.ToString()+"%";
            spent_amount.Text = loss.ToString();
            earned_amount.Text = earned.ToString();
            label33.Text = blue_am.ToString();
            label34.Text = purple_am.ToString();
            label35.Text = pink_am.ToString();
            label36.Text = red_am.ToString();
            label37.Text = gold_am.ToString();
            label38.Text = blue_s.ToString();
            label39.Text = purple_s.ToString();
            label40.Text = pink_s.ToString();
            label41.Text = red_s.ToString();
            label42.Text = gold_s.ToString();
            write_to_db();
        }
        //clear all data
        private void button3_Click(object sender, EventArgs e)
        {
            opened = 0;
            knives = 0;
            loss = 0;
            profit = 0;
            earned = 0;
            percent = 0;
            blue_am = 0;
            purple_am = 0;
            pink_am = 0;
            red_am = 0;
            gold_am = 0;
            blue_s = 0;
            purple_s = 0;
            pink_s = 0;
            red_s = 0;
            gold_s = 0;
            total_opened.Text = 0.ToString();
            profit_percentage.Text = 0.ToString();
            spent_amount.Text = 0.ToString();
            earned_amount.Text = 0.ToString();
            label33.Text = 0.ToString();
            label34.Text = 0.ToString();
            label35.Text = 0.ToString();
            label36.Text = 0.ToString();
            label37.Text = 0.ToString();
            label38.Text = 0.ToString();
            label39.Text = 0.ToString();
            label40.Text = 0.ToString();
            label41.Text = 0.ToString();
            label42.Text = 0.ToString();
            listView1.Items.Clear();
            clear_db();
        }


        int clicked = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (clicked == 0)
            {
                clicked = 1;
                while (clicked == 1)
                {
                    button1_Click(sender, e);
                    if (knives == 1)
                    {
                        break;
                    }
                    wait(750);
                }
            } else
            {
                clicked = 0;
            }
        }
        // Need to add a flashy border to chosen item. 
        // Maybe iterate through random items, until get the correct item. 
        // Overall the project is close to being OK.
    }
}
