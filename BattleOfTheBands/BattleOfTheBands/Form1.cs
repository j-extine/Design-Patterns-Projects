using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleOfTheBands{
    public partial class BattleOfTheBandsForm : Form{
        public BattleOfTheBandsForm()
        {
            InitializeComponent();
        }

        private void pilotsBtn_Click(object sender, EventArgs e){
            Winner.setWinner("Twenty One Pilots");
            resultLbl.Text = "And the Winner is " + Winner.getName() + "!";
        }

        private void metallicsBtn_Click(object sender, EventArgs e){
            Winner.setWinner("Metallica");
            resultLbl.Text = "And the Winner is " + Winner.getName() + "!";
        }

        private void beyonceBtn_Click(object sender, EventArgs e){
            Winner.setWinner("Beyonce");
            resultLbl.Text = "And the Winner is " + Winner.getName() + "!";
        }
    }
}
