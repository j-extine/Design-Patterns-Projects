using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponIterator {
    class ConcreteAggregate : Aggregate {

        public override Iterator CreateIterator(string skill) {

            Iterator weaponIterator = new ConcreteIterator(this, skill);

            return weaponIterator;
        }
    }
}
