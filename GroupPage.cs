using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class GroupPage : UserControl
    {
        public GroupPage()
        {
            InitializeComponent();
        }
        public Image ImagenGrupo
        {
            get { return pboxImagenGrupo.Image; }
            set { pboxImagenGrupo.Image = value; }
        }
        public Image BannerGrupo
        {
            get { return pboxBannerGrupo.Image; }
            set { pboxBannerGrupo.Image = value; }
        }

        public string DescripcionGrupo
        {
            get { return txtBoxDescripcionGrupo.Text; }
            set { txtBoxDescripcionGrupo.Text = value; }
        }
        public DataTable IntegrantesGrupo
        {
            get => (DataTable)dataGridIntegrantesGrupo.DataSource;
            set => dataGridIntegrantesGrupo.DataSource = value;
        }
    }
}
