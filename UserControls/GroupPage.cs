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
            pboxCircular pbox = new pboxCircular();

            pbox.MakeCircularPictureBox(pboxImagenGrupo);

        }
        private int _idGrupo;
        private bool postsMostrados = false;
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
            if (postsMostrados == false)
            {
                try
                {
                    foreach (PostDesdeAPI post in posts)
                    {
                        PostCard postCard = new PostCard();
                        postCard.UserName = obtenerCreadorDePost(post.id_cuenta);
                        postCard.PostContent = post.contenido;
                        //HttpClient client = new HttpClient();
                        //byte[] imageData = client.GetByteArrayAsync(post.url_imagen).Result;
                        //MemoryStream stream = new MemoryStream(imageData);
                        postCard.PostImage = post.url_imagen;
                        postCard.likes = post.likes;
                        flowLayoutPanelPostsGrupo.Controls.Add(postCard);
                    }
                    postsMostrados = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

            public void ObtenerIntegrantesGrupo()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest($"ApiGrupos/grupo/{this.IdGrupo}/integrantes", Method.Get);
            request.AddHeader("Accept", "application/json");

            try
            {
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    List<GetIntegrantesDTO> integrantes = JsonConvert.DeserializeObject<List<GetIntegrantesDTO>>(response.Content);

                    dataGridIntegrantesGrupo.Rows.Clear();
                    dataGridIntegrantesGrupo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridIntegrantesGrupo.AutoGenerateColumns = false;

                    if (dataGridIntegrantesGrupo.Columns.Count == 0)
                    {
                        dataGridIntegrantesGrupo.Columns.Add("nombre_usuario", "Nombre Usuario");
                        dataGridIntegrantesGrupo.Columns.Add("rol", "Rol");
                    }

                    int indice = 0;
                    foreach (GetIntegrantesDTO integrante in integrantes)
                    {
                        dataGridIntegrantesGrupo.Rows.Add(integrante.nombre_usuario, integrante.rol);
                        dataGridIntegrantesGrupo.Rows[indice].Tag = integrante; // Guardar el objeto completo en Tag si es necesario
                        indice += 1;
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los integrantes del grupo: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

    }
}
