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

        private void txtEmail_KeyUp(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
    
}
