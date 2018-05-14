using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite {
    class Armor : RpgCharacterComponent{

        public Armor(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent armor)
        {
            throw new NotImplementedException();
        }

        public override void Remove(RpgCharacterComponent armor)
        {
            throw new NotImplementedException();
        }

        public override string toString() {
            return "\t\t" + name;
        }
    }
}
