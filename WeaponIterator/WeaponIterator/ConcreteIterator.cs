using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IEnumerable;

namespace WeaponIterator{
    class ConcreteIterator : Iterator {

        ConcreteAggregate weapons;
        string skill;
        int currentIndex = 0;

        public ConcreteIterator(ConcreteAggregate weapons, string skill) {
            this.weapons = weapons;
            this.skill = skill;
        }

        public override Weapon CurrentWeapon() {
            if (!isDone())
                return (Weapon)weapons[currentIndex];
            else
                throw new Exception();
        }

        public override void FirstWeapon() {
            while (!isDone() && CurrentWeapon().getSkill() != skill)
                currentIndex++;
        }

        public override bool isDone() {
            return (currentIndex == weapons.Count);
        }

        public override void NextWeapon() {

            currentIndex++;

            while (!isDone()) {
                if (!(CurrentWeapon().getSkill() == skill))
                    currentIndex++;
                else
                    break;
            }
        }
    }
}
