using CapaVisual.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class CompartirEnGrupoDialog : UserControl
    {
        public CompartirEnGrupoDialog()
        {
            InitializeComponent();
            panelSuperior.BackColor = Color.FromArgb(128, 240, 240, 240);
        }
        /*
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

        
        private void generarBotonSubmenuGrupos(string nombreGrupo, int id_grupo, int id_post)
        {
            Button btn = new Button();
            btn.Text = nombreGrupo;
            btn.Size = new Size(164, 32);
            btn.Dock = DockStyle.Top;
            btn.Click += new EventHandler(Button_Click);
            var tags = new Dictionary<string, object>();
            tags.Add("Id_grupo", id_grupo);
            tags.Add("id_post", id_post);

            btn.Tag = tags;

            panelSeleccionarGrupo.Controls.Add(btn);
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
            int id_post = 
        }*/
    }
}
