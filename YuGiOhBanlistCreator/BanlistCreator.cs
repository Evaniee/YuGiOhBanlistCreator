using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhBanlistCreator
{
    public partial class BanlistCreator : Form
    {
        private readonly string[] Category = new string[] { "", "Monster", "Spell", "Trap" };
        private readonly string[] MonsterRace = new string[] { "", "Aqua", "Beast", "Beast-Warrior", "Creator-God", "Cyberse", "Dinosaur", "Divine-Beast", "Dragon", "Fairy", "Fiend", "Fish", "Insect", "Machine", "Plant", "Psychic", "Pyro", "Reptile", "Rock", "Sea Serpent", "Spellcaster", "Thunder", "Warrior", "Winged Beast", "Wyrm", "Zombie" };
        private readonly string[] SpellRace = new string[] { "", "Normal", "Field", "Equip", "Continuous", "Quick-Play", "Ritual" };
        private readonly string[] TrapRace = new string[] { "", "Normal", "Continuous", "Counter"};
        private readonly string[] MonsterCategory = new string[] { "", "Effect Monster", "Flip Effect Monster", "Flip Tuner Effect Monster", "Gemini Monster", "Normal Monster", "Normal Tuner Monster", "Pendulum Effect Monster", "Pendulum Flip Effect Monster", "Pendulum Normal Monster", "Pendulum Tuner Effect Monster", "Ritual Effect Monster", "Ritual Monster", "Spirit Monster", "Toon Monster", "Tuner Monster", "Union Effect Monster", "Fusion Monster", "Link Monster", "Pendulum Effect Fusion Monster", "Synchro Monster", "Synchro Pendulum Effect Monster", "Synchro Tuner Monster", "XYZ Monster", "XYZ Pendulum Effect Monster" };
        private readonly string[] Attribute = new string[] { "", "EARTH", "WATER", "FIRE", "WIND", "LIGHT", "DARK", "DIVINE" };
        private Dictionary<string,string>[] lists;
        private int currentLimit;
        private string titleFile;
        public BanlistCreator()
        {
            lists = new Dictionary<string,string>[4];
            for(int i = 0; i < lists.Count(); i++)
                lists[i] = new Dictionary<string, string>();
            currentLimit = 0;
            InitializeComponent();
        }

        private void mnu_file_open_add_Click(object sender, EventArgs e)
        {
            LoadFile(true);
        }

        private void mnu_file_open_load_Click(object sender, EventArgs e)
        {
            LoadFile(false);
        }

        private void LoadFile(bool append)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load A Banlist File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgv_limit.Rows.Clear();
                if (!append)
                {
                    lists = new Dictionary<string, string>[4];
                    for (int i = 0; i < lists.Count(); i++)
                        lists[i] = new Dictionary<string, string>();
                }
                string[] banlist = File.ReadAllLines(openFileDialog.FileName);
                foreach (string card in banlist)
                {
                    // Ignore Commented Lines
                    if (card.StartsWith('!') || card.StartsWith('#') || card.StartsWith('$'))
                        continue;

                    string[] splits = card.Split(' ');
                    string id = splits[0];
                    int limit = int.Parse(splits[1]);

                    // Create name from possible numbers
                    StringBuilder name = new StringBuilder();
                    for (int i = 2; i < splits.Length; i++)
                    {
                        if (i != 2)
                            name.Append(' ');
                        name.Append(splits[i]);
                    }
                    string nameString = name.ToString().Remove(0,2);
                    int tabIndex = nameString.IndexOf('\t');
                    if (tabIndex < 0)
                        lists[limit].Add(nameString, id);
                    else
                        lists[limit].Add(nameString.Remove(tabIndex), id);
                }
                foreach (KeyValuePair<string,string> card in lists[currentLimit])
                {
                    dgv_limit.Rows.Add(card.Key);
                }
                
            }
        }
    }
}
