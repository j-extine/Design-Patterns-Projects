using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibsonGuitarsFactory {
    class ConcreteGuitarFactory : AbstractGuitarFactory {
        public override AbstractGuitar CreateLP() {
            return new LPGuitar();
        }

        public override AbstractGuitar CreateSG() {
            return new SGGuitar();
        }

        public override AbstractGuitar CreateES() {
            return new ESGuitar();
        }

        public override AbstractGuitar CreateCS() {
            return new CSGuitar();
        }

        public override AbstractGuitar CreateEX() {
            return new EXGuitar();
        }

        public override AbstractGuitar CreateFB() {
            return new FBGuitar();
        }

        public override AbstractGuitar CreateV() {
            return new VGuitar();
        }

        public override AbstractGuitar CreateRD() {
            return new RDGuitar();
        }
    }
}
