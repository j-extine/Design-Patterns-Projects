using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgCharacterComposite {
    public partial class RpgCharacterForm : Form {

        private const String GALAHAD = "Sir Galahad the Valiant";
        private const String RIVEL = "Rivel the Knave";
        private const String VILNAR = "Vilnar the Wizened";
        private const String WEAPONS = "Weapons";
        private const String ARMOR = "Armor";
        private const String ITEMS = "Items";
        private const String STR = "STR: ";
        private const String DEX = "DEX: ";
        private const String CON = "CON: ";
        private const String INT = "INT: ";
        private const String WIS = "WIS: ";
        private const String CHA = "CHA: ";

        public RpgCharacterForm() {
            InitializeComponent();
        }

        private void characterCb_SelectedIndexChanged(object sender, EventArgs e) {
            descTb.Focus();

            RpgCharacter character;
            Gear weapons = new Gear(WEAPONS);
            Gear armor = new Gear(ARMOR);
            Gear items = new Gear(ITEMS);

            switch (characterCb.Text) {

                case GALAHAD:
                    character = new RpgCharacter(GALAHAD);

                    weapons.Add(new Weapon("Longsword"));
                    weapons.Add(new Weapon("Javelin x6"));

                    armor.Add(new Armor("Plate"));
                    armor.Add(new Armor("Shield"));

                    items.Add(new Item("Bedroll"));
                    items.Add(new Item("Potion of healing x8"));
                    
                    character.Add(new CharacterDescription("A brave and strong fighter that is inexplicably\n\tgood at everything."));
                    character.Add(weapons);
                    character.Add(armor);
                    character.Add(items);
                    character.Add(new Stat(STR + "15"));
                    character.Add(new Stat(DEX + "13"));
                    character.Add(new Stat(CON + "13"));
                    character.Add(new Stat(INT + "12"));
                    character.Add(new Stat(WIS + "13"));
                    character.Add(new Stat(CHA + "13"));

                    descTb.Clear();
                    descTb.Text = character.toString();

                    break;

                case RIVEL:
                    character = new RpgCharacter(RIVEL);

                    weapons.Add(new Weapon("Shortsword"));
                    weapons.Add(new Weapon("Dart x10"));

                    armor.Add(new Armor("Studded Leather"));

                    items.Add(new Item("Grappling Hook"));
                    items.Add(new Item("Caltrops"));
                    
                    character.Add(new CharacterDescription("A stealthy and charismatic rogue able to use his\n\tsilver tongue " +
                                                           "or his quick hands to get just what he\n\twants."));
                    character.Add(weapons);
                    character.Add(armor);
                    character.Add(items);
                    character.Add(new Stat(STR + "8"));
                    character.Add(new Stat(DEX + "15"));
                    character.Add(new Stat(CON + "11"));
                    character.Add(new Stat(INT + "13"));
                    character.Add(new Stat(WIS + "14"));
                    character.Add(new Stat(CHA + "15"));

                    descTb.Clear();
                    descTb.Text = character.toString();

                    break;

                case VILNAR:
                    character = new RpgCharacter(VILNAR);

                    weapons.Add(new Weapon("None"));

                    armor.Add(new Armor("None"));

                    items.Add(new Item("Orb"));
                    items.Add(new Item("Staff"));
                    items.Add(new Item("Abacus"));
                    items.Add(new Item("Ink pen"));
                    items.Add(new Item("Ink"));
                    items.Add(new Item("Parchment x20"));
                    items.Add(new Item("Robes"));
                    items.Add(new Item("Spellbook"));
                    items.Add(new Item("Magnifying Glass"));
                    
                    character.Add(new CharacterDescription("An old wizard who is incredibly learned in the\n\tarcane arts." +
                                                           " Unfortunately, he isn't learned in the\n\tways of physical strength training."));
                    character.Add(weapons);
                    character.Add(armor);
                    character.Add(items);
                    character.Add(new Stat(STR + "5"));
                    character.Add(new Stat(DEX + "12"));
                    character.Add(new Stat(CON + "8"));
                    character.Add(new Stat(INT + "16"));
                    character.Add(new Stat(WIS + "14"));
                    character.Add(new Stat(CHA + "10"));

                    descTb.Clear();
                    descTb.Text = character.toString();

                    break;

                default:
                    break;
            }
        }
    }
}
