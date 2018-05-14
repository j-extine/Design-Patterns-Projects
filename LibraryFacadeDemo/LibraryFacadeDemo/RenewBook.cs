using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeDemo {
    class RenewBook {

        private const int RENEWAL = 5;

        public void renew(BorrowedBook book) {
            book.setDaysToKeep(book.getDaysToKeep() + RENEWAL);
        }
    }
}
