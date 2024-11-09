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

        public void ComentarioDialog_load()
        {
            richTxtBoxCircularcs comentario = new richTxtBoxCircularcs();
            comentario.MakeCircularRichTextBox(txtCrearComentario, 50);

            pboxCircular pbox = new pboxCircular();
            pbox.MakeCircularPictureBox(pboxPerfilComentario);

            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            pboxPerfilComentario.Load(app.ImagenPerfil);
        }

        public Panel PanelContendorDePost
        {
            get { return panelContendorDePost; }
        }
    }
}
