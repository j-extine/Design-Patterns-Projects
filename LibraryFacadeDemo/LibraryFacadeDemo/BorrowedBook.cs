using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeDemo {
    class BorrowedBook {

        private string title;
        private int daysToKeep;


        public BorrowedBook(string title) {
            this.title = title;
            daysToKeep = 5;
        }

        public string getInfo() {
            return "Book: " + title + "\nReturn in " + daysToKeep + " days.";
        }

        public int getDaysToKeep() {
            return daysToKeep;
        }

        public void setDaysToKeep(int daysToKeep) {
            this.daysToKeep = daysToKeep;
        }
    }
}
