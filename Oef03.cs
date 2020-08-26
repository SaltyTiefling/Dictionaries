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
    public partial class Oef03 : Form
    {
        Dictionary<string, string[]> nederlandseVertaling = new Dictionary<string, string[]>();
        public Oef03()
        {
            InitializeComponent();
        }

        private void Oef03_Load(object sender, EventArgs e)
        {
            nederlandseVertaling.Add("Ik", new string[] { "I", "Ich", "Watashi (私)", "Je", "Jag" });
            nederlandseVertaling.Add("Hond", new string[] { "dog", "Hund", "Inu (犬)", "Chien", "Hund" });
            nederlandseVertaling.Add("Kat", new string[] { "Cat", "Katze", "Neko (ネコ)", "Chat", "Katt" });
            nederlandseVertaling.Add("Huis", new string[] { "House", "Haus", "Le (家)", "Maison", "Hus" });
            nederlandseVertaling.Add("Leerkracht", new string[] { "Teacher", "Lehrer", "Sensei (先生)", "Professeur", "Lärare" });

            laadCb();
        }
        private void laadCb()
        {
            cbNederlands.DataSource = new BindingSource(nederlandseVertaling, null);
            cbNederlands.DisplayMember = "Key";
            laadLbls();
        }
        public void laadLbls()
        {
            if (nederlandseVertaling.ContainsKey(cbNederlands.Text))
            {
                lblEngels.Text = nederlandseVertaling[cbNederlands.Text][0];
                lblDuits.Text = nederlandseVertaling[cbNederlands.Text][1];
                lblJapans.Text = nederlandseVertaling[cbNederlands.Text][2];
                lblFrans.Text = nederlandseVertaling[cbNederlands.Text][3];
                lblZweeds.Text = nederlandseVertaling[cbNederlands.Text][4];
            }
        }

        private void cbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            laadLbls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oef03Add oef03Add = new Oef03Add();
            if (oef03Add.ShowDialog() == DialogResult.OK)
            {
                nederlandseVertaling.Add(oef03Add.nederlands, new string[]
                {
                    oef03Add.engels,
                    oef03Add.duits,
                    oef03Add.japans,
                    oef03Add.frans,
                    oef03Add.zweeds
                });
            }
            laadCb();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            nederlandseVertaling.Remove(cbNederlands.Text);
            laadCb();
        }
    }
}
