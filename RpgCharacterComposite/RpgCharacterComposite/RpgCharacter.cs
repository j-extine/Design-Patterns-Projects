using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite{
    class RpgCharacter : RpgCharacterComponent {

        List<RpgCharacterComponent> characterComposite = new List<RpgCharacterComponent>();

        public RpgCharacter(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent component) {
            characterComposite.Add(component);
        }

        public override void Remove(RpgCharacterComponent component) {
            characterComposite.Remove(component);
        }

        public override string toString() {

            name += "\n";

            foreach(RpgCharacterComponent component in characterComposite) {
                name += component.toString() + "\n";
            }

            return name;
        }
    }
}
