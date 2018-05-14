using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterComposite {
    abstract class RpgCharacterComponent {

        protected string name;

        public RpgCharacterComponent(string name) {
            this.name = name;
        }

        public abstract void Add(RpgCharacterComponent component);
        public abstract void Remove(RpgCharacterComponent component);
        public abstract string toString();
    }
}
