using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private string crearUsername()
        {
            string username;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            username = nombre[0] + apellido;

            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest("ApiUsuarios/CrearUsuario/", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                username = nombre[0] + nombre[1] + apellido;
                return username;
            }
            return username;
        }
        private void btnRegister_Click(Object sender, EventArgs e)
        {
            chequeoIngresoEnCampos();
            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest("ApiUsuarios/CrearCuenta/", Method.Post);
            string username = crearUsername();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
                {
                    request.AddJsonBody(new
                    {
                        nombre_usuario = username,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        apellido2 = txtSegundoApellido.Text,
                        pais = ObtenerCodigoICAO(comboBoxPaises.SelectedItem.ToString()),
                        idiomas_hablados = idiomasHablados(),
                        email = txtEmail.Text,
                        contraseña = txtPassword.Text
                    });
                }
                else
                {
                    request.AddJsonBody(new
                    {
                        nombre_usuario = username,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        apellido2 = "",
                        pais = ObtenerCodigoICAO(comboBoxPaises.SelectedItem.ToString()),
                        idiomas_hablados = idiomasHablados(),
                        email = txtEmail.Text,
                        contraseña = txtPassword.Text
                    });
                }
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show($"su nommbre de usuario sera: {username}", "Registro Exitoso", MessageBoxButtons.OK);
                }
                else
                {
                    throw new Exception($"Error: {response.ErrorException.Message} - {response.Content}");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxPaises_DropDown(object sender, EventArgs e)
        {
            CargarPaises();
        }

        private string idiomasHablados()
        {
            string idiomaHablado = "spa";

            if (chBoxIngles.Checked == true)
            {
                idiomaHablado = "eng";
            }

            return idiomaHablado;
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
        public void chequeoIngresoEnCampos()
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

        Dictionary<string, string> paisesICAO = new Dictionary<string, string>
        {
            { "Afganistán", "OA" }, { "Albania", "LA" }, { "Alemania", "ED" },
            { "Andorra", "LE" }, { "Angola", "FN" }, { "Antigua y Barbuda", "AN" },
            { "Arabia Saudita", "OE" }, { "Argelia", "DA" }, { "Argentina", "SA" },
            { "Armenia", "UU" }, { "Australia", "YP" }, { "Austria", "LO" },
            { "Azerbaiyán", "UB" }, { "Bahamas", "MY" }, { "Bangladés", "VG" },
            { "Barbados", "TB" }, { "Baréin", "BA" }, { "Bélgica", "EB" },
            { "Belice", "BZ" }, { "Benín", "DB" }, { "Bielorrusia", "UM" },
            { "Birmania", "BM" }, { "Bolivia", "SL" }, { "Bosnia y Herzegovina", "BA" },
            { "Botsuana", "FB" }, { "Brasil", "SB" }, { "Brunéi", "BX" },
            { "Bulgaria", "LB" }, { "Burkina Faso", "DF" }, { "Burundi", "HB" },
            { "Cabo Verde", "GV" }, { "Camboya", "CB" }, { "Camerún", "FC" },
            { "Canadá", "C" }, { "Catar", "QA" }, { "Chad", "TT" },
            { "Chile", "SC" }, { "China", "Z" }, { "Chipre", "LC" },
            { "Ciudad del Vaticano", "IV" }, { "Colombia", "SK" }, { "Comoras", "CC" },
            { "Corea del Norte", "ZK" }, { "Corea del Sur", "RK" }, { "Costa de Marfil", "DI" },
            { "Costa Rica", "MR" }, { "Croacia", "LD" }, { "Cuba", "MU" },
            { "Dinamarca", "EK" }, { "Dominica", "DM" }, { "Ecuador", "SE" },
            { "Egipto", "HE" }, { "El Salvador", "MS" }, { "Emiratos Árabes Unidos", "OM" },
            { "Eritrea", "ER" }, { "Eslovaquia", "LO" }, { "Eslovenia", "LJ" },
            { "España", "LE" }, { "Estados Unidos", "K" }, { "Estonia", "EE" },
            { "Etiopía", "HA" }, { "Filipinas", "RP" }, { "Finlandia", "EF" },
            { "Fiyi", "NF" }, { "Francia", "LF" }, { "Gabón", "OG" },
            { "Gambia", "GB" }, { "Georgia", "UG" }, { "Ghana", "GH" },
            { "Granada", "TG" }, { "Grecia", "LG" }, { "Guatemala", "MG" },
            { "Guinea", "GK" }, { "Guinea-Bisáu", "BW" }, { "Guinea Ecuatorial", "FG" },
            { "Guyana", "GY" }, { "Haití", "HI" }, { "Honduras", "MH" },
            { "Hungría", "LH" }, { "India", "VI" }, { "Indonesia", "W" },
            { "Irak", "OR" }, { "Irán", "IR" }, { "Irlanda", "EI" },
            { "Islandia", "BI" }, { "Islas Marshall", "RM" }, { "Islas Salomón", "WS" },
            { "Israel", "LL" }, { "Italia", "LI" }, { "Jamaica", "MK" },
            { "Japón", "RJ" }, { "Jordania", "OJ" }, { "Kazajistán", "U" },
            { "Kenia", "HK" }, { "Kirguistán", "KG" }, { "Kiribati", "GI" },
            { "Kosovo", "KV" }, { "Kuwait", "KW" }, { "Laos", "VL" },
            { "Lesoto", "LS" }, { "Letonia", "EV" }, { "Líbano", "LE" },
            { "Liberia", "LI" }, { "Libia", "HL" }, { "Liechtenstein", "LS" },
            { "Lituania", "EY" }, { "Luxemburgo", "LU" }, { "Macedonia del Norte", "SK" },
            { "Madagascar", "FM" }, { "Malasia", "WM" }, { "Malaui", "MW" },
            { "Maldivas", "MV" }, { "Malí", "BM" }, { "Malta", "LM" },
            { "Marruecos", "CM" }, { "Mauricio", "MU" }, { "Mauritania", "MR" },
            { "México", "MM" }, { "Micronesia", "FM" }, { "Moldavia", "MD" },
            { "Mónaco", "MN" }, { "Mongolia", "ZM" }, { "Montenegro", "YU" },
            { "Mozambique", "MP" }, { "Namibia", "FW" }, { "Nauru", "NR" },
            { "Nepal", "VN" }, { "Nicaragua", "MN" }, { "Níger", "NE" },
            { "Nigeria", "DN" }, { "Noruega", "EN" }, { "Nueva Zelanda", "NZ" },
            { "Omán", "MU" }, { "Países Bajos", "EH" }, { "Pakistán", "AP" },
            { "Palaos", "PW" }, { "Panamá", "MP" }, { "Papúa Nueva Guinea", "AY" },
            { "Paraguay", "SG" }, { "Perú", "SP" }, { "Polonia", "EP" },
            { "Portugal", "LP" }, { "Reino Unido", "EG" }, { "República Centroafricana", "FE" },
            { "República Checa", "LK" }, { "República del Congo", "FC" }, { "República Democrática del Congo", "FZ" },
            { "República Dominicana", "MD" }, { "Ruanda", "HR" }, { "Rumania", "LR" },
            { "Rusia", "U" }, { "Samoa", "WS" }, { "San Cristóbal y Nieves", "TK" },
            { "San Marino", "SM" }, { "San Vicente y las Granadinas", "TV" }, { "Santa Lucía", "TL" },
            { "Santo Tomé y Príncipe", "TP" }, { "Senegal", "GC" }, { "Serbia", "JU" },
            { "Seychelles", "SE" }, { "Sierra Leona", "SL" }, { "Singapur", "WS" },
            { "Siria", "OS" }, { "Somalia", "HC" }, { "Sri Lanka", "CE" },
            { "Suazilandia", "FZ" }, { "Sudáfrica", "FA" }, { "Sudán", "SU" },
            { "Sudán del Sur", "HS" }, { "Suecia", "ES" }, { "Suiza", "LS" },
            { "Surinam", "SM" }, { "Tailandia", "VT" }, { "Tanzania", "HT" },
            { "Tayikistán", "TJ" }, { "Timor Oriental", "TT" }, { "Togo", "TO" },
            { "Tonga", "FT" }, { "Trinidad y Tobago", "TT" }, { "Túnez", "DT" },
            { "Turkmenistán", "TK" }, { "Turquía", "LT" }, { "Tuvalu", "TV" },
            { "Ucrania", "UK" }, { "Uganda", "HU" }, { "Uruguay", "SU" },
            { "Uzbekistán", "UZ" }, { "Vanuatu", "NV" }, { "Venezuela", "SV" },
            { "Vietnam", "VV" }, { "Yemen", "OY" }, { "Zambia", "ZA" },
            { "Zimbabue", "FZ" }

            };
        private void CargarPaises()
        {
            comboBoxPaises.Items.Clear(); // Limpia los elementos existentes en el ComboBox
            foreach (string pais in paisesICAO.Keys)
            {
                comboBoxPaises.Items.Add(pais); // Agrega solo el nombre del país
            }
        }

        private string ObtenerCodigoICAO(string pais)
        {
            if (paisesICAO.TryGetValue(pais, out string codigoICAO))
            {
                return codigoICAO;
            }
            else
            {
                return "Código no encontrado";
            }
        }

    }

}

