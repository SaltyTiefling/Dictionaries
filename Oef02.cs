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
    public partial class Oef02 : Form
    {
        Dictionary<string, string> nederlandsEngels = new Dictionary<string, string>();
        public Oef02()
        {
            InitializeComponent();
        }

        private void cbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEngels.Text = cbNederlands.SelectedValue.ToString();
        }

        private void Oef02_Load(object sender, EventArgs e)
        {
            nederlandsEngels.Add("ik", "I");
            nederlandsEngels.Add("hond", "dog");
            nederlandsEngels.Add("kat", "Cat");
            nederlandsEngels.Add("huis", "house");
            nederlandsEngels.Add("leerkracht", "teacher");

            LaadCb();
        }

        private void LaadCb()
        {
            cbNederlands.DataSource = new BindingSource(nederlandsEngels, null);
            cbNederlands.DisplayMember = "Key";
            cbNederlands.ValueMember = "Value";

            lblEngels.Text = cbNederlands.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oef02Add oef02Add = new Oef02Add();

            if (oef02Add.ShowDialog() == DialogResult.OK)
            {
                nederlandsEngels.Add(oef02Add.nederlands,oef02Add.engels);
                LaadCb();
            }
        }
    }
}
