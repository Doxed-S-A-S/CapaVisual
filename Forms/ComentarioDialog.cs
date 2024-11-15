using CapaVisual.DTO;
using CapaVisual.UserControls;
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
    public partial class ComentarioDialog : Form
    {

        private int id_post;

        public int idPost
        {
            get { return id_post; }
            set { id_post = value; }
        }

        private int id_comentario;

        public int idComentario
        {
            get { return id_comentario; }
            set { id_comentario = value; }
        }
        public ComentarioDialog()
        {
            InitializeComponent();
            pboxCircular pbox = new pboxCircular();
            pbox.MakeCircularPictureBox(pboxPerfilCrearComentario);
        }

        public void ComentarioDialog_load()
        {
            richTxtBoxCircularcs comentario = new richTxtBoxCircularcs();
            comentario.MakeCircularRichTextBox(txtCrearComentario, 50);
            txtCrearComentario.SelectionIndent = 10;
            pboxCircular pbox = new pboxCircular();
            pbox.MakeCircularPictureBox(pboxPerfilCrearComentario);

            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            pboxPerfilCrearComentario.Load(app.ImagenPerfil);
            
        }
        public Panel PanelContendorDePost
        {
            get { return panelContendorDePost; }
        }

        public void CrearComentario()
        {
            try
            {
                AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

                RestClient client = new RestClient("http://localhost:44331/"); 
                RestRequest request = new RestRequest($"ApiPost/post/{this.id_post}/CrearComentario", Method.Post);

                ComentarioDTO comentario = new ComentarioDTO
                {
                    id_cuenta = app.IdCuenta,
                    comentario = txtCrearComentario.Text
                };

                request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(comentario), ParameterType.RequestBody);

                RestResponse response = client.Execute(request);


                if (response.IsSuccessful)
                {
                    MessageBox.Show("comentado creado");
                }
                else
                {
                    throw new Exception($"Error: {response.ErrorException.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompartirComentario_Click(object sender, EventArgs e)
        {
            CrearComentario();
            cargarUltimoComentario();
        }

        private List<ComentarioDTO> obtenerComentariosDelPost()
        {
            RestClient client = new RestClient("http://localhost:44331/");
            RestRequest request = new RestRequest($"ApiPost/post/{this.idPost}/obtenerComentarios", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            List<ComentarioDTO> comentarios;
            comentarios = JsonConvert.DeserializeObject<List<ComentarioDTO>>(response.Content);
            return comentarios;
        }

        private CuentaDesdeAPI obtenerCreadorComentarioYSuFoto(int id_comentario)
        {
            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest($"ApiUsuarios/obtenerDatosComentadores/{id_comentario}", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            // Deserializar directamente a un objeto de tipo CuentaDesdeAPI
            CuentaDesdeAPI datosDelComentador = JsonConvert.DeserializeObject<CuentaDesdeAPI>(response.Content);
            return datosDelComentador;
        }

        public void cargarUltimoComentario()
        {
            List<ComentarioDTO> comentarios = obtenerComentariosDelPost();

            if (comentarios != null && comentarios.Count > 0)
            {
                ComentarioDTO ultimoComentario = comentarios.Last();

                CuentaDesdeAPI datosDelComentador = obtenerCreadorComentarioYSuFoto(ultimoComentario.id_comentario);

                if (datosDelComentador != null) // Verifica que no sea nulo
                {
                    Comentario comment = new Comentario
                    {
                        usuarioComentario = datosDelComentador.nombre_usuario,
                        fechayhora = ultimoComentario.fecha,
                        ProfileImage = datosDelComentador.imagen_perfil,
                        likeCount = ultimoComentario.likes,
                        Contenido = ultimoComentario.contenido,
                    };

                    flowLayoutPanel1.Controls.Add(comment);
                }
            }
        }

        public void cargarComentarios()
        {
            List<ComentarioDTO> comentarios = obtenerComentariosDelPost();
            foreach (ComentarioDTO comentario in comentarios)
            {
                // Llama al método actualizado que ahora devuelve un solo objeto
                CuentaDesdeAPI datosDelComentador = obtenerCreadorComentarioYSuFoto(comentario.id_comentario);

                if (datosDelComentador != null) // Verifica que no sea nulo
                {
                    Comentario comment = new Comentario
                    {
                        usuarioComentario = datosDelComentador.nombre_usuario,
                        fechayhora = comentario.fecha,
                        ProfileImage = datosDelComentador.imagen_perfil,
                        likeCount = comentario.likes,
                        Contenido = comentario.comentario,
                        //id_cuenta_comentador = datosDelComentador.id_cuenta
                    };

                    flowLayoutPanel1.Controls.Add(comment);
                }
            }
        }

        private void pboxPerfilCrearComentario_Click(object sender, EventArgs e)
        {

        }

        private void txtCrearComentario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
