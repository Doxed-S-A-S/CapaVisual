using MaterialSkin.Controls;
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
    public partial class SeleccionDeCompartida : Form
    {
        public int id_post { get; set; }
        public SeleccionDeCompartida()
        {
            InitializeComponent();
        }
        private void btnCompartirMuro_Click_1(object sender, EventArgs e)
        {
            AppWindow app = Application.OpenForms.OfType<AppWindow>().FirstOrDefault();
            try
            {
                RestClient client = new RestClient("http://localhost:44331/");
                RestRequest request = new RestRequest($"ApiPost/post/compartir-en-muro/{this.id_post}/{app.id_muro}", Method.Post);
                Console.Write(app.id_muro);

                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("se compartio todo bien parcero");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se compartio bien mi rey");
            }
        }
        private void btnCompartirGrupo_Click_1(object sender, EventArgs e)
        {
            this.Parent.Hide();
            CompartirPostDialog dialog = new CompartirPostDialog();
            dialog.Show();
        }
    }
}
