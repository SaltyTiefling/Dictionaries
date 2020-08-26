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
    public partial class Oef02Add : Form
    {
        public string nederlands;
        public string engels;
        public Oef02Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nederlands = txtNederlands.Text;
            engels = txtEngels.Text;

            DialogResult = DialogResult.OK;
        }

        private void Oef02Add_Load(object sender, EventArgs e)
        {

        }
    }
}
