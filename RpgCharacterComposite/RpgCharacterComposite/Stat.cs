using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite {
    class Stat : RpgCharacterComponent {

        public Stat(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent stat) {
            throw new NotImplementedException();
        }

        public override void Remove(RpgCharacterComponent stat) {
            throw new NotImplementedException();
        }

        public override string toString() {
            return "\t" + name;
        }
    }
}
