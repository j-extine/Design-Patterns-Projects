using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GibsonGuitarsFactory {
    public partial class GuitarFactoryForm : Form {

        ConcreteGuitarFactory guitarFactory = new ConcreteGuitarFactory();
        AbstractGuitar guitar;

        // guitarComboBox members
        private const string LP = "Les Paul";
        private const string SG = "SG";
        private const string ES = "ES";
        private const string CS = "Archtop";
        private const string EX = "Explorer";
        private const string FB = "Firebird";
        private const string V = "Flying V";
        private const string RD = "RD";


        public GuitarFactoryForm() {
            InitializeComponent();
        }

        private void guitarComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            switch (guitarComboBox.Text) {
                case LP:
                    guitar = guitarFactory.CreateLP();
                    break;
                case SG:
                    guitar = guitarFactory.CreateSG();
                    break;
                case ES:
                    guitar = guitarFactory.CreateES();
                    break;
                case CS:
                    guitar = guitarFactory.CreateCS();
                    break;
                case EX:
                    guitar = guitarFactory.CreateEX();
                    break;
                case FB:
                    guitar = guitarFactory.CreateFB();
                    break;
                case V:
                    guitar = guitarFactory.CreateV();
                    break;
                case RD:
                    guitar = guitarFactory.CreateRD();
                    break;
                default:
                    break;
            }
            guitarDisplay.BackgroundImage = guitar.getGuitar;
        }
    }
}
