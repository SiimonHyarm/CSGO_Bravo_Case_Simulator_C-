using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Simulator
{
    class Price
    {
        Random rn = new Random();
        public Dictionary<string, double> price(string rn_gun, string randomType)
        {
            string randomKey = "11";
            Dictionary<string, double> _n = new Dictionary<string, double>();
            Dictionary<string, double> _s = new Dictionary<string, double>();
            if (rn_gun == "SG 553: Wave Spray")
            {
                //Create two sets of dictionaries, for normal and stat-track guns
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred" , 2.42 },
                    { "Well-Worn", 2.53},
                    { "Field-Tested", 2.71},
                    { "Minimal Wear", 2.62},
                    { "Factory new", 16.88}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred" , 2.85 },
                    { "Well-Worn", 3.19},
                    { "Field-Tested", 2.96},
                    { "Minimal Wear", 4.02},
                    { "Factory new", 68.70}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Dual Berettas: Black Limba")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.41},
                    { "Well-Worn", 2.37},
                    { "Field-Tested", 2.47},
                    { "Minimal Wear", 2.73},
                    { "Factory new", 9.71}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.94},
                    { "Well-Worn", 3.07},
                    { "Field-Tested", 2.95},
                    { "Minimal Wear", 4.50},
                    { "Factory new", 32.84}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Nova: Tempest")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 2.57},
                    { "Minimal Wear", 2.66},
                    { "Factory new", 7.50}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 3.10},
                    { "Minimal Wear", 4.23},
                    { "Factory new", 19.46}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Galil AR: Shattered")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.41},
                    { "Well-Worn", 2.42},
                    { "Field-Tested", 2.36},
                    { "Minimal Wear", 2.64},
                    { "Factory new", 9}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.89},
                    { "Well-Worn", 3.01},
                    { "Field-Tested", 2.92},
                    { "Minimal Wear", 4.05},
                    { "Factory new", 94.83}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "UMP-45: Bone Pile")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 2.44},
                    { "Minimal Wear", 2.59},
                    { "Factory new", 9.23}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 3.10},
                    { "Minimal Wear", 4.30},
                    { "Factory new", 29.60}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "G3SG1: Demeter")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.42},
                    { "Well-Worn", 3.12},
                    { "Field-Tested", 2.42},
                    { "Minimal Wear", 2.60},
                    { "Factory new", 12.70}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 2.94},
                    { "Well-Worn", 3.30},
                    { "Field-Tested", 2.89},
                    { "Minimal Wear", 3.98},
                    { "Factory new", 19.43}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "USP-S: Overgrowth")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 13.94},
                    { "Well-Worn", 10.42},
                    { "Field-Tested", 11.20},
                    { "Minimal Wear", 16.18},
                    { "Factory new", 55.83}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 25.10},
                    { "Well-Worn", 24.66},
                    { "Field-Tested", 26.68},
                    { "Minimal Wear", 48.67},
                    { "Factory new", 303.48}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M4A4: Zirka")
            {
                _n = new Dictionary<string, double>
                {
                    { "Well-Worn", 11.40},
                    { "Field-Tested", 10.47},
                    { "Minimal Wear", 11.86},
                    { "Factory new", 23.81}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 28.78},
                    { "Field-Tested", 28.82},
                    { "Minimal Wear", 32.85},
                    { "Factory new", 99.99}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "MAC-10: Graven")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 9.92},
                    { "Well-Worn", 11.63},
                    { "Field-Tested", 11.43},
                    { "Minimal Wear", 11.80},
                    { "Factory new", 21.68}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 26},
                    { "Well-Worn", 29.99},
                    { "Field-Tested", 28.15},
                    { "Minimal Wear", 34.50},
                    { "Factory new", 94.20}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M4A1-S: Bright Water")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 11.27},
                    { "Minimal Wear", 11.09}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 29.67},
                    { "Minimal Wear", 29.23}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "P90: Emerald Dragon")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 64.65},
                    { "Well-Worn", 77.92},
                    { "Field-Tested", 71.80},
                    { "Minimal Wear", 65.13},
                    { "Factory new", 320}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 156.99},
                    { "Minimal Wear", 172.50},
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "P2000: Ocean Foam")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 81.81},
                    { "Factory new", 71.90}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 1000},
                    { "Factory new", 321.26}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "AWP: Granite")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 80},
                    { "Factory new", 84.49}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 286.62},
                    { "Factory new", 335}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "AK-47: Fire Serpent")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 337.50},
                    { "Well-Worn", 402.50},
                    { "Field-Tested", 479.80},
                    { "Minimal Wear", 692.80}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 1243.76},
                    { "Field-Tested", 1410.67}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Desert Eagle: Golden Koi")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 26.52},
                    { "Factory new", 26.41}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 119.33}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: safari mesh")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 63.33},
                    { "Well-Worn", 68.83},
                    { "Field-Tested", 65.19},
                    { "Minimal Wear", 63.25},
                    { "Factory new", 117.10}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 73.94},
                    { "Well-Worn", 72},
                    { "Field-Tested", 72.77},
                    { "Minimal Wear", 97.58}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Night")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 68.41},
                    { "Well-Worn", 69.52},
                    { "Field-Tested", 65.57},
                    { "Minimal Wear", 87.35}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 75.14},
                    { "Field-Tested", 82.84},
                    { "Minimal Wear", 111.18}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Forest DDpat")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 66.20},
                    { "Well-Worn", 75.87},
                    { "Field-Tested", 65.43},
                    { "Minimal Wear", 82.77}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 75.16},
                    { "Minimal Wear", 115.94}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Boreal Forest")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 63.59},
                    { "Well-Worn", 66.93},
                    { "Field-Tested", 65.63},
                    { "Minimal Wear", 75.03},
                    { "Factory new", 140.74}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 86.47},
                    { "Well-Worn", 75.90},
                    { "Field-Tested", 77.13},
                    { "Minimal Wear", 109.82}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Scorched")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 64.93},
                    { "Well-Worn", 80.36},
                    { "Field-Tested", 64.92},
                    { "Minimal Wear", 71.58},
                    { "Factory new", 156.70}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 104.82},
                    { "Field-Tested", 78.28},
                    { "Minimal Wear", 122.80}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Vanilla")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 78.42}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 110.04}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Forest DDpat")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 86.61},
                    { "Well-Worn", 94.91},
                    { "Field-Tested", 109.06},
                    { "Minimal Wear", 92.86}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 104.82},
                    { "Field-Tested", 94.82}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Safari mesh")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 84.74},
                    { "Well-Worn", 84.14},
                    { "Field-Tested", 79.82},
                    { "Minimal Wear", 98.67},
                    { "Factory new", 160.72}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 92.14},
                    { "Well-Worn", 92.14},
                    { "Field-Tested", 87.82},
                    { "Minimal Wear", 111.32}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Boreal Forest")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 80.56},
                    { "Well-Worn", 88.75},
                    { "Field-Tested", 91.83},
                    { "Minimal Wear", 100.94}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 146.70},
                    { "Field-Tested", 97.68}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: urban masked")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 99.83},
                    { "Well-Worn", 106.99},
                    { "Field-Tested", 87.85},
                    { "Minimal Wear", 109.82}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 108.09},
                    { "Field-Tested", 88.84},
                    { "Minimal Wear", 126.51}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Scorched")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 84.79},
                    { "Well-Worn", 88.88},
                    { "Field-Tested", 81.01},
                    { "Minimal Wear", 93.04},
                    { "Factory new", 164.72}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 99.32},
                    { "Minimal Wear", 152.69}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Crimson Web")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 77.01},
                    { "Well-Worn", 85.60},
                    { "Field-Tested", 88.58},
                    { "Minimal Wear", 114.15}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 94.49},
                    { "Well-Worn", 126.91},
                    { "Field-Tested", 107.80},
                    { "Minimal Wear", 208.27}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Stained")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 71.41},
                    { "Well-Worn", 71.30},
                    { "Field-Tested", 72.55},
                    { "Minimal Wear", 78.42},
                    { "Factory new", 170.52}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 81.42},
                    { "Well-Worn", 90.92},
                    { "Field-Tested", 89.85},
                    { "Factory new", 329.44}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Stained")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 99.33},
                    { "Well-Worn", 100.35},
                    { "Field-Tested", 91.83},
                    { "Minimal Wear", 109.21},
                    { "Factory new", 209.86}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 92.82},
                    { "Field-Tested", 108.77},
                    { "Minimal Wear", 163.39}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Slaughter")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 113.29},
                    { "Minimal Wear", 111.65},
                    { "Factory new", 123.47}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 109.13},
                    { "Factory new", 159.60}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Vanilla")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 122.63}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 149.51}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Fade")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 125.26}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 149.10}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Blue Steel")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 109.64},
                    { "Well-Worn", 99.38},
                    { "Field-Tested", 108.15},
                    { "Minimal Wear", 114.07},
                    { "Factory new", 144.75}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 128.37},
                    { "Field-Tested", 126.91},
                    { "Minimal Wear", 155.28},
                    { "Factory new", 289.52}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Blue Steel")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 77.86},
                    { "Well-Worn", 76.96},
                    { "Field-Tested", 81.41},
                    { "Minimal Wear", 78.60},
                    { "Factory new", 95.45}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 123.13},
                    { "Well-Worn", 91.83},
                    { "Field-Tested", 87.14},
                    { "Factory new", 574.01}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Urban Masked")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 189.78},
                    { "Well-Worn", 143.49},
                    { "Field-Tested", 129.78},
                    { "Minimal Wear", 154.84}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 148.36},
                    { "Field-Tested", 167.84},
                    { "Minimal Wear", 195.58}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Safari Mesh")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 126.67},
                    { "Well-Worn", 129},
                    { "Field-Tested", 132.02},
                    { "Minimal Wear", 144.44},
                    { "Factory new", 242.70}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 150.12},
                    { "Field-Tested", 135.13}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Forest DDpat")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 134.94},
                    { "Well-Worn", 132.43},
                    { "Field-Tested", 123.78},
                    { "Minimal Wear", 166.22}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 148.99},
                    { "Field-Tested", 149.23},
                    { "Minimal Wear", 223.08}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Boreal Forest")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 135.14},
                    { "Well-Worn", 144.75},
                    { "Field-Tested", 135.32},
                    { "Minimal Wear", 154.73}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 144.93},
                    { "Field-Tested", 183.67},
                    { "Minimal Wear", 198.66}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Case Hardened")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 135.89},
                    { "Well-Worn", 125.48},
                    { "Field-Tested", 148.37},
                    { "Minimal Wear", 160.57},
                    { "Factory new", 225.86}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 156.74},
                    { "Field-Tested", 179.69},
                    { "Minimal Wear", 187.62}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Night")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 92.29},
                    { "Well-Worn", 103.61},
                    { "Field-Tested", 103.31},
                    { "Minimal Wear", 156.63},
                    { "Factory new", 365.95}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 159.72},
                    { "Well-Worn", 171},
                    { "Field-Tested", 121.39},
                    { "Minimal Wear", 213.22}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Forest DDpat")
            {
                _n = new Dictionary<string, double>
                {
                    { "Well-Worn", 149.75},
                    { "Field-Tested", 154.51},
                    { "Minimal Wear", 201.65}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 167.83},
                    { "Minimal Wear", 210.44}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Night")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 154.73},
                    { "Well-Worn", 144.76},
                    { "Field-Tested", 148.98},
                    { "Minimal Wear", 227.95}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 239.43},
                    { "Field-Tested", 175.19}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Scorched")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 168.68},
                    { "Well-Worn", 149.23},
                    { "Field-Tested", 146.75},
                    { "Minimal Wear", 164.84},
                    { "Factory new", 256.79}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 193.98},
                    { "Minimal Wear", 201.57}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Stained")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 152.69},
                    { "Well-Worn", 165.24},
                    { "Field-Tested", 164.83},
                    { "Minimal Wear", 177.11},
                    { "Factory new", 252.32}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 183.67},
                    { "Field-Tested", 175.58},
                    { "Minimal Wear", 204.66}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Boreal Forest")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 144.29},
                    { "Well-Worn", 206.36},
                    { "Field-Tested", 179.69},
                    { "Minimal Wear", 231.78}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 172.31},
                    { "Minimal Wear", 178.70}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Urban Masked")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 169.35},
                    { "Well-Worn", 185.18},
                    { "Field-Tested", 152.28},
                    { "Minimal Wear", 188.17}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 184.28},
                    { "Minimal Wear", 344.40}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Blue Steel")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 164.75},
                    { "Well-Worn", 179.69},
                    { "Field-Tested", 169.89},
                    { "Minimal Wear", 189.42},
                    { "Factory new", 516.61}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 236.14},
                    { "Well-Worn", 193.96},
                    { "Field-Tested", 194.18},
                    { "Minimal Wear", 301.38}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Stained")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 174.71},
                    { "Well-Worn", 179.76},
                    { "Field-Tested", 199.66},
                    { "Minimal Wear", 218.11},
                    { "Factory new", 254.56}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 205.70},
                    { "Well-Worn", 190.40},
                    { "Field-Tested", 199.88},
                    { "Minimal Wear", 217.47},
                    { "Factory new", 348.41}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Safari Mesh")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 167.08},
                    { "Field-Tested", 147.85},
                    { "Minimal Wear", 196.61}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 229.60},
                    { "Well-Worn", 380.76},
                    { "Field-Tested", 239.02},
                    { "Minimal Wear", 183.67}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Scorched")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 199.66},
                    { "Well-Worn", 189.10},
                    { "Field-Tested", 193.95},
                    { "Minimal Wear", 214.69}
                };
                _s = new Dictionary<string, double>
                {
                    { "Well-Worn", 214.65},
                    { "Field-Tested", 235.01},
                    { "Minimal Wear", 297.49}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Night")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 197.99},
                    { "Well-Worn", 199.19},
                    { "Field-Tested", 189.39},
                    { "Minimal Wear", 270.29}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 169.78},
                    { "Field-Tested", 239.41},
                    { "Minimal Wear", 291.97}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Safari Mesh")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 181.76},
                    { "Well-Worn", 275.35},
                    { "Field-Tested", 192.86},
                    { "Minimal Wear", 214.65}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 235.75},
                    { "Minimal Wear", 349.41}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Urban Masked")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 218.39},
                    { "Well-Worn", 210.87},
                    { "Field-Tested", 198.06},
                    { "Minimal Wear", 259.56}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 269.54},
                    { "Minimal Wear", 300.57}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Slaughter")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 179.74},
                    { "Minimal Wear", 207.53},
                    { "Factory new", 237.84}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 205.40},
                    { "Minimal Wear", 231.76},
                    { "Factory new", 396.55}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Gut Knife: Urban Masked")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 67.41},
                    { "Well-Worn", 67.44},
                    { "Field-Tested", 63.13},
                    { "Minimal Wear", 71.16}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 1451.06},
                    { "Well-Worn", 75.16},
                    { "Field-Tested", 75.60},
                    { "Minimal Wear", 86.93}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Forest DDpat")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 202.32},
                    { "Well-Worn", 195.16},
                    { "Field-Tested", 198.65},
                    { "Minimal Wear", 246.67}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 430.50},
                    { "Field-Tested", 223.43}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Boreal Forest")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 191.61},
                    { "Well-Worn", 253.84},
                    { "Field-Tested", 209.63},
                    { "Minimal Wear", 299.49}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 258.30},
                    { "Minimal Wear", 299.49}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Blue Steel")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 253.48},
                    { "Well-Worn", 217.56},
                    { "Field-Tested", 229.60},
                    { "Minimal Wear", 233.98},
                    { "Factory new", 419.27}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 310.37},
                    { "Well-Worn", 220.72},
                    { "Field-Tested", 274.53},
                    { "Minimal Wear", 273.08}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Crimson Web")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 239.24},
                    { "Well-Worn", 195.21},
                    { "Field-Tested", 202.75},
                    { "Minimal Wear", 352.49}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 287},
                    { "Well-Worn", 273.73},
                    { "Field-Tested", 239.59},
                    { "Minimal Wear", 387.97}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Scorched")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 134.76},
                    { "Well-Worn", 138.32},
                    { "Field-Tested", 126.41},
                    { "Minimal Wear", 148.34},
                    { "Factory new", 219.62}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 998.28},
                    { "Field-Tested", 142.60}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Crimson Web")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 133.60},
                    { "Well-Worn", 166.10},
                    { "Field-Tested", 169.19},
                    { "Minimal Wear", 309.47}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 151.96},
                    { "Well-Worn", 240.59},
                    { "Field-Tested", 291.91},
                    { "Minimal Wear", 719.21}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Case Hardened")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 285.64},
                    { "Well-Worn", 228},
                    { "Field-Tested", 239.59},
                    { "Minimal Wear", 318},
                    { "Factory new", 365.36}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 367.36},
                    { "Well-Worn", 270.89},
                    { "Field-Tested", 299.47},
                    { "Minimal Wear", 345.38}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Stained")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 309.88},
                    { "Well-Worn", 258.29},
                    { "Field-Tested", 289.52},
                    { "Minimal Wear", 311.89},
                    { "Factory new", 367.57}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 269.54},
                    { "Well-Worn", 264.36},
                    { "Field-Tested", 281.01},
                    { "Minimal Wear", 344.40},
                    { "Factory new", 443.35}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Vanilla")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 317.96}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 331.46}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Flip Knife: Fade")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 300.67},
                    { "Factory new", 309.66}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 370.43}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Blue Steel")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 325.41},
                    { "Well-Worn", 281.25},
                    { "Field-Tested", 322.45},
                    { "Minimal Wear", 349.41}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 379.53},
                    { "Well-Worn", 318.95},
                    { "Field-Tested", 369.37},
                    { "Minimal Wear", 373.10}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Slaughter")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 286.61},
                    { "Minimal Wear", 319.45},
                    { "Factory new", 431.68}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 363.72},
                    { "Factory new", 429.87}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Vanilla")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 353.73}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 388}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Night")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 268.34},
                    { "Well-Worn", 253.05},
                    { "Field-Tested", 241.07},
                    { "Minimal Wear", 328.44},
                    { "Factory new", 893.96}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 268.54},
                    { "Well-Worn", 268.52},
                    { "Field-Tested", 276.16},
                    { "Minimal Wear", 598.98}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Case Hardened")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 227.71},
                    { "Well-Worn", 257.96},
                    { "Field-Tested", 279.53},
                    { "Minimal Wear", 315.82},
                    { "Factory new", 1163.91}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 274.81},
                    { "Field-Tested", 415.72},
                    { "Minimal Wear", 479.17}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Crimson Web")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 326.79},
                    { "Well-Worn", 283.22},
                    { "Field-Tested", 310.45},
                    { "Minimal Wear", 916.04}
                };
                _s = new Dictionary<string, double>
                {
                    { "Field-Tested", 362}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Vanilla")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 394.32}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 507.87}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Case Hardened")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 358.50},
                    { "Well-Worn", 378.85},
                    { "Field-Tested", 395.20},
                    { "Minimal Wear", 506.05}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 488.21},
                    { "Well-Worn", 430.47},
                    { "Field-Tested", 574.01},
                    { "Minimal Wear", 612.17}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Slaughter")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 430.50},
                    { "Minimal Wear", 399.31},
                    { "Factory new", 523.46}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 411.95},
                    { "Factory new", 644.74}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Bayonet: Fade")
            {
                _n = new Dictionary<string, double>
                {
                    { "Factory new", 484.96}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 527.54}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Crimson Web")
            {
                _n = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 344.40},
                    { "Well-Worn", 419.27},
                    { "Field-Tested", 410.53},
                    { "Minimal Wear", 716.90}
                };
                _s = new Dictionary<string, double>
                {
                    {"Battle-Scarred", 367.28},
                    { "Well-Worn", 413.29},
                    { "Field-Tested", 524.10},
                    { "Minimal Wear", 868.59}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Slaughter")
            {
                _n = new Dictionary<string, double>
                {
                    { "Field-Tested", 518.88},
                    { "Minimal Wear", 463.88},
                    { "Factory new", 618.27}
                };
                _s = new Dictionary<string, double>
                {
                    { "Minimal Wear", 543.06},
                    { "Factory new", 758.23}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "M9 Bayonet: Fade")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 801.24},
                    { "Factory new", 596.96}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 688.80}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            else if (rn_gun == "Karambit: Fade")
            {
                _n = new Dictionary<string, double>
                {
                    { "Minimal Wear", 1018.71},
                    { "Factory new", 1168.79}
                };
                _s = new Dictionary<string, double>
                {
                    { "Factory new", 1450}
                };
                if (randomType == "Normal")
                {
                    List<string> keyList = new List<string>(_n.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
                else
                {
                    List<string> keyList = new List<string>(_s.Keys);
                    randomKey = keyList[rn.Next(keyList.Count)];
                }
            }
            if (randomType == "Normal")
            {
                var answer = new Dictionary<string, double> {
                    {randomKey, _n[randomKey] }
                };
                return answer;
            } else
            {
                var answer = new Dictionary<string, double> {
                    {randomKey, _s[randomKey] }
                };
                return answer;
            }
            
        }
    }
}
