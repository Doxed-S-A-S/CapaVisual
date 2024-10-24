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

        private void button4_Click(object sender, EventArgs e)
        {

        }


        
    }
}
