using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibsonGuitarsFactory {
    abstract class AbstractGuitarFactory {
        public abstract AbstractGuitar CreateLP();
        public abstract AbstractGuitar CreateSG();
        public abstract AbstractGuitar CreateES();
        public abstract AbstractGuitar CreateCS();
        public abstract AbstractGuitar CreateEX();
        public abstract AbstractGuitar CreateFB();
        public abstract AbstractGuitar CreateV();
        public abstract AbstractGuitar CreateRD();
    }
}
