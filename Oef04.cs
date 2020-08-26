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
        }

        private string maakWoord(decimal nummer)
        {
            string woord = "";

            if (nummer <= 0)
            {
                return nummers[0];
            }

            for (int i = 1; i <= nummer; i++)
            {
                woord += nummers[i];
            }

            return woord;
        }

        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            lblNummer.Text = maakWoord(numNumber.Value);
        }
    }
}
