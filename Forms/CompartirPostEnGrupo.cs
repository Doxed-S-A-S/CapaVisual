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
            obtenerGruposQueConformaElUsuario();
        }
        public void obtenerGruposQueConformaElUsuario()
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();

            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest($"ApiGrupos/conforma_grupos/{app.IdCuenta}", Method.Get);
            request.AddHeader("Accept", "application/json");

            try
            {
                RestResponse response = client.Execute(request);
                List<GrupoConformadoDesdeAPI> grupos = JsonConvert.DeserializeObject<List<GrupoConformadoDesdeAPI>>(response.Content);

                dataGridView2.Rows.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoGenerateColumns = false;

                if (dataGridView2.Columns.Count == 0)
                {
                    dataGridView2.Columns.Add("nombre_grupo", "Nombre Grupo");
                }

                int indice = 0;
                foreach (GrupoConformadoDesdeAPI grupo in grupos)
                {
                    dataGridView2.Rows.Add(grupo.nombre_grupo);
                    dataGridView2.Rows[indice].Tag = grupo.id_grupo;
                    indice += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idGrupo = (int)dataGridView2.Rows[e.RowIndex].Tag;
                try
                {
                    SeleccionDeCompartida selec = Application.OpenForms.OfType<SeleccionDeCompartida>().FirstOrDefault();

                    RestClient client = new RestClient("http://localhost:44331/");
                    RestRequest request = new RestRequest($"ApiPost/post/compartir-en-grupo/{selec.id_post}/{idGrupo}", Method.Post);
                    
                    RestResponse response = client.Execute(request);
                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Su post ha sido compartido correctamente");
                        this.Close();
                        selec.Close();
                    }
                    else
                    {
                        MessageBox.Show("Su post ya existe en este grupo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se compartio bien mi rey");
                }
            }
        }

        
    }
}
