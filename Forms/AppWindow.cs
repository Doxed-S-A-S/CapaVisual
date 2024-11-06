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
        public int id_cuenta;
        public int id_muro { get; set; }
        private int id_preferencia;
        private string nombre_usuario;
        private string imagen_perfil;
        private string rol_cuenta;

        public AppWindow()
        {
            InitializeComponent();
            hideAllUsercontrols();
            pboxCircular pbox = new pboxCircular();

            pbox.MakeCircularPictureBox(pictureBoxImagenPerfil);
            mainPage1.Visible = true;
            
            panelSubmenuGrupos1.Hide();
            panelSubmenuGrupos2.Hide();
            panelSubmenuEventos1.Hide();
            panelSubmenuEventos2.Hide();
            panelSubmenuActividades.Hide();
            interfazCrearGrupo1.Hide();
            
            cargarGruposEnPanelGrupos();

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
        public void appWindowLoad()
        {
            panelIzquierdoMain.BackColor = Color.LightGray;
            obtenerInfoCuentaDesdeApi(id_cuenta);
            pictureBoxImagenPerfil.Load(imagen_perfil);
            txtUsernamePanelIzquierdo.Text = this.nombre_usuario;
            mainPage1.mainpageLoad();
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
                panelSubmenuGrupos1.BringToFront();
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
                panelSubmenuEventos1.BringToFront();
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
                panelSubmenuActividades.BringToFront(); 
                panelSubmenuActividades.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuActividades.Visible = true;
                panelSubmenuGrupos1.BringToFront();
            }
        }
        private void btnVerMisGrupos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuGrupos2.Visible == true)
            {
                panelSubmenuGrupos2.BringToFront();
                panelSubmenuGrupos2.Visible = false;
                panelSubmenuGrupos1.Visible = false;
            }
            else
            {
                hideAllSubpanels();
                panelSubmenuGrupos2.Visible = true;
                panelSubmenuGrupos2.BringToFront();

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
            if (mainPage1.Visible)
            {
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
        private void AppWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            hideAllSubpanels();
            interfazCrearGrupo1.Show();
            interfazCrearGrupo1.BringToFront();
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
            RestRequest request = new RestRequest($"ApiGrupos/grupo/{id_grupo}", Method.Get);
            request.AddHeader("Accept", "application/json");

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content); 
                                                     
                GrupoDesdeAPI grupo = JsonConvert.DeserializeObject<GrupoDesdeAPI>(response.Content);
                return grupo;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
                return null;
            }
        }

        public void obtenerInfoCuentaDesdeApi(int id_cuenta)
        {
            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest($"ApiUsuarios/cuenta/ObtenerInformacion/{id_cuenta}", Method.Get);
            request.AddHeader("Accept", "application/json");
            
            RestResponse response = client.Execute(request);
            
            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content);

                CuentaDesdeAPI cuenta = JsonConvert.DeserializeObject<CuentaDesdeAPI>(response.Content);
                this.nombre_usuario = cuenta.nombre_usuario;
                this.id_preferencia = cuenta.id_preferencia;
                this.id_muro = cuenta.id_muro;
                this.rol_cuenta = cuenta.rol_cuenta;
                this.imagen_perfil = cuenta.imagen_perfil;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
            }
        }

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

            try
            {
                GrupoDesdeAPI g = obtenerGrupoDesdeAPI(id_grupo);

                HttpClient client = new HttpClient();
                byte[] imagenGrupo = client.GetByteArrayAsync(g.url_imagen).Result;
                byte[] BannerGrupo = client.GetByteArrayAsync(g.imagen_banner).Result;
                MemoryStream imagenGrupo_ms = new MemoryStream(imagenGrupo);
                MemoryStream BannerGrupo_ms = new MemoryStream(BannerGrupo);

                groupPage1.NombreGrupo = g.nombre_grupo;
                groupPage1.ImagenGrupo = Image.FromStream(imagenGrupo_ms); // Asumiendo que tienes un método para manejar imágenes
                groupPage1.BannerGrupo = Image.FromStream(BannerGrupo_ms);
                groupPage1.DescripcionGrupo = g.descripcion;
                groupPage1.IdGrupo = id_grupo;

                hideAllUsercontrols();
                groupPage1.Visible = true;
                hideAllSubpanels();
                groupPage1.mostrarPostsDelGrupo();
            }
            catch(Exception xe)
            {
                MessageBox.Show("Error" + xe.Message);
            }
        }

        
    }
}