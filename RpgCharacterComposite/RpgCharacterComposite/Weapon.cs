using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite{
    class Weapon : RpgCharacterComponent {

        public Weapon(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent weapon) {
            throw new NotImplementedException();
        }

        public override void Remove(RpgCharacterComponent weapon) {
            throw new NotImplementedException();
        }

        public override string toString() {
            return "\t\t" + name;
        }
    }
}
