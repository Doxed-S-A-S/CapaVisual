using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual.UserControls
{
    public partial class DondeCompartir : UserControl
    {
        public DondeCompartir()
        {
            InitializeComponent();
        }

        private void btnCompartirGrupo_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            CompartirPostDialog dialog = new CompartirPostDialog();
            dialog.Show();
        }
    }
}
