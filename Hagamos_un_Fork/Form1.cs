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
        // Cambio para hacer un pull request desde GitHub
            lblResultado.Text = "Nos quitan de las manos los Pull Request";
            lblIntro.Text = txtIntro.Text;
        }
    }
}
