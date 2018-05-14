using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFacadeDemo {
    public partial class LibraryForm : Form {

        LibraryFunctions library;
        string bookTitle = null;

        public LibraryForm() {
            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e) {
            if (!bookTitleBox.Text.Equals(null)) {
                bookTitle = bookTitleBox.Text;
                library = new LibraryFunctions(bookTitle);
                library.borrowBook();
                bookTitleBox.Clear();
                borrowedBookLbl.Text = library.getBookInfo();
            }
        }

        private void renewBtn_Click(object sender, EventArgs e) {
            library.renewBook();
            borrowedBookLbl.Text = library.getBookInfo();
        }

        private void returnBtn_Click(object sender, EventArgs e) {
            library.returnBook();
            borrowedBookLbl.Text = null;
        }
    }
}
