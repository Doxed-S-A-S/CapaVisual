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
    public partial class PostCard : UserControl
    {
        public PostCard()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return lblUsername.Text; }
            set { lblUsername.Text = value; }
        }

        public string PostContent
        {
            get { return txtContenidoPost.Text; }
            set { txtContenidoPost.Text = value; }
        }

        public Image ProfileImage
        {
            get { return pictureBoxFotoPerfilPost.Image; }
            set { pictureBoxFotoPerfilPost.Image = value; }
        }

        public Image PostImage
        {
            get { return pictureBoxImagenPost.Image; }
            set { pictureBoxImagenPost.Image = value; }
        }

        public int id_post { get; set; }
        public PostCard Clone()
        {
            PostCard clone = new PostCard();
            clone.UserName = this.UserName;
            clone.PostContent = this.PostContent;
            clone.ProfileImage = this.ProfileImage;
            clone.PostImage = this.PostImage;
            clone.id_post = this.id_post;

            clone.Size = this.Size;
            clone.Height = 276;
            clone.Font = this.Font;
            clone.BackColor = this.BackColor;

            return clone;
        }
        private void btnCompartir_Click(object sender, EventArgs e)
        {
            SeleccionDeCompartida seleccion = new SeleccionDeCompartida();
            seleccion.id_post = this.id_post;
            seleccion.StartPosition = FormStartPosition.CenterScreen;
            seleccion.Show();
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            ComentarioDialog comentarios = new ComentarioDialog();
            comentarios.ComentarioDialog_load();
            PostCard postAComentar = new PostCard();
            postAComentar = this.Clone();

            comentarios.StartPosition = FormStartPosition.CenterScreen;
            comentarios.Show();
            comentarios.Activate();
            comentarios.BringToFront();
            comentarios.PanelContendorDePost.Controls.Add(postAComentar);


        }
    }
}
