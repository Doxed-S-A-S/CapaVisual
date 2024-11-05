using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class LoginPage : MaterialForm
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Size = new Size(1600, 900);
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
        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Correo";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.Gray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Correo")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Correo";
                txtUsername.ForeColor = Color.Gray;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Correo" && txtUsername.ForeColor == Color.Gray)
            {
                txtUsername.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtUsername.Text) && txtUsername.Focused)
            {
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Contraseña" && txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Focused)
            {
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();

        }
        private void btnIniciar_Clic(object sender, EventArgs e)
        {
            loginUsuario();
            if (txtUsername.Text == "Correo" || txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "Contraseña" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                AppWindow app = new AppWindow();
                app.Show();
            }

        }

        private void loginUsuario()
        {
            RestClient client = new RestClient("http://localhost:44395/");
            RestRequest request = new RestRequest("ApiAut/login", Method.Post); http://localhost:44395/ApiAut/login
            RestResponse response;

            try
            {
                request.AddJsonBody(new
                {
                    nombre_usuario = txtUsername.Text,
                    contraseña = txtPassword.Text
                });
                response = client.Execute(request);
                
                var resultado = JsonConvert.DeserializeObject<dynamic>(response.Content);
                string idCuenta = resultado.ID;

                if (response.IsSuccessful)
                {
                    this.Hide();
                    AppWindow app = new AppWindow();
                    app.id_cuenta = Int32.Parse(idCuenta);
                    app.Show();
                    app.Activate();
                }
                else
                {
                    throw new Exception($"Error: {response.ErrorException.Message} - {response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
