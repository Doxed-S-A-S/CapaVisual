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
using CapaVisual.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;


namespace CapaVisual
{
    public partial class MainPage : MaterialForm
    {

        
        private string url_imagen;
        
        public MainPage()
        {
            InitializeComponent();
            mostrarPostsIniciales();

            panelImagenVideo.Visible = false;


            flowLayoutPanelPosts.Scroll += new ScrollEventHandler(flowLayoutPanel1_Scroll);
            flowLayoutPanelPosts.MouseWheel += flowLayoutPanel1_MouseWheel;
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Red600,
                MaterialSkin.Primary.Red700,
                MaterialSkin.Primary.Red200,
                MaterialSkin.Accent.Green400,
                MaterialSkin.TextShade.BLACK
                );

            pboxImagenVideo.AllowDrop = true;
            pboxImagenVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxImagenVideo.DragEnter += new DragEventHandler(pboxImagenVideo_DragEnter);
            pboxImagenVideo.DragDrop += new DragEventHandler(pboxImagenVideo_DragDrop);

            txtLinkCrearPost.Text = "Pegue el enlace aquí";
            txtLinkCrearPost.ForeColor = Color.Gray;

            comBoxSeleccionarGrupo.ForeColor = Color.Gray;

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


        private void mostrarPostsIniciales()
        {
            List<PostDesdeAPI> posts = obtenerPostDesdeAPI();

            flowLayoutPanelPosts.Controls.Clear();

            foreach (PostDesdeAPI post in posts)
            {

                MaterialCard card = new MaterialCard();
                card.Width = 697;
                card.Height = 225;
                card.Padding = new Padding(10);

                pboxImagenVideo.BackColor = Color.Red;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(40, 24);
                pictureBox.Size = new Size(54, 54);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;
                card.Controls.Add(pictureBox);


                Label lblUsuario = new Label();
                lblUsuario.Text = obtenerCreadorDePost(post.id_cuenta);
                lblUsuario.Location = new Point(18, 88);
                lblUsuario.Font = new Font("Arial", 10, FontStyle.Bold);
                lblUsuario.AutoSize = true;
                card.Controls.Add(lblUsuario);


                TextBox txtContenido = new TextBox();
                txtContenido.Location = new Point(128, 24);
                txtContenido.Text = post.contenido;
                txtContenido.Multiline = true;
                txtContenido.Width = 552;
                txtContenido.Height = 86;
                txtContenido.ReadOnly = true;
                card.Controls.Add(txtContenido);


                int iconYPosition = txtContenido.Bottom + 10;
                int iconXStart = txtContenido.Left;

                PictureBox pbLike = new PictureBox();
                pbLike.Location = new Point(iconXStart, iconYPosition);
                pbLike.Size = new Size(32, 32);
                pbLike.SizeMode = PictureBoxSizeMode.CenterImage;
                pbLike.Image = CapaVisual.Properties.Resources.Heart_Attack_by_iconSvg_co_4_;
                card.Controls.Add(pbLike);

                PictureBox pbComment = new PictureBox();
                pbComment.Location = new Point(iconXStart + 40, iconYPosition);
                pbComment.Size = new Size(32, 32);
                pbComment.SizeMode = PictureBoxSizeMode.CenterImage;
                pbComment.Image = CapaVisual.Properties.Resources.Chat_by_iconSvg_co_1_;
                card.Controls.Add(pbComment);

                PictureBox pbShare = new PictureBox();
                pbShare.Location = new Point(iconXStart + 80, iconYPosition);
                pbShare.Size = new Size(32, 32);
                pbShare.SizeMode = PictureBoxSizeMode.Normal;
                pbShare.Image = CapaVisual.Properties.Resources.Post_by_iconSvg_co_1_;
                card.Controls.Add(pbShare);


                flowLayoutPanelPosts.Controls.Add(card);
            }
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
        private void CrearMaterialCard(string contenido)
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



        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

            if (flowLayoutPanelPosts.VerticalScroll.Value + flowLayoutPanelPosts.ClientSize.Height >= flowLayoutPanelPosts.VerticalScroll.Maximum)
            {

                CrearMaterialCard("Nuevo post al llegar al fondo");
            }
        }


        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (flowLayoutPanelPosts.VerticalScroll.Value + flowLayoutPanelPosts.ClientSize.Height >= flowLayoutPanelPosts.VerticalScroll.Maximum)
            {

                CrearMaterialCard("Nuevo post al llegar al fondo usando MouseWheel");
            }
        }

 
        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTextoPost.Visible = false;
            panelImagenVideo.Visible = true;
        }


        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pboxImagenVideo.BackColor = Color.Red;
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

        private void txtLinkCrearPost_Click(object sender, EventArgs e)
        {

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
            // Recorre los elementos del menú desplegable
            foreach (ToolStripItem item in btnTipoContenido.DropDownItems)
            {
                // Verifica si el elemento está marcado
                if (item is ToolStripMenuItem subItem && subItem.Checked)
                {
                    return subItem.Text; // Retorna el texto del item que está marcado
                }
            }
            return string.Empty; // Retorna un valor vacío si no hay ninguno seleccionado
        }
        private void botonPostear_Click(object sender, EventArgs e)
        {
            crearPost(txtLinkCrearPost.Text, ObtenerTipoContenidoSeleccionado(btnTipoContenido), txtContenidoPost.Text, pboxImagenVideo.ImageLocation,1);
        }
    }

}
