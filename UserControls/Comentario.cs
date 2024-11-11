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
    public partial class Comentario : UserControl
    {
        public Comentario()
        {
            InitializeComponent();
        }

        public string usuarioComentario
        {
            get { return txtUsuarioComentario.Text; }
            set { txtUsuarioComentario.Text = value; }
        }

        public string fechayhora
        {
            get { return txtFechaComentario.Text; }
            set { txtFechaComentario.Text = value; }
        }

        public string ProfileImage
        {
            //get { return pboxPerfilComentario.value; }
            set { pboxPerfilComentario.Load(value); }
        }

        public string Contenido
        {
            //get { return pboxPerfilComentario.value; }
            set { txtContenidoComentario.Text = value; }
        }

        public int likeCount
        {
            //get { return txtLikeCount.Text; }
            set { txtLikeCount.Text = value.ToString(); }
        }

        public int id_cuenta_comentador
        {
            get { return id_cuenta_comentador; }
            set { id_cuenta_comentador = value; }
        }
    }
}
