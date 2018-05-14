using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite {
    class Gear : RpgCharacterComponent {

        List<RpgCharacterComponent> gearList = new List<RpgCharacterComponent>();

        public Gear(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent gear) {
            gearList.Add(gear);
        }

        public override void Remove(RpgCharacterComponent gear) {
            gearList.Remove(gear);
        }

        public override string toString() {


            name = "\t" + name + "\n" ;

            foreach (RpgCharacterComponent component in gearList)
            {
                name += component.toString() + "\n";
            }

            return name;
        }
    }
}
