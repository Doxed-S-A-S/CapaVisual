using RestSharp;
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
    public partial class CrearPost : UserControl
    {
        public CrearPost()
        {
            InitializeComponent();
            panelImagenVideo.Visible = false;

            pboxImagenVideo.DragEnter += new DragEventHandler(pboxImagenVideo_DragEnter_1);
            pboxImagenVideo.DragDrop += new DragEventHandler(pboxImagenVideo_DragDrop_1);

            pboxImagenVideo.AllowDrop = true;
            pboxImagenVideo.SizeMode = PictureBoxSizeMode.Zoom;


            txtLinkCrearPost.Text = "Pegue el enlace aquí";
            txtLinkCrearPost.ForeColor = Color.Gray;

            comBoxSeleccionarGrupo.ForeColor = Color.Gray;
        }

        private void crearPost(string url_contenido, string tipo_contenido, string contenido, string url_imagen, int id_cuenta)
        {

            RestClient client = new RestClient("http://localhost:44331/");


            RestRequest request = new RestRequest("ApiPost/post/crear/", Method.Post);


            request.AddFile("imagencita", url_imagen);


            request.AddParameter("url_contenido", url_contenido);
            request.AddParameter("tipo_contenido", tipo_contenido);
            request.AddParameter("contenido", contenido);
            request.AddParameter("id_cuenta", id_cuenta.ToString());

            RestResponse response = client.Execute(request);


            if (response.IsSuccessful)
            {
                MessageBox.Show("Post creado exitosamente.");
                limpiarCreadorDePost();
            }
            else
            {

                MessageBox.Show($"Error al crear el post: {response.StatusCode} - {response.ErrorMessage}");
            }
        }


        private void limpiarCreadorDePost()
        {
            mainPage1 mainPage = (mainPage1)this.Parent.Parent;
            mainPage.EliminarCrearPost();
            mainPage.AgregarCrearPost();

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



        
        

        private void pboxImagenVideo_DragDrop_1(object sender, DragEventArgs e)
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

        private void botonPostear_Click_1(object sender, EventArgs e)
        {
            crearPost(txtLinkCrearPost.Text, ObtenerTipoContenidoSeleccionado(btnTipoContenido), txtContenidoPost.Text, pboxImagenVideo.ImageLocation, 1);
        }

        private void comBoxSeleccionarGrupo_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comBoxSeleccionarGrupo.Text))
            {
                comBoxSeleccionarGrupo.Text = "Seleccione el grupo";
                comBoxSeleccionarGrupo.ForeColor = Color.Gray;
            }
        }

        private void comBoxSeleccionarGrupo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comBoxSeleccionarGrupo.SelectedIndex != -1)
            {

                comBoxSeleccionarGrupo.ForeColor = Color.Black;
            }
        }

        private void comBoxSeleccionarGrupo_DropDown_1(object sender, EventArgs e)
        {
            comBoxSeleccionarGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSeleccionarGrupo.ForeColor = Color.Black;
            if (comBoxSeleccionarGrupo.Text == "Seleccione el grupo")
            {

                comBoxSeleccionarGrupo.Text = "";
            }
        }

        private void txtLinkCrearPost_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearPost.Text))
            {
                txtLinkCrearPost.Text = "Pegue el enlace aquí";
                txtLinkCrearPost.ForeColor = Color.Gray;
            }
        }

        private void txtLinkCrearPost_Enter_1(object sender, EventArgs e)
        {
            if (txtLinkCrearPost.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearPost.Text = "";
                txtLinkCrearPost.ForeColor = Color.Black;
            }
        }

        private void contenidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pboxImagenVideo.BackColor = Color.LightGray;
            panelTextoPost.Visible = true;
            panelImagenVideo.Visible = false;
        }

        private void btnImagenVideo_Click_1(object sender, EventArgs e)
        {
            panelTextoPost.Visible = false;
            panelImagenVideo.Visible = true;
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                pboxImagenVideo.Image = Image.FromFile(dialog.FileName);
                pboxImagenVideo.ImageLocation = dialog.FileName;
                lblAñadirImagen.Visible = false;
                btnBrowse.Visible = false;

                string sourceFilePath = dialog.FileName;

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destFolderPath = Path.Combine(projectDirectory, "Uploads");
                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);

                MessageBox.Show("Imagen subida exitosamente y guardada en: " + destFilePath);

            }
        }

        private void pboxImagenVideo_DragEnter_1(object sender, DragEventArgs e)
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

        private void txtLinkCrearPost_MouseHover(object sender, EventArgs e)
        {
            if (txtLinkCrearPost.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearPost.Text = "";
                txtLinkCrearPost.ForeColor = Color.Black;
            }
        }

        private void txtLinkCrearPost_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearPost.Text))
            {
                txtLinkCrearPost.Text = "Pegue el enlace aquí";
                txtLinkCrearPost.ForeColor = Color.Gray;
            }
        }
    }
}
