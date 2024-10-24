using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            panelImagenVideoCrearEvento.Visible = false;

            pboxImagenVideoCrearEvento.DragEnter += new DragEventHandler(pboxImagenVideo_DragEnter);
            pboxImagenVideoCrearEvento.DragDrop += new DragEventHandler(pboxImagenVideo_DragDrop);

            pboxImagenVideoCrearEvento.AllowDrop = true;
            pboxImagenVideoCrearEvento.SizeMode = PictureBoxSizeMode.Zoom;

            txtNombreCrearEvento.Text = "Inserte un nombre para el evento";
            txtNombreCrearEvento.ForeColor = Color.Gray;

            txtLinkCrearEvento.Text = "Pegue el enlace aquí";
            txtLinkCrearEvento.ForeColor = Color.Gray;

            txtContenidoEvento.Text = "Ingrese el contenido de su evento aqui...";
            txtContenidoEvento.ForeColor = Color.Gray;

            txtDescripcionEvento.Text = "Ingrese la descripcion de su evento aqui...";
            txtDescripcionEvento.ForeColor = Color.Gray;

        }

        private void pboxImagenVideo_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos != null && archivos.Length > 0)
            {
                btnBrowseCrearEvento.Visible = false;
                lblAñadirImagenCrearEvento.Visible = false;
                pboxImagenVideoCrearEvento.Image = Image.FromFile(archivos[0]);
                pboxImagenVideoCrearEvento.ImageLocation = archivos[0];

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
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
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
            if (string.IsNullOrWhiteSpace(txtLinkCrearEvento.Text))
            {
                txtLinkCrearEvento.Text = "Pegue el enlace aquí";
                txtLinkCrearEvento.ForeColor = Color.Gray;
            }
        }

        private void txtLinkCrearPost_Enter(object sender, EventArgs e)
        {
            if (txtLinkCrearEvento.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearEvento.Text = "";
                txtLinkCrearEvento.ForeColor = Color.Black;
            }
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenidoEvento.Visible = true;
            panelImagenVideoCrearEvento.Visible = false;
            panelDescripcionEvento.Visible = false;
        }

        private void btnImagenVideo_Click(object sender, EventArgs e)
        {
            panelContenidoEvento.Visible = false;
            panelDescripcionEvento.Visible = false;
            panelImagenVideoCrearEvento.Visible = true;
        }

        private void btnDescripcionEvento_Click(object sender, EventArgs e)
        {
            panelContenidoEvento.Visible = false;
            panelDescripcionEvento.Visible = true;
            panelImagenVideoCrearEvento.Visible = false;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                pboxImagenVideoCrearEvento.Image = Image.FromFile(dialog.FileName);
                pboxImagenVideoCrearEvento.ImageLocation = dialog.FileName;
                lblAñadirImagenCrearEvento.Visible = false;
                btnBrowseCrearEvento.Visible = false;

                string sourceFilePath = dialog.FileName;

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destFolderPath = Path.Combine(projectDirectory, "Uploads");
                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);

                MessageBox.Show("Imagen subida exitosamente y guardada en: " + destFilePath);

            }
        }

        private void txtLinkCrearEvento_MouseHover(object sender, EventArgs e)
        {
            if (txtLinkCrearEvento.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearEvento.Text = "";
                txtLinkCrearEvento.ForeColor = Color.Black;
            }
        }

        private void txtLinkCrearEvento_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearEvento.Text))
            {
                txtLinkCrearEvento.Text = "Pegue el enlace aquí";
                txtLinkCrearEvento.ForeColor = Color.Gray;
            }
        }
        private void txtNombreCrearEvento_MouseHover(object sender, EventArgs e)
        {
            if (txtNombreCrearEvento.Text == "Inserte un nombre para el evento")
            {
                txtNombreCrearEvento.Text = "";
                txtNombreCrearEvento.ForeColor = Color.Black;
            }
        }

        private void txtNombreCrearEvento_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearEvento.Text))
            {
                txtNombreCrearEvento.Text = "Inserte un nombre para el evento";
                txtNombreCrearEvento.ForeColor = Color.Gray;
            }
        }

        private void txtDescripcionEvento_MouseHover(object sender, EventArgs e)
        {
            if (txtDescripcionEvento.Text == "Ingrese la descripcion de su evento aqui...")
            {
                txtDescripcionEvento.Text = "";
                txtDescripcionEvento.ForeColor = Color.Black;
            }
        }

        private void txtDescripcionEvento_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionEvento.Text))
            {
                txtDescripcionEvento.Text = "Ingrese la descripcion de su evento aqui...";
                txtDescripcionEvento.ForeColor = Color.Gray;
            }
        }

        private void txtContenidoEvento_MouseHover(object sender, EventArgs e)
        {
            if (txtContenidoEvento.Text == "Ingrese el contenido de su evento aqui...")
            {
                txtContenidoEvento.Text = "";
                txtContenidoEvento.ForeColor = Color.Black;
            }
        }

        private void txtContenidoEvento_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContenidoEvento.Text))
            {
                txtContenidoEvento.Text = "Ingrese el contenido de su evento aqui...";
                txtContenidoEvento.ForeColor = Color.Gray;
            }
        }

    }
}
