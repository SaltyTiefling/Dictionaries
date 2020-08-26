using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionaries
{
    public partial class Oef04 : Form
    {
        Dictionary<int, string> nummers = new Dictionary<int, string>();
        public Oef04()
        {
            InitializeComponent();
        }

        private void Oef04_Load(object sender, EventArgs e)
        {
            nummers.Add(0, "nul");
            nummers.Add(1, "één");
            nummers.Add(2, "twee");
            nummers.Add(3, "drie");
            nummers.Add(4, "vier");
            nummers.Add(5, "vijf");
            nummers.Add(6, "zes");
            nummers.Add(7, "zeven");
            nummers.Add(8, "acht");
            nummers.Add(9, "negen");
            nummers.Add(10, "tien");
            nummers.Add(11, "elf");
            nummers.Add(12, "twaalf");
            nummers.Add(13, "dertien");
            nummers.Add(14, "veertien");
            nummers.Add(20, "twintig");
            nummers.Add(30, "dertig");
            nummers.Add(40, "veertig");
            nummers.Add(50, "vijftig");
            nummers.Add(60, "zestig");
            nummers.Add(70, "zeventig");
            nummers.Add(80, "tachtig");
            nummers.Add(90, "negentig");
            nummers.Add(100, "honderd");
            nummers.Add(1000, "duizend");
            nummers.Add(1000000, "miljoen");
            nummers.Add(1000000000, "miljard");

            numNumber.Value = 400017053977;
        }

        private string maakWoord(decimal nummer)
        {
            string woord = "";
            while (nummer > 0)
            {
                if (nummer == 1)
                {
                    woord += nummers[(int)nummer];
                    nummer -= nummer;
                }
                else if (nummer >=2 && nummer < 100)
                {
                    woord += tweeTotHonderd(nummer);
                    nummer -= nummer;
                }
                else if (nummer >= 100 && nummer < 1000)
                {
                    //honderd
                    int honderd = 100;
                    woord += tweeTotHonderd(nummer / honderd);
                    woord += nummers[honderd] + " ";
                    nummer = nummer % honderd;
                }
                else if (nummer >= 1000 && nummer < 1000000)
                {
                    //duizend
                    int duizend = 1000;
                    woord += maakWoord(nummer / duizend);
                    woord += nummers[duizend] + " ";
                    nummer = nummer % duizend;
                }
                else if (nummer >= 1000000 && nummer < 1000000000)
                {
                    //miljoen
                    int miljoen = 1000000;
                    woord += maakWoord(nummer / miljoen);
                    woord += " " + nummers[miljoen] + " ";
                    nummer = nummer % miljoen;
                }
                else if (nummer >= 1000000000 && nummer < 1000000000000000000)
                {
                    //miljard
                    int miljard = 1000000000;
                    woord += maakWoord(nummer / miljard);
                    woord += " " + nummers[miljard] + " ";
                    nummer = nummer % miljard;
                }
                else
                {
                    woord += maakWoord(nummer / 1000000000000000000);
                    nummer = 0;
                }

            }

            return woord;
        }

        private string tweeTotHonderd(decimal nummer)
        {
            string answer = "";
            while (nummer >= 2)
            {
                if (nummer <= 14)
                {
                    answer = nummers[(int)nummer] + answer;
                    nummer -= nummer;
                }
                else if (nummer < 100)
                {
                    answer += nummers[(int)(nummer - (nummer % 10))];
                    nummer = (nummer % 10);
                    if (nummer > 0)
                    {
                        if (nummers[(int)nummer].ToCharArray().Last() == 'e')
                        {
                            answer = "ën" + answer;
                        }
                        else
                        {
                            answer = "en" + answer;

                        }
                    }
                }
            }
            return answer;

        }

        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            
            lblNummer.Text = (numNumber.Value == 0)? nummers[0] : maakWoord(numNumber.Value);
        }
    }
}
