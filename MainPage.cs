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
            mostrarPostsIniciales();

            flowLayoutPanelPosts.Scroll += new ScrollEventHandler(flowLayoutPanelPosts_Scroll);
            flowLayoutPanelPosts.MouseWheel += flowLayoutPanelPosts_MouseWheel;
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
            flowLayoutCrearPosts.Controls.Remove(crearPost1);
        }

        public void AgregarCrearPost()
        {
            CrearPost crearPost1 = new CrearPost();
            flowLayoutCrearPosts.Controls.Add(crearPost1);
        }
    }
}
