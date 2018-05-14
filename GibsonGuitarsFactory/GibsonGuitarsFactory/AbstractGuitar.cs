using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibsonGuitarsFactory {
    abstract class AbstractGuitar {

        private Image guitar;

        public Image Guitar{
            set {
                this.guitar = value;
            }

            get {
                return guitar;
            }
        }

        public abstract Image getGuitar {
            get;
        }
    }
}
