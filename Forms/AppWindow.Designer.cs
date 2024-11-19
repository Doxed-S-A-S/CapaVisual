
namespace CapaVisual
{
    partial class AppWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBarraBusqueda = new System.Windows.Forms.TextBox();
            this.panelIzquierdoMain = new System.Windows.Forms.Panel();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernamePanelIzquierdo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.panelSubmenuGrupos2 = new System.Windows.Forms.Panel();
            this.panelSubmenuEventos2 = new System.Windows.Forms.Panel();
            this.panelSubmenuActividades = new System.Windows.Forms.Panel();
            this.panelSubmenuGrupos1 = new System.Windows.Forms.Panel();
            this.btnVerMasGrupos = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnVerMisGrupos = new System.Windows.Forms.Button();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.panelSubmenuEventos1 = new System.Windows.Forms.Panel();
            this.btnEliminarMisEvento = new System.Windows.Forms.Button();
            this.btnVerMisEventos = new System.Windows.Forms.Button();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.mainPage1 = new CapaVisual.mainPage1();
            this.interfazCrearGrupo1 = new CapaVisual.InterfazCrearGrupo();
            this.muroUsuario1 = new CapaVisual.MuroUsuario();
            this.groupPage1 = new CapaVisual.GroupPage();
            this.panelIzquierdoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).BeginInit();
            this.panelSubmenuGrupos1.SuspendLayout();
            this.panelSubmenuEventos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarraBusqueda.Location = new System.Drawing.Point(494, 34);
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(459, 20);
            this.txtBarraBusqueda.TabIndex = 7;
            // 
            // panelIzquierdoMain
            // 
            this.panelIzquierdoMain.AutoScroll = true;
            this.panelIzquierdoMain.BackColor = System.Drawing.Color.Silver;
            this.panelIzquierdoMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIzquierdoMain.Controls.Add(this.btnSpanish);
            this.panelIzquierdoMain.Controls.Add(this.btnEnglish);
            this.panelIzquierdoMain.Controls.Add(this.label1);
            this.panelIzquierdoMain.Controls.Add(this.txtUsernamePanelIzquierdo);
            this.panelIzquierdoMain.Controls.Add(this.pictureBoxImagenPerfil);
            this.panelIzquierdoMain.Controls.Add(this.btnActividades);
            this.panelIzquierdoMain.Controls.Add(this.btnEventos);
            this.panelIzquierdoMain.Controls.Add(this.btnGrupos);
            this.panelIzquierdoMain.Controls.Add(this.btnPrincipal);
            this.panelIzquierdoMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdoMain.Location = new System.Drawing.Point(3, 64);
            this.panelIzquierdoMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelIzquierdoMain.Name = "panelIzquierdoMain";
            this.panelIzquierdoMain.Size = new System.Drawing.Size(240, 1013);
            this.panelIzquierdoMain.TabIndex = 10;
            // 
            // btnSpanish
            // 
            this.btnSpanish.Image = global::CapaVisual.Properties.Resources.Screenshot_2024_11_16_0051242;
            this.btnSpanish.Location = new System.Drawing.Point(127, 859);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(74, 67);
            this.btnSpanish.TabIndex = 10;
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Image = global::CapaVisual.Properties.Resources.Screenshot_2024_11_16_0051372;
            this.btnEnglish.Location = new System.Drawing.Point(33, 859);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(74, 67);
            this.btnEnglish.TabIndex = 9;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 818);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Language / Idioma";
            // 
            // txtUsernamePanelIzquierdo
            // 
            this.txtUsernamePanelIzquierdo.AutoSize = true;
            this.txtUsernamePanelIzquierdo.Depth = 0;
            this.txtUsernamePanelIzquierdo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsernamePanelIzquierdo.Location = new System.Drawing.Point(89, 169);
            this.txtUsernamePanelIzquierdo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsernamePanelIzquierdo.Name = "txtUsernamePanelIzquierdo";
            this.txtUsernamePanelIzquierdo.Size = new System.Drawing.Size(1, 0);
            this.txtUsernamePanelIzquierdo.TabIndex = 5;
            // 
            // pictureBoxImagenPerfil
            // 
            this.pictureBoxImagenPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagenPerfil.Image = global::CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;
            this.pictureBoxImagenPerfil.Location = new System.Drawing.Point(62, 33);
            this.pictureBoxImagenPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImagenPerfil.Name = "pictureBoxImagenPerfil";
            this.pictureBoxImagenPerfil.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImagenPerfil.TabIndex = 4;
            this.pictureBoxImagenPerfil.TabStop = false;
            this.pictureBoxImagenPerfil.Click += new System.EventHandler(this.pictureBoxImagenPerfil_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.Silver;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActividades.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActividades.Location = new System.Drawing.Point(2, 339);
            this.btnActividades.Margin = new System.Windows.Forms.Padding(2);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(232, 32);
            this.btnActividades.TabIndex = 3;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.Silver;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventos.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEventos.Location = new System.Drawing.Point(2, 301);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(232, 32);
            this.btnEventos.TabIndex = 2;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.BackColor = System.Drawing.Color.Silver;
            this.btnGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupos.FlatAppearance.BorderSize = 0;
            this.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrupos.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrupos.Location = new System.Drawing.Point(2, 264);
            this.btnGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(232, 32);
            this.btnGrupos.TabIndex = 1;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = false;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.Silver;
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrincipal.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrincipal.Location = new System.Drawing.Point(2, 227);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(232, 32);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // panelSubmenuGrupos2
            // 
            this.panelSubmenuGrupos2.AutoScroll = true;
            this.panelSubmenuGrupos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuGrupos2.Location = new System.Drawing.Point(264, 329);
            this.panelSubmenuGrupos2.Name = "panelSubmenuGrupos2";
            this.panelSubmenuGrupos2.Size = new System.Drawing.Size(170, 281);
            this.panelSubmenuGrupos2.TabIndex = 12;
            // 
            // panelSubmenuEventos2
            // 
            this.panelSubmenuEventos2.AutoScroll = true;
            this.panelSubmenuEventos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuEventos2.Location = new System.Drawing.Point(264, 366);
            this.panelSubmenuEventos2.Name = "panelSubmenuEventos2";
            this.panelSubmenuEventos2.Size = new System.Drawing.Size(170, 281);
            this.panelSubmenuEventos2.TabIndex = 13;
            // 
            // panelSubmenuActividades
            // 
            this.panelSubmenuActividades.AutoScroll = true;
            this.panelSubmenuActividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuActividades.Location = new System.Drawing.Point(264, 334);
            this.panelSubmenuActividades.Name = "panelSubmenuActividades";
            this.panelSubmenuActividades.Size = new System.Drawing.Size(170, 281);
            this.panelSubmenuActividades.TabIndex = 14;
            // 
            // panelSubmenuGrupos1
            // 
            this.panelSubmenuGrupos1.AutoScroll = true;
            this.panelSubmenuGrupos1.AutoSize = true;
            this.panelSubmenuGrupos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuGrupos1.Controls.Add(this.btnVerMasGrupos);
            this.panelSubmenuGrupos1.Controls.Add(this.btnEliminarGrupo);
            this.panelSubmenuGrupos1.Controls.Add(this.btnVerMisGrupos);
            this.panelSubmenuGrupos1.Controls.Add(this.btnCrearGrupo);
            this.panelSubmenuGrupos1.Location = new System.Drawing.Point(264, 329);
            this.panelSubmenuGrupos1.Name = "panelSubmenuGrupos1";
            this.panelSubmenuGrupos1.Size = new System.Drawing.Size(170, 296);
            this.panelSubmenuGrupos1.TabIndex = 13;
            // 
            // btnVerMasGrupos
            // 
            this.btnVerMasGrupos.ForeColor = System.Drawing.Color.Black;
            this.btnVerMasGrupos.Location = new System.Drawing.Point(1, 74);
            this.btnVerMasGrupos.Name = "btnVerMasGrupos";
            this.btnVerMasGrupos.Size = new System.Drawing.Size(164, 32);
            this.btnVerMasGrupos.TabIndex = 3;
            this.btnVerMasGrupos.Text = "Explorar Grupos";
            this.btnVerMasGrupos.UseVisualStyleBackColor = true;
            this.btnVerMasGrupos.Click += new System.EventHandler(this.btnVerMasGrupos_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarGrupo.Location = new System.Drawing.Point(1, 112);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(164, 32);
            this.btnEliminarGrupo.TabIndex = 2;
            this.btnEliminarGrupo.Text = "Eliminar Mis Grupos";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnVerMisGrupos
            // 
            this.btnVerMisGrupos.ForeColor = System.Drawing.Color.Black;
            this.btnVerMisGrupos.Location = new System.Drawing.Point(1, 35);
            this.btnVerMisGrupos.Name = "btnVerMisGrupos";
            this.btnVerMisGrupos.Size = new System.Drawing.Size(164, 32);
            this.btnVerMisGrupos.TabIndex = 1;
            this.btnVerMisGrupos.Text = "Ver Mis Grupos";
            this.btnVerMisGrupos.UseVisualStyleBackColor = true;
            this.btnVerMisGrupos.Click += new System.EventHandler(this.btnVerMisGrupos_Click);
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearGrupo.Location = new System.Drawing.Point(1, -1);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(164, 32);
            this.btnCrearGrupo.TabIndex = 0;
            this.btnCrearGrupo.Text = "CrearGrupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // panelSubmenuEventos1
            // 
            this.panelSubmenuEventos1.AutoScroll = true;
            this.panelSubmenuEventos1.AutoSize = true;
            this.panelSubmenuEventos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuEventos1.Controls.Add(this.btnEliminarMisEvento);
            this.panelSubmenuEventos1.Controls.Add(this.btnVerMisEventos);
            this.panelSubmenuEventos1.Controls.Add(this.btnCrearEvento);
            this.panelSubmenuEventos1.Location = new System.Drawing.Point(264, 366);
            this.panelSubmenuEventos1.Name = "panelSubmenuEventos1";
            this.panelSubmenuEventos1.Size = new System.Drawing.Size(170, 110);
            this.panelSubmenuEventos1.TabIndex = 15;
            // 
            // btnEliminarMisEvento
            // 
            this.btnEliminarMisEvento.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarMisEvento.Location = new System.Drawing.Point(1, 73);
            this.btnEliminarMisEvento.Name = "btnEliminarMisEvento";
            this.btnEliminarMisEvento.Size = new System.Drawing.Size(164, 32);
            this.btnEliminarMisEvento.TabIndex = 2;
            this.btnEliminarMisEvento.Text = "Eliminar Mis Eventos";
            this.btnEliminarMisEvento.UseVisualStyleBackColor = true;
            // 
            // btnVerMisEventos
            // 
            this.btnVerMisEventos.ForeColor = System.Drawing.Color.Black;
            this.btnVerMisEventos.Location = new System.Drawing.Point(1, 35);
            this.btnVerMisEventos.Name = "btnVerMisEventos";
            this.btnVerMisEventos.Size = new System.Drawing.Size(164, 32);
            this.btnVerMisEventos.TabIndex = 1;
            this.btnVerMisEventos.Text = "Ver Mis Eventos";
            this.btnVerMisEventos.UseVisualStyleBackColor = true;
            this.btnVerMisEventos.Click += new System.EventHandler(this.btnVerMisEventos_Click);
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEvento.Location = new System.Drawing.Point(1, -1);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(164, 32);
            this.btnCrearEvento.TabIndex = 0;
            this.btnCrearEvento.Text = "CrearEvento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // mainPage1
            // 
            this.mainPage1.Location = new System.Drawing.Point(243, 64);
            this.mainPage1.Margin = new System.Windows.Forms.Padding(2);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1672, 1009);
            this.mainPage1.TabIndex = 18;
            // 
            // interfazCrearGrupo1
            // 
            this.interfazCrearGrupo1.Location = new System.Drawing.Point(260, 256);
            this.interfazCrearGrupo1.Name = "interfazCrearGrupo1";
            this.interfazCrearGrupo1.Size = new System.Drawing.Size(671, 664);
            this.interfazCrearGrupo1.TabIndex = 17;
            // 
            // muroUsuario1
            // 
            this.muroUsuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muroUsuario1.Descripcion = "";
            this.muroUsuario1.Location = new System.Drawing.Point(243, 64);
            this.muroUsuario1.Margin = new System.Windows.Forms.Padding(4);
            this.muroUsuario1.Name = "muroUsuario1";
            this.muroUsuario1.Size = new System.Drawing.Size(1672, 1009);
            this.muroUsuario1.TabIndex = 16;
            this.muroUsuario1.UserName = "label3";
            // 
            // groupPage1
            // 
            this.groupPage1.BannerGrupo = null;
            this.groupPage1.DescripcionGrupo = "";
            this.groupPage1.IdGrupo = 0;
            this.groupPage1.ImagenGrupo = null;
            this.groupPage1.IntegrantesGrupo = null;
            this.groupPage1.Location = new System.Drawing.Point(243, 64);
            this.groupPage1.Margin = new System.Windows.Forms.Padding(2);
            this.groupPage1.Name = "groupPage1";
            this.groupPage1.NombreGrupo = "";
            this.groupPage1.Size = new System.Drawing.Size(1672, 1013);
            this.groupPage1.TabIndex = 11;
            // 
            // AppWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelSubmenuGrupos1);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.interfazCrearGrupo1);
            this.Controls.Add(this.panelSubmenuEventos1);
            this.Controls.Add(this.panelSubmenuActividades);
            this.Controls.Add(this.panelSubmenuEventos2);
            this.Controls.Add(this.panelSubmenuGrupos2);
            this.Controls.Add(this.muroUsuario1);
            this.Controls.Add(this.groupPage1);
            this.Controls.Add(this.txtBarraBusqueda);
            this.Controls.Add(this.panelIzquierdoMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.Name = "AppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinguaLink";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppWindow_FormClosed);
            this.Load += new System.EventHandler(this.AppWindow_Load);
            this.panelIzquierdoMain.ResumeLayout(false);
            this.panelIzquierdoMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).EndInit();
            this.panelSubmenuGrupos1.ResumeLayout(false);
            this.panelSubmenuEventos1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarraBusqueda;
        private System.Windows.Forms.Panel panelIzquierdoMain;
        private System.Windows.Forms.PictureBox pictureBoxImagenPerfil;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnPrincipal;
        private GroupPage groupPage1;
        private System.Windows.Forms.Panel panelSubmenuGrupos2;
        private System.Windows.Forms.Panel panelSubmenuEventos2;
        private System.Windows.Forms.Panel panelSubmenuActividades;
        private System.Windows.Forms.Panel panelSubmenuGrupos1;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnVerMisGrupos;
        private System.Windows.Forms.Panel panelSubmenuEventos1;
        private System.Windows.Forms.Button btnEliminarMisEvento;
        private System.Windows.Forms.Button btnVerMisEventos;
        private System.Windows.Forms.Button btnCrearEvento;
        private MuroUsuario muroUsuario1;
        private InterfazCrearGrupo interfazCrearGrupo1;
        private MaterialSkin.Controls.MaterialLabel txtUsernamePanelIzquierdo;
        public mainPage1 mainPage1;
        private System.Windows.Forms.Button btnVerMasGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnEnglish;
    }
}

