using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeDemo {
    class BorrowBook {

        public BorrowedBook borrow(string bookTitle) {
            BorrowedBook book = new BorrowedBook(bookTitle);
            return book;
        }
    }
}
