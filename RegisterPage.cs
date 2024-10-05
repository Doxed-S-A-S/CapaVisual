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
    public partial class RegisterPage : MaterialForm
    {
        public RegisterPage()
        {
            InitializeComponent();
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

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Gray;

            txtApellido.Text = "Apellido";
            txtApellido.ForeColor = Color.Gray;

            txtSegundoApellido.Text = "Segundo Apellido Opcional";
            txtSegundoApellido.ForeColor = Color.Gray;

            txtEmail.Text = "Correo";
            txtEmail.ForeColor = Color.Gray;

            txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.Gray;

            txtConfirmPssword.Text = "Confirmar Contraseña";
            txtConfirmPssword.ForeColor = Color.Gray;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre" && txtNombre.ForeColor == Color.Gray)
            {
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "Apellido" && txtApellido.ForeColor == Color.Gray)
            {
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "Segundo Apellido Opcional")
            {
                txtSegundoApellido.Text = "";
                txtSegundoApellido.ForeColor = Color.Black;
            }
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                txtSegundoApellido.Text = "Segundo Apellido Opcional";
                txtSegundoApellido.ForeColor = Color.Gray;
            }
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text != "Segundo Apellido Opcional" && txtSegundoApellido.ForeColor == Color.Gray)
            {
                txtSegundoApellido.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Correo";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "Correo" && txtEmail.ForeColor == Color.Gray)
            {
                txtEmail.ForeColor = Color.Black;
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
        }
        private void txtConfirmPssword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPssword.Text == "Confirmar Contraseña")
            {
                txtConfirmPssword.Text = "";
                txtConfirmPssword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPssword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPssword.Text))
            {
                txtConfirmPssword.Text = "Confirmar Contraseña";
                txtConfirmPssword.ForeColor = Color.Gray;
            }
        }

        private void txtConfirmPssword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPssword.Text != "Confirmar Contraseña" && txtConfirmPssword.ForeColor == Color.Gray)
            {
                txtConfirmPssword.ForeColor = Color.Black;
            }
        }
        private void btnRegister_Click(Object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" || txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese su nombre.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text == "Apellido" || txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese su apellido.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }

            if (txtEmail.Text == "Correo" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text == "Contraseña" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (txtConfirmPssword.Text == "Confirmar Contraseña" || txtConfirmPssword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, confirme su contraseña.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPssword.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPssword.Text)
            {
                MessageBox.Show("Las contraseñas tienen que ser iguales", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPssword.Focus();
                return;
            }

        }

    }
    
}