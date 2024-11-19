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
        }

        public void mainpageLoad()
        {
            flowLayoutCrearPosts.BackColor = Color.LightGray;
            flowLayoutPanelPosts.BackColor = Color.LightGray;
            panelDerecho.BackColor = Color.LightGray;
            mostrarPostsIniciales();
            ListarUsuariosEnAñadirAmigos();

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
            catch (Exception ex)
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
                    postCard.ProfileImage = postCard.obtenerFotoPerfilDelCreador(post.id_cuenta);
                    postCard.PostContent = post.contenido;
                    postCard.id_post = post.id_post;
                    postCard.likes = post.likes;
                    postCard.id_cuenta_creador_post = post.id_cuenta;

                    postCard.Width = 523;
                    postCard.Height = 276;

                    //HttpClient client = new HttpClient();
                    //byte[] imageData = client.GetByteArrayAsync(post.url_imagen).Result;
                    //MemoryStream stream = new MemoryStream(imageData);

                    postCard.PostImage = post.url_imagen;

                    flowLayoutPanelPosts.Controls.Add(postCard);
                }
            }
            catch (Exception e)
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

        private void txtContactos_Click(object sender, EventArgs e)
        {

        }

        public void ListarUsuariosEnAñadirAmigos()
        {
            string baseUrl = "http://localhost:57065/";
            string endpoint = "ApiUsuarios/ListarUsuarios";

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(endpoint, Method.Get);
            request.AddHeader("Accept", "application/json");

            try
            {
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    List<CuentaDesdeAPI> usuarios = JsonConvert.DeserializeObject<List<CuentaDesdeAPI>>(response.Content);

                    dataGridAñadirAmigos.Rows.Clear();

                    if (dataGridAñadirAmigos.Columns.Count == 0)
                    {
                        dataGridAñadirAmigos.Columns.Add("nombre_usuario", "Nombre de Usuario");
                        dataGridAñadirAmigos.Columns.Add("rol_cuenta", "Rol");
                    }
                    int indice = 0;
                    foreach (var usuario in usuarios)
                    {
                        dataGridAñadirAmigos.Rows.Add(
                            usuario.nombre_usuario,
                            usuario.rol_cuenta

                        );
                        //dataGridAñadirAmigos.Rows[indice].Tag = usuario.id_cuenta;
                        dataGridAñadirAmigos.Rows[indice].Cells[0].Tag = usuario.id_cuenta;
                        indice += 1;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los datos: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void dataGridAñadirAmigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void ListarRelacionados()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            if (app == null)
            {
                MessageBox.Show("No se encontró la ventana principal.");
                return;
            }

            string baseUrl = "http://localhost:57065/";
            string endpoint = $"ApiUsuarios/cuenta/GetRelacionados/{app.IdCuenta}";

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(endpoint, Method.Get);
            request.AddHeader("Accept", "application/json");

            try
            {
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    List<VinculadoDTO> usuarios = JsonConvert.DeserializeObject<List<VinculadoDTO>>(response.Content);

                    dataGridContactos.Rows.Clear();

                    if (dataGridContactos.Columns.Count == 0)
                    {
                        dataGridContactos.Columns.Add("nombre_usuario2", "Nombre de Usuario");
                        dataGridContactos.Columns.Add("vinculo", "Vínculo");
                    }

                    if (usuarios != null && usuarios.Count > 0)
                    {
                        foreach (var usuario in usuarios)
                        {
                            dataGridContactos.Rows.Add(
                                usuario.nombre_usuario2,
                                usuario.vinculo
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron usuarios relacionados.");
                    }
                }
                else
                {
                    MessageBox.Show($"Error al obtener los datos: {response.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnAñadirAmigo_Click(object sender, EventArgs e)
        {

            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();
            try
            {
                string vinculo = "amigo";
                RestClient client = new RestClient("http://localhost:57065/"); http://localhost:44331/
                RestRequest request = new RestRequest($"ApiUsuarios/AnadirAmigoo/{app.IdCuenta}/{this.idAmigoSeleccionado}/{vinculo}", Method.Post);
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Amigo agregado");
                    app.mainPage1.mainpageLoad();
                    ListarRelacionados();
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
        public int idAmigoSeleccionado = -1; 
        private void dataGridAñadirAmigos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                var cell = dataGridAñadirAmigos.Rows[e.RowIndex].Cells[0];

                // Validar que el Tag no sea nulo
                if (cell.Tag != null)
                {
                    idAmigoSeleccionado = Convert.ToInt32(cell.Tag); 
                }
                else
                {
                    MessageBox.Show("La celda seleccionada no tiene un amigo asociado.");
                }
            }
        }
    }
}

