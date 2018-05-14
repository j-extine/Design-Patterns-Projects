using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite{
    class CharacterDescription : RpgCharacterComponent{

        public CharacterDescription(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent description) {
            throw new NotImplementedException();
        }

        public override void Remove(RpgCharacterComponent description) {
            throw new NotImplementedException();
        }

        public override string toString() {
            return "\n\t" + name + "\n";
        }
    }
}
