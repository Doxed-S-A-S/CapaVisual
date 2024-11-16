using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            panelCargarImagenRegistro.Hide();
            panelCrearMuro.Hide();
            panelCrearMuro.BackColor = Color.White;


            pboxCircular pbox = new pboxCircular();
            pbox.MakeCircularPictureBox(pboxImagenPerfilRegistro);
            pbox.MakeCircularPictureBox(pboxCrearPortadaMuro);

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
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (chequeoIngresoEnCampos())
            {
                panelDatosRegistro.Hide();
                panelCargarImagenRegistro.Show();
                panelCargarImagenRegistro.BringToFront();
            }
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            panelCargarImagenRegistro.Hide();
            panelCrearMuro.Show();
            panelCrearMuro.BringToFront();
        }
        private void btnFinalizarRegistro_Click_1(object sender, EventArgs e)
        {
            RestClient client = new RestClient("http://localhost:57065/");
            RestRequest request = new RestRequest("ApiUsuarios/CrearCuenta/", Method.Post);
            string username = crearUsername();
            request.AddFile("imagen_perfil", pboxImagenPerfilRegistro.ImageLocation);
            request.AddFile("imagen_banner", pboxCrearPortadaMuro.ImageLocation);
            string idiomaHablado = idiomasHablados();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
                {

                    request.AddParameter("nombre_usuario", username);
                    request.AddParameter("nombre", txtNombre.Text);
                    request.AddParameter("apellido", txtApellido.Text);
                    request.AddParameter("apellido2", txtSegundoApellido.Text);
                    request.AddParameter("pais", ObtenerCodigoICAO(comboBoxPaises.SelectedItem.ToString()));
                    request.AddParameter("idiomaHablado", idiomaHablado);
                    request.AddParameter("email", txtEmail.Text);
                    request.AddParameter("contrasena", txtPassword.Text);
                    //request.AddParameter("detalles", txt.Text);
                    request.AddParameter("biografia", txtBiografia.Text);
                }
                else
                {
                    request.AddParameter("nombre_usuario", username);
                    request.AddParameter("nombre", txtNombre.Text);
                    request.AddParameter("apellido", txtApellido.Text);
                    request.AddParameter("apellido2", "");
                    request.AddParameter("pais", ObtenerCodigoICAO(comboBoxPaises.SelectedItem.ToString()));
                    request.AddParameter("idiomas_hablados", idiomasHablados());
                    request.AddParameter("email", txtEmail.Text);
                    request.AddParameter("contraseña", txtPassword.Text);
                    request.AddParameter("biografia", txtBiografia.Text);
                }
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show($"su nommbre de usuario sera: {username}", "Registro Exitoso", MessageBoxButtons.OK);
                    LoginPage Login = new LoginPage();
                    Login.Activate();
                    Login.Show();
                }
                else
                {
                    throw new Exception($"{response.Content}");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                if (ex.Message == "La cuenta ya existe") ;
                {
                    MessageBox.Show("Esta cuenta ya existe");
                    this.Close();
                    LoginPage Login = new LoginPage();
                    Login.Activate();
                    Login.Show();
                }
            }
        }
        private void btnVolverRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            login.Activate();
            login.Show();
        }

        private void btnVolverRegistroImg_Click(object sender, EventArgs e)
        {
            panelDatosRegistro.Show();
            panelCargarImagenRegistro.Hide();
            panelCargarImagenRegistro.BringToFront();
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            panelCrearMuro.Hide();
            panelCargarImagenRegistro.Show();
            panelCargarImagenRegistro.BringToFront();
        }

        private void btnAgregarPortadaMuro_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pboxCrearPortadaMuro.Image = Image.FromFile(dialog.FileName);
                pboxCrearPortadaMuro.ImageLocation = dialog.FileName;

                MessageBox.Show("Imagen subida exitosamente y guardada en: " + dialog.FileName);
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
                return idiomaHablado;
            }

            return idiomaHablado;
        }
        private void btnAgregarImagenPerfil_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            pboxImagenPerfilRegistro.Image = Image.FromFile(dialog.FileName);
            pboxImagenPerfilRegistro.ImageLocation = dialog.FileName;
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
                txtPassword.Password = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Password = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Contraseña" && txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.Password = true;
            }
        }
        private void txtConfirmPssword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPssword.Text == "Confirmar Contraseña")
            {
                txtConfirmPssword.Text = "";
                txtConfirmPssword.ForeColor = Color.Black;
                txtConfirmPssword.Password = true;
            }
        }

        private void txtConfirmPssword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPssword.Text))
            {
                txtConfirmPssword.Text = "Confirmar Contraseña";
                txtConfirmPssword.ForeColor = Color.Gray;
                txtConfirmPssword.Password = false;
            }
        }

        private void txtConfirmPssword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPssword.Text != "Confirmar Contraseña" && txtConfirmPssword.ForeColor == Color.Gray)
            {
                txtConfirmPssword.ForeColor = Color.Black;
                txtConfirmPssword.Password = true;
            }
        }
        public bool chequeoIngresoEnCampos()
        {
            if (txtNombre.Text == "Nombre" || txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese su nombre.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (txtApellido.Text == "Apellido" || txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese su apellido.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            if (txtEmail.Text == "Correo" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false; 
            }

            if (txtPassword.Text == "Contraseña" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            if (txtConfirmPssword.Text == "Confirmar Contraseña" || txtConfirmPssword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, confirme su contraseña.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPssword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPssword.Text)
            {
                MessageBox.Show("Las contraseñas tienen que ser iguales", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPssword.Focus();
                return false;
            }
            return true;
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
            comboBoxPaises.Items.Clear(); 
            foreach (string pais in paisesICAO.Keys)
            {
                comboBoxPaises.Items.Add(pais); 
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

