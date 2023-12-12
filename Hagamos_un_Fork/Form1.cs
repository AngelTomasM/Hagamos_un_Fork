using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagamos_un_Fork
{
    public partial class Hagamos_un_Fork : Form
    {
        public Hagamos_un_Fork()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Ya van llegando los Pull Request";
            lblIntro.Text = txtIntro.Text;
        }
    }
}
