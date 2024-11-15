using CapaVisual.DTO;
using Newtonsoft.Json;
using RestSharp;
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

        private string _profileImage;

        public string ProfileImage
        {
            get { return _profileImage; }
            set { _profileImage = value; pictureBoxFotoPerfilPost.Load(value); }
        }


        public Image PostImage
        {
            get { return pictureBoxImagenPost.Image; }
            set { pictureBoxImagenPost.Image = value; }
        }

        public int likes
        {
            get { return Int32.Parse(txtLikesPost.Text); }
            set { txtLikesPost.Text = value.ToString(); }
        }

        private int idPost;

        public int id_post
        {
            get { return idPost; }
            set { idPost = value; }
        }

        private int idCuenta;

        public int id_cuenta_creador_post
        {
            get { return idCuenta; }
            set { idCuenta = value; }
        }
        public PostCard Clone()
        {
            PostCard clone = new PostCard();
            clone.UserName = this.UserName;
            clone.PostContent = this.PostContent;
            clone.ProfileImage = this.ProfileImage;
            clone.PostImage = this.PostImage;
            clone.id_post = this.id_post;
            clone.likes = this.likes;
            clone.id_cuenta_creador_post = this.id_cuenta_creador_post;

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

        public string obtenerFotoPerfilDelCreador(int id_cuenta)
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();
            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest($"ApiUsuarios/cuenta/ObtenerInformacion/{id_cuenta}", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content);
                CuentaDesdeAPI cuenta = JsonConvert.DeserializeObject<CuentaDesdeAPI>(response.Content);
                return cuenta.imagen_perfil;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
                return null;
            }
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
            comentarios.idPost = this.idPost;
            comentarios.cargarComentarios();
        }


        private void btnLikePost_Click(object sender, EventArgs e)
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();
            try
            {
                RestClient client = new RestClient("http://localhost:44331/");
                RestRequest request = new RestRequest($"ApiPost/post/añadir-like/{this.id_post}/{app.IdCuenta}", Method.Post);
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("like dado");
                    app.mainPage1.mainpageLoad();
                }
                else
                {
                    throw new Exception($"{response.Content}");
                    app.mainPage1.mainpageLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                app.mainPage1.mainpageLoad();
            }
        }
    }
}
