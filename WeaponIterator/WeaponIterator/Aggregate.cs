using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponIterator{
    public  abstract class Aggregate : List<object>{

        public abstract Iterator CreateIterator(string weaponType);
    }
}
