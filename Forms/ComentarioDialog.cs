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
    public partial class ComentarioDialog : Form
    {
        public ComentarioDialog()
        {
            InitializeComponent();
        }

        public Panel PanelContendorDePost
        {
            get { return panelContendorDePost; }
        }
    }
}
