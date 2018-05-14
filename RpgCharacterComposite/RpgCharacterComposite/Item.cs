using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite{
    class Item : RpgCharacterComponent {

        public Item(string name) : base(name) {
        }

        public override void Add(RpgCharacterComponent item)
        {
            throw new NotImplementedException();
        }

        public override void Remove(RpgCharacterComponent item)
        {
            throw new NotImplementedException();
        }

        public override string toString() {
            return "\t\t" + name;
        }
    }
}
