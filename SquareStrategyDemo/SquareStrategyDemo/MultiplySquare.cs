using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareStrategyDemo {
    class MultiplySquare : Square{

        public override string square(double x) {

            string result =  x + " x " + x + " = " + (x * x);

            return result;
        }
    }
}
