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
using CapaVisual.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;


namespace CapaVisual
{
    public partial class AppWindow : MaterialForm
    {
        public AppWindow()
        {
            InitializeComponent();

            loginPage21.Show();
            
            hideAllUsercontrols();

            panelSubmenuGrupos1.Hide();
            panelSubmenuGrupos2.Hide();
            panelSubmenuEventos1.Hide();
            panelSubmenuEventos2.Hide();
            panelSubmenuActividades.Hide();

            cargarGruposEnPanelGrupos();

            mainPage1.Dock = DockStyle.Fill;
            groupPage1.Dock = DockStyle.Fill;

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

        }

        public void ShowGroupPage()
        {
            mainPage1.Hide();
            groupPage1.Show();
        }


        public void ShowMainPage()
        {
            mainPage1.Show();
            groupPage1.Hide();
        }


        private void hideAllSubpanels()
        {
            panelSubmenuGrupos1.Visible = false;
            panelSubmenuGrupos2.Visible = false;
            panelSubmenuEventos1.Visible = false;
            panelSubmenuEventos2.Visible = false;
            panelSubmenuActividades.Visible = false;
        }

        private void hideAllUsercontrols()
        {
            mainPage1.Visible = false;
            groupPage1.Visible = false;
            muroUsuario1.Visible = false;
        }
            private void btnGrupos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuGrupos1.Visible == true)
            {
                panelSubmenuGrupos1.Visible = false;
                panelSubmenuGrupos2.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuGrupos1.Visible = true;
                panelSubmenuGrupos1.BringToFront();
                
            }
            
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuEventos1.Visible == true)
            {
                panelSubmenuEventos1.Visible = false;
                panelSubmenuEventos2.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuEventos1.Visible = true;
                panelSubmenuEventos1.BringToFront();
                
            }
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            if (panelSubmenuActividades.Visible == true)
            {
                panelSubmenuActividades.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuActividades.Visible = true;
                panelSubmenuGrupos1.BringToFront();
            }
        }

        private static List<GrupoDesdeAPI> obtenerGruposDesdeAPI()
        {
            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest("ApiGrupos/grupos", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            List<GrupoDesdeAPI> grupos;
            grupos = JsonConvert.DeserializeObject<List<GrupoDesdeAPI>>(response.Content);
            return grupos;
        }

        private static GrupoDesdeAPI obtenerGrupoDesdeAPI(int id_grupo)
        {
            RestClient client = new RestClient("http://localhost:57063/");
            // Corrige la URL para usar el id_grupo proporcionado
            RestRequest request = new RestRequest($"ApiGrupos/grupo/{id_grupo}", Method.Get);
            request.AddHeader("Accept", "application/json");

            RestResponse response = client.Execute(request);

            // Verifica si la respuesta fue exitosa
            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content); // Muestra el contenido para depuración
                                                     // Corrige la deserialización
                GrupoDesdeAPI grupo = JsonConvert.DeserializeObject<GrupoDesdeAPI>(response.Content);
                return grupo;
            }
            else
            {
                // Manejo de errores si la respuesta no fue exitosa
                Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
                return null; // O manejar el error según tu lógica
            }
        }

        /*private static GrupoDesdeAPI obtenerGrupoDesdeAPI(int id_grupo)
        {
            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest("ApiGrupos/grupos", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            List<GrupoDesdeAPI> grupos;
            grupos = JsonConvert.DeserializeObject<List<GrupoDesdeAPI>>(response.Content);

            GrupoDesdeAPI grupoEncontrado = grupos.FirstOrDefault(grupo => grupo.id_grupo == id_grupo);
            return grupoEncontrado;
            
        }*/


        private void generarBotonSubmenuGrupos(string nombreGrupo, int id_grupo)
        {
            Button btn = new Button();
            btn.Text = nombreGrupo;
            btn.Size = new Size(164, 32);
            btn.Dock = DockStyle.Top;
            btn.Click += new EventHandler(Button_Click);
            btn.Tag = id_grupo;

            panelSubmenuGrupos2.Controls.Add(btn);
        }
        public void cargarGruposEnPanelGrupos()
        {
            List<GrupoDesdeAPI> grupos = obtenerGruposDesdeAPI();
            foreach (GrupoDesdeAPI grupo in grupos)
            {
                generarBotonSubmenuGrupos(grupo.nombre_grupo, grupo.id_grupo);
               
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            

            Button btn = sender as Button;
            int id_grupo = (int)btn.Tag;
            GrupoDesdeAPI g = obtenerGrupoDesdeAPI(id_grupo);

            HttpClient client = new HttpClient();
            byte[] imagenGrupo = client.GetByteArrayAsync(g.url_imagen).Result;
            byte[] BannerGrupo = client.GetByteArrayAsync(g.imagen_banner).Result;
            MemoryStream imagenGrupo_ms = new MemoryStream(imagenGrupo);
            MemoryStream BannerGrupo_ms = new MemoryStream(BannerGrupo);

            groupPage1.ImagenGrupo = Image.FromStream(imagenGrupo_ms); // Asumiendo que tienes un método para manejar imágenes
            groupPage1.BannerGrupo = Image.FromStream(BannerGrupo_ms);
            groupPage1.DescripcionGrupo = g.descripcion;

            hideAllUsercontrols();
            groupPage1.Visible = true;
            hideAllSubpanels();
            
            
            
        }

        private void btnVerMisGrupos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuGrupos2.Visible == true)
            {
                panelSubmenuGrupos2.Visible = false;
                panelSubmenuGrupos1.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuGrupos2.Visible = true;
                
            }
        }

        private void btnVerMisEventos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuEventos2.Visible == true)
            {
                panelSubmenuEventos2.Visible = false;
                panelSubmenuEventos1.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuEventos2.Visible = true;
                
            }
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            panelSubmenuEventos2.Visible = false;
            panelSubmenuEventos1.Visible = false;
            if (mainPage1.Visible) {
                mainPage1.EliminarCrearPost();
                mainPage1.AgregarCrearEvento();
            }
            if (groupPage1.Visible)
            {
                mainPage1.EliminarCrearPost();
                mainPage1.AgregarCrearEvento();
            }

        }

        private void pictureBoxImagenPerfil_Click(object sender, EventArgs e)
        {
            hideAllUsercontrols();
            hideAllSubpanels();
            muroUsuario1.Visible = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            hideAllUsercontrols();
            hideAllSubpanels();
            mainPage1.Visible = true;
        }
    }
}