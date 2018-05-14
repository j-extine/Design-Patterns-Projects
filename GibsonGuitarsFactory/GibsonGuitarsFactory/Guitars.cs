using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibsonGuitarsFactory {

    // Guitar class that creates the Les Paul
    class LPGuitar : AbstractGuitar {
        public LPGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\LP.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the SG
    class SGGuitar : AbstractGuitar {
        public SGGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\SG.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the ES
    class ESGuitar : AbstractGuitar {
        public ESGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\ES.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the Archtop
    class CSGuitar : AbstractGuitar {
        public CSGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\CS.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the Explorer
    class EXGuitar : AbstractGuitar {
        public EXGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\EX.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the Firebird
    class FBGuitar : AbstractGuitar {
        public FBGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\FB.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the Flying V
    class VGuitar : AbstractGuitar {
        public VGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\V.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }

    // Guitar class that creates the RD
    class RDGuitar : AbstractGuitar {
        public RDGuitar() {
            Guitar = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"Images\RD.jpg"));
        }
        public override Image getGuitar {
            get { return Guitar; }
        }
    }
}