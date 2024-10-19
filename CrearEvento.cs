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
    public partial class CrearEvento : UserControl
    {
        public CrearEvento()
        {
            InitializeComponent();

            InitializeComponent();
            panelImagenVideo.Visible = false;

            pboxImagenVideo.DragEnter += new DragEventHandler(pboxImagenVideo_DragEnter);
            pboxImagenVideo.DragDrop += new DragEventHandler(pboxImagenVideo_DragDrop);

            pboxImagenVideo.AllowDrop = true;
            pboxImagenVideo.SizeMode = PictureBoxSizeMode.Zoom;


            txtLinkCrearPost.Text = "Pegue el enlace aquí";
            txtLinkCrearPost.ForeColor = Color.Gray;
        }

        private void pboxImagenVideo_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos != null && archivos.Length > 0)
            {
                btnBrowse.Visible = false;
                lblAñadirImagen.Visible = false;
                pboxImagenVideo.Image = Image.FromFile(archivos[0]);
                pboxImagenVideo.ImageLocation = archivos[0];

                string sourceFilePath = archivos[0];

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destFolderPath = Path.Combine(projectDirectory, "Uploads");
                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);

                MessageBox.Show("Imagen subida exitosamente y guardada en: " + destFilePath);
            }
        }

        private void pboxImagenVideo_DragEnter(object sender, DragEventArgs e)
        {

        }

        private string ObtenerTipoContenidoSeleccionado(ToolStripMenuItem btnTipoContenido)
        {

            foreach (ToolStripItem item in btnTipoContenido.DropDownItems)
            {

                if (item is ToolStripMenuItem subItem && subItem.Checked)
                {
                    return subItem.Text;
                }
            }
            return string.Empty;
        }

        private void botonPostear_Click(object sender, EventArgs e)
        {

        }

        private void txtLinkCrearPost_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearPost.Text))
            {
                txtLinkCrearPost.Text = "Pegue el enlace aquí";
                txtLinkCrearPost.ForeColor = Color.Gray;
            }
        }

        private void txtLinkCrearPost_Enter(object sender, EventArgs e)
        {
            if (txtLinkCrearPost.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearPost.Text = "";
                txtLinkCrearPost.ForeColor = Color.Black;
            }
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pboxImagenVideo.BackColor = Color.LightGray;
            panelTextoPost.Visible = true;
            panelImagenVideo.Visible = false;
        }

        private void btnImagenVideo_Click(object sender, EventArgs e)
        {
            panelTextoPost.Visible = false;
            panelImagenVideo.Visible = true;
        }
    }
}
