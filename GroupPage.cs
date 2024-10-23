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
    public partial class GroupPage : UserControl
    {
        public GroupPage()
        {
            InitializeComponent();
            

        }
        private int _idGrupo;
        public string NombreGrupo
        {
            get { return lblNombreGrupo.Text; }
            set { lblNombreGrupo.Text = value; }
        }
        public Image ImagenGrupo
        {
            get { return pboxImagenGrupo.Image; }
            set { pboxImagenGrupo.Image = value; }
        }
        public Image BannerGrupo
        {
            get { return pboxBannerGrupo.Image; }
            set { pboxBannerGrupo.Image = value; }
        }

        public string DescripcionGrupo
        {
            get { return txtBoxDescripcionGrupo.Text; }
            set { txtBoxDescripcionGrupo.Text = value; }
        }
        public DataTable IntegrantesGrupo
        {
            get => (DataTable)dataGridIntegrantesGrupo.DataSource;
            set => dataGridIntegrantesGrupo.DataSource = value;
        }

        public int IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        private static List<PostDesdeAPI> obtenerPostDesdeAPI(int id_grupo)
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest($"ApiPost/post/obtener-posts-grupo/{id_grupo}", Method.Get);
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

        public void mostrarPostsDelGrupo()
        {
            List<PostDesdeAPI> posts = obtenerPostDesdeAPI(_idGrupo);

            flowLayoutPanelPostsGrupo.Controls.Clear();
            try
            {
                foreach (PostDesdeAPI post in posts)
                {
                    PostCard postCard = new PostCard();
                    postCard.UserName = obtenerCreadorDePost(post.id_cuenta);
                    postCard.PostContent = post.contenido;
                    postCard.ProfileImage = CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;

                    HttpClient client = new HttpClient();
                    byte[] imageData = client.GetByteArrayAsync(post.url_imagen).Result;
                    MemoryStream stream = new MemoryStream(imageData);

                    postCard.PostImage = Image.FromStream(stream);


                    flowLayoutPanelPostsGrupo.Controls.Add(postCard);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
