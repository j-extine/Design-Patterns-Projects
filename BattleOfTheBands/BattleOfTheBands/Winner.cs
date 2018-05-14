using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheBands{
    class Winner{

        private static Winner winner;
        private static string bandName;

        private Winner(string band){
            bandName = band;
        }

        public static void setWinner(string band){
            if (winner == null)
                winner = new Winner(band);
        }

        public static Winner getWinner(){
            return winner;
        }

        public static string getName(){
            return bandName;
        }
    }
}
