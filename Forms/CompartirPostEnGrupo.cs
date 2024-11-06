using CapaVisual.DTO;
using MaterialSkin.Controls;
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
    public partial class CompartirPostDialog : Form
    {
        public CompartirPostDialog()
        {
            InitializeComponent();
            
        }

        public void obtenerGruposQueConformaElUsuario()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest($"ApiGrupos/conforma_grupos/{app.id_cuenta}", Method.Get);
            request.AddHeader("Accept", "application/json");
            try
            {
                RestResponse response = client.Execute(request);
                List<GrupoDesdeAPI> grupos;
                grupos = JsonConvert.DeserializeObject<List<GrupoDesdeAPI>>(response.Content);

                dataGridView2.Rows.Clear();

                foreach (var grupo in grupos)
                {
                    dataGridView2.Rows.Add(grupo.id_grupo, grupo.nombre_grupo);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
