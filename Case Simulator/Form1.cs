using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Case_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string,
            Dictionary<string,
            Dictionary<string,
            Dictionary<string, double>>>> weapons =
                new Dictionary<string,
                    Dictionary<string,
                    Dictionary<string,
                    Dictionary<string, double>>>>()
                        {
                        { "blue",
                        new Dictionary<string,
                            Dictionary<string,
                            Dictionary<string, double>>>()
                                {
                                { "SG 553\t\nWave Spray",
                                new Dictionary<string,
                                    Dictionary<string, double>>()
                                        {
                                        { "Normal",
                                        new Dictionary<string, double>()
                                                {
                                                    { "Battle-Scarred", 2.42 },
                                                    { "Well-Worn", 2.53 },
                                                    { "Field-Tested", 2.71 },
                                                    { "Minimal wear", 2.62 },
                                                    { "Factory new", 16.88 }
                                                }
                                        },
                                        { "Stat-Track",
                                        new Dictionary<string, double>()
                                                {
                                                    { "Battle-Scarred", 2.85 },
                                                    { "Well-Worn", 3.19 },
                                                    { "Field-Tested", 2.96 },
                                                    { "Minimal wear", 4.02 },
                                                    { "Factory new", 68.70 }
                                                }
                                        },
                                        }
                                }
                                }
                        }
                        };
            var qry = from outer in weapons
                      from inner in outer.Value
                      select inner.Key;

            foreach (string s in qry)
            { // show them
                label4.Text = s;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
