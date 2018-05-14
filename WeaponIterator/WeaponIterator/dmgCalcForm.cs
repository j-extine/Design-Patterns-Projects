using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponIterator{
    public partial class dmgCalcForm : Form{

        Aggregate weapons; 
        Iterator weaponIterator;

        // constants representing the weapon skills
        private const string BLADE = "Blade";
        private const string BLUNT = "Blunt";
        private const string MARKSMAN = "Marksman";

        //constants representing the attribute used
        private const string STRENGTH = "Strength";
        private const string AGILITY = "Agility";

        public dmgCalcForm(){

            InitializeComponent();
            weapons = new ConcreteAggregate {

                // Adding the daggers to the weapons list
                new Weapon("Iron", "Dagger", "Blade", 5),
                new Weapon("Steel", "Dagger", "Blade", 7),
                new Weapon("Silver", "Dagger", "Blade", 9),
                new Weapon("Dwarven", "Dagger", "Blade", 11),
                new Weapon("Elven", "Dagger", "Blade", 13),
                new Weapon("Glass", "Dagger", "Blade", 15),
                new Weapon("Ebony", "Dagger", "Blade", 17),
                new Weapon("Deadric", "Dagger", "Blade", 19),
                
                // Adding the war axes to the weapons list
                new Weapon("Iron", "War Axe", "Blunt", 8),
                new Weapon("Steel", "War Axe", "Blunt", 10),
                new Weapon("Silver", "War Axe", "Blunt", 12),
                new Weapon("Dwarven", "War Axe", "Blunt", 14),
                new Weapon("Elvewn", "War Axe", "Blunt", 16),
                new Weapon("Glass", "War Axe", "Blunt", 18),
                new Weapon("Ebony", "War Axe", "Blunt", 20),
                new Weapon("Deadric", "War Axe", "Blunt", 22),
                
                // Adding the shortswords to the weapons list
                new Weapon("Iron", "Shortsword", "Blade", 7),
                new Weapon("Steel", "Shortsword", "Blade", 9),
                new Weapon("Silver", "Shortsword", "Blade", 11),
                new Weapon("Dwarven", "Shortsword", "Blade", 13),
                new Weapon("Elvewn", "Shortsword", "Blade", 15),
                new Weapon("Glass", "Shortsword", "Blade", 17),
                new Weapon("Ebony", "Shortsword", "Blade", 19),
                new Weapon("Deadric", "Shortsword", "Blade", 21),
                
                // Adding the maces to the weapons list
                new Weapon("Iron", "Mace", "Blunt", 10),
                new Weapon("Steel", "Mace", "Blunt", 12),
                new Weapon("Silver", "Mace", "Blunt", 14),
                new Weapon("Dwarven", "Mace", "Blunt", 16),
                new Weapon("Elvewn", "Mace", "Blunt", 18),
                new Weapon("Glass", "Mace", "Blunt", 20),
                new Weapon("Ebony", "Mace", "Blunt", 22),
                new Weapon("Deadric", "Mace", "Blunt", 24),
                
                // Adding the longswords to the weapons list
                new Weapon("Iron", "Longsword", "Blade", 10),
                new Weapon("Steel", "Longsword", "Blade", 12),
                new Weapon("Silver", "Longsword", "Blade", 14),
                new Weapon("Dwarven", "Longsword", "Blade", 16),
                new Weapon("Elvewn", "Longsword", "Blade", 18),
                new Weapon("Glass", "Longsword", "Blade", 20),
                new Weapon("Ebony", "Longsword", "Blade", 22),
                new Weapon("Deadric", "Longsword", "Blade", 24),
                
                // Adding the battle axes to the weapons list
                new Weapon("Iron", "Battle Axe", "Blunt", 12),
                new Weapon("Steel", "Battle Axe", "Blunt", 14),
                new Weapon("Silver", "Battle Axe", "Blunt", 16),
                new Weapon("Dwarven", "Battle Axe", "Blunt", 18),
                new Weapon("Elvewn", "Battle Axe", "Blunt", 20),
                new Weapon("Glass", "Battle Axe", "Blunt", 22),
                new Weapon("Ebony", "Battle Axe", "Blunt", 24),
                new Weapon("Deadric", "Battle Axe", "Blunt", 26),
                
                // Adding the claymores to the weapons list
                new Weapon("Iron", "Claymore", "Blade", 12),
                new Weapon("Steel", "Claymore", "Blade", 14),
                new Weapon("Silver", "Claymore", "Blade", 16),
                new Weapon("Dwarven", "Claymore", "Blade", 18),
                new Weapon("Elvewn", "Claymore", "Blade", 20),
                new Weapon("Glass", "Clayore", "Blade", 22),
                new Weapon("Ebony", "Claymore", "Blade", 24),
                new Weapon("Deadric", "Claymore", "Blade", 26),

                // Adding the warhammers to the weapons list
                new Weapon("Iron", "Warhammer", "Blunt", 14),
                new Weapon("Steel", "Warhammer", "Blunt", 16),
                new Weapon("Silver", "Warhammer", "Blunt", 18),
                new Weapon("Dwarven", "Warhammer", "Blunt", 20),
                new Weapon("Elvewn", "Warhammer", "Blunt", 22),
                new Weapon("Glass", "Warhammer", "Blunt", 24),
                new Weapon("Ebony", "Warhammer", "Blunt", 26),
                new Weapon("Deadric", "Warhammer", "Blunt", 28),

                // Adding the bows to the weapons list
                new Weapon("Iron", "Bow", "Marksman", 8),
                new Weapon("Steel", "Bow", "Marksman", 9),
                new Weapon("Silver", "Bow", "Marksman", 10),
                new Weapon("Dwarven", "Bow", "Marksman", 12),
                new Weapon("Elvewn", "Bow", "Marksman", 14),
                new Weapon("Glass", "Bow", "Marksman", 16),
                new Weapon("Ebony", "Bow", "Marksman", 18),
                new Weapon("Deadric", "Bow", "Marksman", 20)
            };    
        }

        private void skillComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            if (skillComboBox.Text.Equals(BLADE)) {
                atLbl.Text = STRENGTH;
                atLbl.Show();
            }

            if(skillComboBox.Text.Equals(BLUNT)) {
                atLbl.Text = STRENGTH;
                atLbl.Show();
            }

            else if(skillComboBox.Text.Equals(MARKSMAN)) {
                atLbl.Text = AGILITY;
                atLbl.Show();
            }
        }

        public int calcDamage() {
                return (int)(weaponIterator.CurrentWeapon().getBaseDamage() * 0.5 *
                        (0.75 + int.Parse(attributeBox.Text) * 0.005) *
                        (0.2 + int.Parse(skillBox.Text) * 0.015));
        }

        private void goBtn_Click(object sender, EventArgs e) {

            int num;

            if((skillComboBox.Equals("Select a Skill") == false) 
               && Int32.TryParse(attributeBox.Text, out num) && Int32.TryParse(skillBox.Text, out num) 
               && int.Parse(attributeBox.Text) >= 0 && int.Parse(attributeBox.Text) <= 100
               && int.Parse(skillBox.Text) >= 0 && int.Parse(skillBox.Text) <= 100) {

                weaponListBox.Items.Clear();

                weaponIterator = weapons.CreateIterator(skillComboBox.Text);

                for(weaponIterator.FirstWeapon(); !weaponIterator.isDone(); weaponIterator.NextWeapon()) {

                    weaponListBox.Items.Add(weaponIterator.CurrentWeapon().getMaterial() + 
                                            " " + weaponIterator.CurrentWeapon().getType() + 
                                            ": " + calcDamage() + " damage");
                    weaponListBox.Items.Add("\n");
                }
            }
        }
    }
}
