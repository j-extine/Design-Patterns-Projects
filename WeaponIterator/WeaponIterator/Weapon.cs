using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponIterator{
    public class Weapon{

        private string Type;
        private string Material;
        private string skill;
        private int BaseDamage;
        

        public Weapon(string Material, string Type, string skill, int BaseDamage){
            this.Material = Material;
            this.Type = Type;
            this.skill = skill;
            this.BaseDamage = BaseDamage;
        }

        public string getType() {
            return Type;
        }

        public string getMaterial() {
            return Material;
        }

        public string getSkill() {
            return skill;
        }

        public int getBaseDamage() {
            return BaseDamage;
        }
    }
}
