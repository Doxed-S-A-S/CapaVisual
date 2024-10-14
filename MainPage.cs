using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaVisual.DTO;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RestSharp;
using Newtonsoft.Json;

namespace CapaVisual
{
    public partial class mainPage1 : UserControl
    {
        private string url_imagen;

        public mainPage1()
        {
            InitializeComponent();

            panelImagenVideo.Visible = false;

            mostrarPostsIniciales();

            flowLayoutPanelPosts.Scroll += new ScrollEventHandler(flowLayoutPanelPosts_Scroll);
            flowLayoutPanelPosts.MouseWheel += flowLayoutPanelPosts_MouseWheel;

            pboxImagenVideo.AllowDrop = true;
            pboxImagenVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxImagenVideo.DragEnter += new DragEventHandler(pboxImagenVideo_DragEnter);
            pboxImagenVideo.DragDrop += new DragEventHandler(pboxImagenVideo_DragDrop);

            txtLinkCrearPost.Text = "Pegue el enlace aquí";
            txtLinkCrearPost.ForeColor = Color.Gray;

            comBoxSeleccionarGrupo.ForeColor = Color.Gray;
        }

        private static List<PostDesdeAPI> obtenerPostDesdeAPI()
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest("ApiPost/post/obtener-posts", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            List<PostDesdeAPI> posts;
            posts = JsonConvert.DeserializeObject<List<PostDesdeAPI>>(response.Content);
            return posts;
        }

        private static string obtenerCreadorDePost(int id_cuenta)
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest($"ApiPost/post/obtener-creador/{id_cuenta}", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            string content = response.Content.Trim('"');
            return content;
        }

        private static void crearPost(string url_contenido, string tipo_contenido, string contenido, string url_imagen, int id_cuenta)
        {

            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest($"ApiPost/post/crear/", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddFile("imagencita", url_imagen);


            var postData = new
            {
                url_contenido = url_contenido,
                tipo_contenido = tipo_contenido,
                contenido = contenido,
                id_cuenta = "1"
            };


            request.AddJsonBody(postData);


            RestResponse response = client.Execute(request);


            if (response.IsSuccessful)
            {
                MessageBox.Show("Post creado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al crear el post: " + response.ErrorMessage);
            }
        }

        private void mostrarPostsIniciales()
        {
            List<PostDesdeAPI> posts = obtenerPostDesdeAPI();

            flowLayoutPanelPosts.Controls.Clear();

            foreach (PostDesdeAPI post in posts)
            {
                PostCard postCard = new PostCard();
                postCard.UserName = obtenerCreadorDePost(post.id_cuenta);
                postCard.PostContent = post.contenido;
                postCard.ProfileImage = CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;
                //postCard.PostImage = Image.FromFile(post.url_imagen) // faltan implementar cosas para que esto funcione
                // Add the custom post card to the flow panel
                flowLayoutPanelPosts.Controls.Add(postCard);
            }
        
        }

        private void CrearMaterialCard(string contenido) // a cambiar
        {

            MaterialSkin.Controls.MaterialCard materialCard = new MaterialSkin.Controls.MaterialCard
            {
                Width = 697,
                Height = 225,
                BackColor = Color.White
            };


            Label lblContenido = new Label
            {
                Text = contenido,
                Location = new Point(10, 10),
                AutoSize = true
            };


            materialCard.Controls.Add(lblContenido);


            flowLayoutPanelPosts.Controls.Add(materialCard);
        }
        private void flowLayoutPanelPosts_MouseWheel(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanelPosts.VerticalScroll.Value + flowLayoutPanelPosts.ClientSize.Height >= flowLayoutPanelPosts.VerticalScroll.Maximum)
            {

                CrearMaterialCard("Nuevo post al llegar al fondo usando MouseWheel");
            }
        }

        private void flowLayoutPanelPosts_Scroll(object sender, ScrollEventArgs e)
        {
            if (flowLayoutPanelPosts.VerticalScroll.Value + flowLayoutPanelPosts.ClientSize.Height >= flowLayoutPanelPosts.VerticalScroll.Maximum)
            {

                CrearMaterialCard("Nuevo post al llegar al fondo");
            }
        }

        private void pboxImagenVideo_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos != null && archivos.Length > 0)
            {
                btnBrowse.Visible = false;
                lblAñadirImagen.Visible = false;
                pboxImagenVideo.Image = Image.FromFile(archivos[0]);

                string sourceFilePath = archivos[0];

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destFolderPath = Path.Combine(projectDirectory, "Uploads");
                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);
                this.url_imagen = destFilePath;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                pboxImagenVideo.Image = Image.FromFile(dialog.FileName);
                lblAñadirImagen.Visible = false;
                btnBrowse.Visible = false;

                string sourceFilePath = dialog.FileName;

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destFolderPath = Path.Combine(projectDirectory, "Uploads");
                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);
                this.url_imagen = destFilePath;
                MessageBox.Show("Imagen subida exitosamente y guardada en: " + destFilePath);

            }
        }

        private void btnImagenVideo_Click(object sender, EventArgs e)
        {
            panelTextoPost.Visible = false;
            panelImagenVideo.Visible = true;
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pboxImagenVideo.BackColor = Color.LightGray;
            panelTextoPost.Visible = true;
            panelImagenVideo.Visible = false;
        }

        private void txtLinkCrearPost_Enter(object sender, EventArgs e)
        {
            if (txtLinkCrearPost.Text == "Pegue el enlace aquí")
            {
                txtLinkCrearPost.Text = "";
                txtLinkCrearPost.ForeColor = Color.Black;
            }
        }

        private void txtLinkCrearPost_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLinkCrearPost.Text))
            {
                txtLinkCrearPost.Text = "Pegue el enlace aquí";
                txtLinkCrearPost.ForeColor = Color.Gray;
            }
        }

        private void comBoxSeleccionarGrupo_DropDown(object sender, EventArgs e)
        {
            comBoxSeleccionarGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSeleccionarGrupo.ForeColor = Color.Black;
            if (comBoxSeleccionarGrupo.Text == "Seleccione el grupo")
            {

                comBoxSeleccionarGrupo.Text = "";
            }
        }

        private void comBoxSeleccionarGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxSeleccionarGrupo.SelectedIndex != -1)
            {

                comBoxSeleccionarGrupo.ForeColor = Color.Black;
            }
        }

        private void comBoxSeleccionarGrupo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comBoxSeleccionarGrupo.Text))
            {
                comBoxSeleccionarGrupo.Text = "Seleccione el grupo";
                comBoxSeleccionarGrupo.ForeColor = Color.Gray;
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
            crearPost(txtLinkCrearPost.Text, ObtenerTipoContenidoSeleccionado(btnTipoContenido), txtContenidoPost.Text, pboxImagenVideo.ImageLocation, 1);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent as AppWindow;
            if (parentForm != null)
            {
                parentForm.ShowGroupPage(); // Call the method on the form to switch
            }
        }

        private void panelDerecho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutCrearPosts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCardCrearPost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTextoPost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContenidoPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelImagenVideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAñadirImagen_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuCrearPost_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnLink_Click(object sender, EventArgs e)
        {

        }

        private void txtLinkCrearPost_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoContenido_Click(object sender, EventArgs e)
        {

        }

        private void btnContenidoIntercambioCultural_Click(object sender, EventArgs e)
        {

        }

        private void btnContenidoLenguaje_Click(object sender, EventArgs e)
        {

        }

        private void btnContenidoEducacion_Click(object sender, EventArgs e)
        {

        }

        private void divisorDerecho_Click(object sender, EventArgs e)
        {

        }

        private void panelCrearPost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActividades_Click(object sender, EventArgs e)
        {

        }

        private void btnEventos_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelPosts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void pboxImagenVideo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImagenPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
