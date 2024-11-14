using CapaVisual.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class MuroUsuario : UserControl
    {
        private bool postsMostrados;

        public MuroUsuario()
        {
            InitializeComponent();
            richTxtBoxCircularcs comentario = new richTxtBoxCircularcs();
            comentario.MakeCircularRichTextBox(txtBoxDescripcionGrupo, 25);
            txtBoxDescripcionGrupo.SelectionIndent = 10;

            pboxCircular pbox = new pboxCircular();
            pbox.MakeCircularPictureBox(pboxImagenPerfilMuro);
            txtBoxDescripcionGrupo.BackColor = Color.White;
            
        }
        public string UserName
        {
            get { return txtNomyApeMuro.Text; }
            set { txtNomyApeMuro.Text = value; }
        }
        public string Portada
        {
            get { return pboxImagenPortadaMuro.ImageLocation; }
            set { pboxImagenPortadaMuro.Load(value); }
        }
        public string ProfileImage
        {
            get { return pboxImagenPerfilMuro.ImageLocation; }
            set { pboxImagenPerfilMuro.Load(value); }
        }
        public string Descripcion
        {
            get { return txtBoxDescripcionGrupo.Text; }
            set { txtBoxDescripcionGrupo.Text = value; }
        }

        public void CargarMuroDelUsuarioLogeado()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest($"ApiUsuarios/cuenta/ObtenerInformacion/Muro/{app.IdMuro}", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content);
                MuroDesdeAPI muro = JsonConvert.DeserializeObject<MuroDesdeAPI>(response.Content);
                pboxImagenPortadaMuro.Load(muro.imagen_banner);
                this.Descripcion = muro.biografia;
                this.UserName = app.NombreUsuario;
                pboxImagenPerfilMuro.Load(app.ImagenPerfil);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
            }
        }

        private static List<PostDesdeAPI> obtenerPostDesdeAPI(int id_muro)
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest($"ApiPost/post/obtener-posts-muro/{id_muro}", Method.Get);
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

        public void mostrarPostsDelMuro()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();
            List<PostDesdeAPI> posts = obtenerPostDesdeAPI(app.IdMuro);
            if (postsMostrados == false)
            {
                try
                {
                    foreach (PostDesdeAPI post in posts)
                    {
                        PostCard postCard = new PostCard();
                        postCard.UserName = obtenerCreadorDePost(post.id_cuenta);
                        postCard.PostContent = post.contenido;
                        postCard.likes = post.likes;
                        HttpClient client = new HttpClient();
                        byte[] imageData = client.GetByteArrayAsync(post.url_imagen).Result;
                        MemoryStream stream = new MemoryStream(imageData);

                        postCard.PostImage = Image.FromStream(stream);
                        panelPostsMuroUsuario.Controls.Add(postCard);
                    }
                    postsMostrados = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }





    }
}
