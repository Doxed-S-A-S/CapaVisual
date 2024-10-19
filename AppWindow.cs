using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

            mainPage1.Show();
            groupPage1.Hide();

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

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            if (panelSubmenuGrupos1.Visible == true)
            {
                panelSubmenuGrupos1.Visible = false;
                panelSubmenuGrupos2.Visible = false;
            }
            else
            {
                panelSubmenuGrupos1.Visible = true;
                panelSubmenuGrupos2.Visible = false;
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
                panelSubmenuEventos1.Visible = true;
                panelSubmenuEventos2.Visible = false;
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
                panelSubmenuActividades.Visible = true;
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

        private void generarBotonSubmenuGrupos(string nombreGrupo)
        {
            Button btn = new Button();
            btn.Text = nombreGrupo;
            btn.Size = new Size(164, 32);
            btn.Dock = DockStyle.Top;
            btn.Click += new EventHandler(Button_Click);

            panelSubmenuGrupos2.Controls.Add(btn);
        }
        public void cargarGruposEnPanelGrupos()
        {
            List<GrupoDesdeAPI> grupos = obtenerGruposDesdeAPI();
            foreach (GrupoDesdeAPI grupo in grupos)
            {
                generarBotonSubmenuGrupos(grupo.nombre_grupo);
               
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            GroupPage grupo = new GroupPage();
            
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
                panelSubmenuGrupos2.Visible = true;
                panelSubmenuGrupos1.Visible = false;
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
                panelSubmenuEventos2.Visible = true;
                panelSubmenuEventos1.Visible = false;
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
    }
}