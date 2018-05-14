using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponIterator{
    public abstract class Iterator{

        public abstract void FirstWeapon();
        public abstract void NextWeapon();
        public abstract bool isDone();
        public abstract Weapon CurrentWeapon();
    }
}
