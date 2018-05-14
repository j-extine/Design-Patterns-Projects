using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareStrategyDemo {
    public partial class SquareForm : Form {

        Square square;
        const string POW = "Power";
        const string MULT = "Multiply";


        public SquareForm() {
            InitializeComponent();
        }

        private void squareBtn_Click(object sender, EventArgs e) {

            if (Double.TryParse(inputTb.Text, out double result)) {

                switch (stratCb.Text) {

                    case POW:
                        square = new PowerSquare();
                        resultLbl.Text = square.square(Double.Parse(inputTb.Text));
                        break;

                    case MULT:
                        square = new MultiplySquare();
                        resultLbl.Text = square.square(Double.Parse(inputTb.Text));
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
