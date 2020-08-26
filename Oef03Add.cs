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
    public partial class Oef03Add : Form
    {
        public string nederlands;
        public string engels;
        public string duits;
        public string japans;
        public string frans;
        public string zweeds;

        public Oef03Add()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            nederlands = txtNederlands.Text;
            engels = txtEngels.Text;
            duits = txtDuits.Text;
            japans = txtJapans.Text;
            frans = txtFrans.Text;
            zweeds = txtZweeds.Text;

            if (!Errors())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void Oef03Add_Load(object sender, EventArgs e)
        {
            Errors();
        }

        private bool Errors()
        {
            if (txtNederlands.Text == "")
            {
                epnederlands.SetError(txtNederlands, "geef je grondwoord in");
                return true;
            }
            else
            {
                epnederlands.Clear();
            }
            return false;
        }

        private void txtNederlands_TextChanged(object sender, EventArgs e)
        {
            Errors();
        }
    }
}
