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
    public partial class LoginPage2 : UserControl
    {
        public LoginPage2()
        {
            InitializeComponent();

            txtEmail.Text = "Correo";
            txtEmail.ForeColor = Color.Gray;
            txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.Gray;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
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

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "Correo" && txtEmail.ForeColor == Color.Gray)
            {
                txtEmail.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Focused)
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Correo";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
}
