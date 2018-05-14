using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareStrategyDemo {
    class PowerSquare : Square{

        public override string square(double x) {

            string result = x + "\xB2" + " = " + Math.Pow(x, 2);

            return result;
        }
    }
}
