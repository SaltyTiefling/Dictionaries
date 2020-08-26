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
    public partial class Oef01 : Form
    {
        Dictionary<int, string> nummers = new Dictionary<int, string>();
        public Oef01()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNummer.Text = cbNummers.SelectedValue.ToString();
        }

        private void oef01_Load(object sender, EventArgs e)
        {
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

            cbNummers.DataSource = new BindingSource(nummers, null);
            cbNummers.DisplayMember = "Key";
            cbNummers.ValueMember = "Value";

            lblNummer.Text = cbNummers.SelectedValue.ToString();
        }
    }
}
