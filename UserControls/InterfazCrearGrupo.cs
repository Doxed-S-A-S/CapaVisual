using CapaVisual.DTO;
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
    public partial class InterfazCrearGrupo : UserControl
    {
        public InterfazCrearGrupo()
        {
            InitializeComponent();
            panelSuperior.ForeColor = Color.Red;
        }

        public static void crearGrupo(int id_cuenta, string nombre_grupo, string descripcion, Boolean privacidad, string url_imagen, string imagen_banner)
        {

            RestClient client = new RestClient("http://localhost:57063/");
            RestRequest request = new RestRequest($"/ApiGrupos/grupo/crear/{id_cuenta}", Method.Post);

            request.AddFile("imagen_banner", imagen_banner);
            request.AddFile("url_imagen", url_imagen);
            request.AddParameter("nombre_grupo", nombre_grupo);
            request.AddParameter("descripcion", descripcion);
            request.AddParameter("privacidad", privacidad);

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Grupo creado exitosamente.");
            }
            else
            {
                MessageBox.Show($"Error al crear el Grupo: {response.StatusCode} - {response.ErrorMessage}");
                Console.Write(response.ErrorMessage);
            }


        }

        private bool ValidarCamposGrupo()
        {
            return !string.IsNullOrWhiteSpace(txtNombreGrupo.Text) &&
                   !string.IsNullOrWhiteSpace(txtDescripcionGrupo.Text) &&
                   pboxImagenPerfilGrupo.ImageLocation != null &&
                   pboxImagenBannerGrupo.ImageLocation != null;
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (ValidarCamposGrupo())
            {
                crearGrupo(1, txtNombreGrupo.Text, txtDescripcionGrupo.Text, chkBoxPrivacidadGrupoNO.Checked, pboxImagenPerfilGrupo.ImageLocation, pboxImagenBannerGrupo.ImageLocation);
                this.Hide();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
            }
        }
        public void limpiarCampos()
        {
            txtDescripcionGrupo.Clear();
            txtNombreGrupo.Clear();
            pboxImagenPerfilGrupo.Image = null;
            pboxImagenBannerGrupo.Image = null;
            chkBoxPrivacidadGrupoNO.Checked = false;
            chkBoxPrivacidadGrupoSI.Checked = false;
        }
        private void btnImagenPerfilGrupo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.ShowDialog();
            pboxImagenPerfilGrupo.Image = Image.FromFile(dialog.FileName);
            pboxImagenPerfilGrupo.ImageLocation = dialog.FileName;
        }

        private void btnBannerGrupo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.ShowDialog();
            pboxImagenBannerGrupo.Image = Image.FromFile(dialog.FileName);
            pboxImagenBannerGrupo.ImageLocation = dialog.FileName;
        }

        private void btnVolverCrearGrupo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Hide();
        }

        
    }
}
