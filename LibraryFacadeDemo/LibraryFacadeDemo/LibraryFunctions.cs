using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeDemo {
    class LibraryFunctions {

        private BorrowedBook book;

        // subsystem
        private BorrowBook borrow;
        private RenewBook renew;
        private ReturnBook returnIt;

        private string bookTitle;

        public LibraryFunctions(string bookTitle) {

            borrow = new BorrowBook();
            renew = new RenewBook();
            returnIt = new ReturnBook();
            this.bookTitle = bookTitle;

        }

        public void borrowBook() {
            book = borrow.borrow(bookTitle);
        }

        public void renewBook() {
            renew.renew(book);
        }

        public void returnBook() {
            returnIt.returnIt(book);
        }

        public string getBookInfo() {
            return book.getInfo();
        }
    }
}
