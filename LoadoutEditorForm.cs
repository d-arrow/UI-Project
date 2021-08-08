using SingleplayerLauncher.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static SingleplayerLauncher.LauncherMainForm; //TOAD CODE

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        private readonly List<ComboBox> comBoxLoadoutSlots;
        private readonly List<ComboBox> comBoxGuardianSlots;
        private readonly Hero hero = Hero.Instance;

        private const int nLoadoutSlots = 9;
        private const int nGuardianSlots = 2;

        
        public LoadoutEditorForm()
        {
            InitializeComponent();

            comBoxLoadoutSlots = new List<ComboBox>()
            {
                comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };

            comBoxGuardianSlots = new List<ComboBox>()
            {
                comBoxGuardianSlot1, comBoxGuardianSlot2
            };
        }

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            PopulateSlots(comBoxLoadoutSlots, Loadout.Traps.Keys.ToList());
            PopulateSlots(comBoxLoadoutSlots, Loadout.Gear.Keys.ToList());
            PopulateSlots(comBoxGuardianSlots, Loadout.Guardians.Keys.ToList());

            //toad start
            comBoxHero.Text = "TimeMaster";
            StartPosition = FormStartPosition.Manual;
            Left = MainFormLocationTOAD.MainFormLocationLeft;
            Top = MainFormLocationTOAD.MainFormLocationTop;
            //toad end

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            SetDefaultSlots(comBoxLoadoutSlots, DefaultValues.Loadout);
            SetDefaultSlots(comBoxGuardianSlots, DefaultValues.Guardians);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetDefaultLoadoutInForm(); //also closes
            Settings.Instance["loadout"] = hero.Loadout; //closes
            Settings.Save();
            Text = "Loadout saved: " + DateTime.Now.ToString();
            //Close();
        }

        private void SetDefaultLoadoutInForm()
        {
            hero.Loadout = SaveLoadout();
            hero.Guardians = SaveGuardians();

            //Close();
        }

        private void PopulateSlots(List<ComboBox> comBoxSlotList, List<String> entryList)
        {
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                foreach (string entry in entryList)
                {
                    comBoxSlot.Items.Add(entry);
                }
            }
        }

        private void SetDefaultSlots(List<ComboBox> comBoxSlotList, string[] defaultEntryList)
        {
            int i = 0;
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                comBoxSlot.SelectedItem = defaultEntryList[i];
                i++;
            }
        }

        private string[] SaveLoadout()
        {
            string[] loadout = new string[nLoadoutSlots];

            for (int i = 0; i < nLoadoutSlots; i++)
            {
                loadout[i] = comBoxLoadoutSlots[i].Text;
            }

            return loadout;
        }

        private string[] SaveGuardians()
        {
            string[] guardians = new string[nGuardianSlots];

            for (int i = 0; i < nGuardianSlots; i++)
            {
                guardians[i] = comBoxGuardianSlots[i].Text;
            }

            return guardians;
        }


        //toad start--------------------------
        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxHero.SelectedItem.ToString() == "TimeMaster")
            {
                comBoxLoadoutSlot1.Text = "Mending Root";
                comBoxLoadoutSlot2.Text = "Mage's Clover";
                comBoxLoadoutSlot3.Text = "Barricade";
                comBoxLoadoutSlot4.Text = "Viscous Tar";
                comBoxLoadoutSlot5.Text = "Flip Trap";
                comBoxLoadoutSlot6.Text = "Wall Blades";
                comBoxLoadoutSlot7.Text = "Arrow Wall";
                comBoxLoadoutSlot8.Text = "Concussive Pounder";
                comBoxLoadoutSlot9.Text = "Ceiling Ballista";
            }

            if (comBoxHero.SelectedItem.ToString() == "Toad")
            {
                comBoxLoadoutSlot1.Text = "Ice Amulet";
                comBoxLoadoutSlot2.Text = "Spike Wall";
                comBoxLoadoutSlot3.Text = "Barricade";
                comBoxLoadoutSlot4.Text = "Viscous Tar";
                comBoxLoadoutSlot5.Text = "Flip Trap";
                comBoxLoadoutSlot6.Text = "Wall Blades";
                comBoxLoadoutSlot7.Text = "Arrow Wall";
                comBoxLoadoutSlot1.Text = "Concussive Pounder";
                comBoxLoadoutSlot8.Text = "Ceiling Ballista";
                comBoxLoadoutSlot9.Text = "Swinging Mace";

            }


            if (comBoxHero.SelectedItem.ToString() == "Melee")
            {
                comBoxLoadoutSlot1.Text = "Arcane Bubble Blower";
                comBoxLoadoutSlot2.Text = "Fire Wall Bracers";
                comBoxLoadoutSlot3.Text = "Ice Amulet";
                comBoxLoadoutSlot4.Text = "Lightning Ring";
                comBoxLoadoutSlot5.Text = "Ring of Storms";
                comBoxLoadoutSlot6.Text = "Viscous Tar";
                comBoxLoadoutSlot7.Text = "Barricade";
                comBoxLoadoutSlot8.Text = "Summoner Trap";
                comBoxLoadoutSlot9.Text = "Steam Vent";

            }

            if (comBoxHero.SelectedItem.ToString() == "Vermillion Phoenix. Endless Baths")
            {
                comBoxLoadoutSlot1.Text = "Fire Wall Bracers";
                comBoxLoadoutSlot2.Text = "Lightning Ring";
                comBoxLoadoutSlot3.Text = "Viscous Tar";
                comBoxLoadoutSlot4.Text = "Floor Scorcher";
                comBoxLoadoutSlot5.Text = "BGH Ceiling Ballista";
                comBoxLoadoutSlot6.Text = "Power Generator";
                comBoxLoadoutSlot7.Text = "Ceiling Ballista";
                comBoxLoadoutSlot8.Text = "Boom Barrel Roller";
                comBoxLoadoutSlot9.Text = "Great Wall Barricade";

            }

            if (comBoxHero.SelectedItem.ToString() == "Vermillion Phoenix. Endless Avalanche")
            {
                comBoxLoadoutSlot1.Text = "Mage's Clover";
                comBoxLoadoutSlot2.Text = "Fire Wall Bracers";
                comBoxLoadoutSlot3.Text = "Barricade";
                comBoxLoadoutSlot4.Text = "Floor Scorcher";
                comBoxLoadoutSlot5.Text = "Brimstone";
                comBoxLoadoutSlot6.Text = "Fire Cracker";
                comBoxLoadoutSlot7.Text = "Spitfire Wall";
                comBoxLoadoutSlot8.Text = "Naphtha Sprayer";
                comBoxLoadoutSlot9.Text = "Ceiling Ballista";

            }

            if (comBoxHero.SelectedItem.ToString() == "Vermillion Phoenix. Unchained Fortress")
            {
                comBoxLoadoutSlot1.Text = "Mending Root";
                comBoxLoadoutSlot2.Text = "Mage's Clover";
                comBoxLoadoutSlot3.Text = "Barricade";
                comBoxLoadoutSlot4.Text = "Floor Spikes";
                comBoxLoadoutSlot5.Text = "Tar Trap";
                comBoxLoadoutSlot6.Text = "Brimstone";
                comBoxLoadoutSlot7.Text = "Arrow Wall";
                comBoxLoadoutSlot8.Text = "Ceiling Pounder";
                comBoxLoadoutSlot9.Text = "Swinging Mace";

            }

            if (comBoxHero.SelectedItem.ToString() == "Vermillion Phoenix. Banquet Hall")
            {
                comBoxLoadoutSlot1.Text = "Mending Root";
                comBoxLoadoutSlot2.Text = "Mage's Clover";
                comBoxLoadoutSlot3.Text = "Great Wall Barricade";
                comBoxLoadoutSlot4.Text = "Grinder";
                comBoxLoadoutSlot5.Text = "Saw Of Arctos";
                comBoxLoadoutSlot6.Text = "Ice Shard";
                comBoxLoadoutSlot7.Text = "Floor Scorcher";
                comBoxLoadoutSlot8.Text = "Arcane Phaser";
                comBoxLoadoutSlot9.Text = "Haymaker";

            }

            if (comBoxHero.SelectedItem.ToString() == "Want more? just tell Toad (Stud Guy) what to add")
            {
                comBoxLoadoutSlot1.Text = "";
                comBoxLoadoutSlot2.Text = "";
                comBoxLoadoutSlot3.Text = "";
                comBoxLoadoutSlot4.Text = "";
                comBoxLoadoutSlot5.Text = "";
                comBoxLoadoutSlot6.Text = "";
                comBoxLoadoutSlot7.Text = "";
                comBoxLoadoutSlot8.Text = "";
                comBoxLoadoutSlot9.Text = "";

            }

            /*
            if (comBoxHero.SelectedItem.ToString() == "Vermillion Phoenix. Endless Avalanche")
            {
                comBoxLoadoutSlot1.Text = "";
                comBoxLoadoutSlot2.Text = "";
                comBoxLoadoutSlot3.Text = "";
                comBoxLoadoutSlot4.Text = "";
                comBoxLoadoutSlot5.Text = "";
                comBoxLoadoutSlot6.Text = "";
                comBoxLoadoutSlot7.Text = "";
                comBoxLoadoutSlot8.Text = "";
                comBoxLoadoutSlot9.Text = "";

            }

            //add them also to the loadout edit comBoxHero Items (Collection) by selecting it on the form in the Design (GUI) ^^
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDefaultLoadoutInForm();
            Settings.Instance["loadout"] = hero.Loadout;
            Settings.Save();
            Close();
        }

        private void comBoxLoadoutSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //toad end-----------------------------
    }

}
