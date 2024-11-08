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
using System.Net.Http;

namespace CapaVisual
{
    public partial class mainPage1 : UserControl
    {
        public mainPage1()
        {
            InitializeComponent();
            mostrarPostsIniciales();
        }
        
        public void mainpageLoad()
        {
            flowLayoutCrearPosts.BackColor = Color.LightGray;
            flowLayoutPanelPosts.BackColor = Color.LightGray;
            panelDerecho.BackColor = Color.LightGray;
        }
        private static List<PostDesdeAPI> obtenerPostDesdeAPI()
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest("ApiPost/post/obtener-posts", Method.Get);
            request.AddHeader("Accept", "application/json");
            try
            {
                RestResponse response = client.Execute(request);
                List<PostDesdeAPI> posts;
                posts = JsonConvert.DeserializeObject<List<PostDesdeAPI>>(response.Content);
                return posts;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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
        
        private void mostrarPostsIniciales()
        {
            List<PostDesdeAPI> posts = obtenerPostDesdeAPI();

            flowLayoutPanelPosts.Controls.Clear();
            try
            {
                foreach (PostDesdeAPI post in posts)
                {
                    PostCard postCard = new PostCard();
                    postCard.UserName = obtenerCreadorDePost(post.id_cuenta);
                    postCard.PostContent = post.contenido;
                    postCard.ProfileImage = CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;
                    postCard.id_post = post.id_post;
                    postCard.Height = 276;

                    HttpClient client = new HttpClient();
                    byte[] imageData = client.GetByteArrayAsync(post.url_imagen).Result;
                    MemoryStream stream = new MemoryStream(imageData);

                    postCard.PostImage = Image.FromStream(stream);

                    flowLayoutPanelPosts.Controls.Add(postCard);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnGrupos_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent as AppWindow;
            if (parentForm != null)
            {
                parentForm.ShowGroupPage(); // Call the method on the form to switch
            }
        }

        public void EliminarCrearPost()
        {
            flowLayoutCrearPosts.Controls.Clear();
            mostrarPostsIniciales();
        }

        public void AgregarCrearPost()
        {
            CrearPost crearPost1 = new CrearPost();
            flowLayoutCrearPosts.Controls.Add(crearPost1);
        }
        public void AgregarCrearEvento()
        {
            CrearEvento crearEvento = new CrearEvento();
            flowLayoutCrearPosts.Controls.Add(crearEvento);
        }
    }
}
