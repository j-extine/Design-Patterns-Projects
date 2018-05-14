using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeDemo {
    class ReturnBook {

        public void returnIt(BorrowedBook book) {
            book = null;
        }
    }
}
