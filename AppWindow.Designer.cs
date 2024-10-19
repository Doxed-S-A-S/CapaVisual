
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
            this.panelCrearPost = new System.Windows.Forms.Panel();
            this.pictureBoxImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.groupPage1 = new CapaVisual.GroupPage();
            this.mainPage1 = new CapaVisual.mainPage1();
            this.panelSubmenuGrupos2 = new System.Windows.Forms.Panel();
            this.panelSubmenuEventos2 = new System.Windows.Forms.Panel();
            this.panelSubmenuActividades = new System.Windows.Forms.Panel();
            this.panelSubmenuGrupos1 = new System.Windows.Forms.Panel();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnVerMisGrupos = new System.Windows.Forms.Button();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.panelSubmenuEventos1 = new System.Windows.Forms.Panel();
            this.btnEliminarMisEvento = new System.Windows.Forms.Button();
            this.btnVerMisEventos = new System.Windows.Forms.Button();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.panelCrearPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).BeginInit();
            this.panelSubmenuGrupos1.SuspendLayout();
            this.panelSubmenuEventos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarraBusqueda.Location = new System.Drawing.Point(428, 33);
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(459, 20);
            this.txtBarraBusqueda.TabIndex = 7;
            // 
            // panelCrearPost
            // 
            this.panelCrearPost.BackColor = System.Drawing.Color.LightGray;
            this.panelCrearPost.Controls.Add(this.pictureBoxImagenPerfil);
            this.panelCrearPost.Controls.Add(this.btnActividades);
            this.panelCrearPost.Controls.Add(this.btnEventos);
            this.panelCrearPost.Controls.Add(this.btnGrupos);
            this.panelCrearPost.Controls.Add(this.btnPrincipal);
            this.panelCrearPost.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCrearPost.Location = new System.Drawing.Point(3, 64);
            this.panelCrearPost.Margin = new System.Windows.Forms.Padding(2);
            this.panelCrearPost.Name = "panelCrearPost";
            this.panelCrearPost.Size = new System.Drawing.Size(170, 642);
            this.panelCrearPost.TabIndex = 10;
            // 
            // pictureBoxImagenPerfil
            // 
            this.pictureBoxImagenPerfil.Image = global::CapaVisual.Properties.Resources.Profile_Picture_by_iconSvg_co;
            this.pictureBoxImagenPerfil.Location = new System.Drawing.Point(65, 72);
            this.pictureBoxImagenPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImagenPerfil.Name = "pictureBoxImagenPerfil";
            this.pictureBoxImagenPerfil.Size = new System.Drawing.Size(40, 44);
            this.pictureBoxImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImagenPerfil.TabIndex = 4;
            this.pictureBoxImagenPerfil.TabStop = false;
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.LightGray;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActividades.Location = new System.Drawing.Point(3, 270);
            this.btnActividades.Margin = new System.Windows.Forms.Padding(2);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(164, 32);
            this.btnActividades.TabIndex = 3;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.LightGray;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEventos.Location = new System.Drawing.Point(3, 232);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(164, 32);
            this.btnEventos.TabIndex = 2;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.BackColor = System.Drawing.Color.LightGray;
            this.btnGrupos.FlatAppearance.BorderSize = 0;
            this.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrupos.Location = new System.Drawing.Point(3, 195);
            this.btnGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(164, 32);
            this.btnGrupos.TabIndex = 1;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = false;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrincipal.Location = new System.Drawing.Point(3, 158);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(166, 32);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            // 
            // groupPage1
            // 
            this.groupPage1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPage1.Location = new System.Drawing.Point(1666, 64);
            this.groupPage1.Margin = new System.Windows.Forms.Padding(2);
            this.groupPage1.Name = "groupPage1";
            this.groupPage1.Size = new System.Drawing.Size(967, 642);
            this.groupPage1.TabIndex = 11;
            // 
            // mainPage1
            // 
            this.mainPage1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPage1.Location = new System.Drawing.Point(173, 64);
            this.mainPage1.Margin = new System.Windows.Forms.Padding(2);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1493, 642);
            this.mainPage1.TabIndex = 8;
            // 
            // panelSubmenuGrupos2
            // 
            this.panelSubmenuGrupos2.AutoScroll = true;
            this.panelSubmenuGrupos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuGrupos2.Location = new System.Drawing.Point(191, 256);
            this.panelSubmenuGrupos2.Name = "panelSubmenuGrupos2";
            this.panelSubmenuGrupos2.Size = new System.Drawing.Size(200, 281);
            this.panelSubmenuGrupos2.TabIndex = 12;
            // 
            // panelSubmenuEventos2
            // 
            this.panelSubmenuEventos2.AutoScroll = true;
            this.panelSubmenuEventos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuEventos2.Location = new System.Drawing.Point(191, 294);
            this.panelSubmenuEventos2.Name = "panelSubmenuEventos2";
            this.panelSubmenuEventos2.Size = new System.Drawing.Size(200, 281);
            this.panelSubmenuEventos2.TabIndex = 13;
            // 
            // panelSubmenuActividades
            // 
            this.panelSubmenuActividades.AutoScroll = true;
            this.panelSubmenuActividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuActividades.Location = new System.Drawing.Point(191, 334);
            this.panelSubmenuActividades.Name = "panelSubmenuActividades";
            this.panelSubmenuActividades.Size = new System.Drawing.Size(200, 281);
            this.panelSubmenuActividades.TabIndex = 14;
            // 
            // panelSubmenuGrupos1
            // 
            this.panelSubmenuGrupos1.AutoScroll = true;
            this.panelSubmenuGrupos1.AutoSize = true;
            this.panelSubmenuGrupos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuGrupos1.Controls.Add(this.btnEliminarGrupo);
            this.panelSubmenuGrupos1.Controls.Add(this.btnVerMisGrupos);
            this.panelSubmenuGrupos1.Controls.Add(this.btnCrearGrupo);
            this.panelSubmenuGrupos1.Location = new System.Drawing.Point(192, 256);
            this.panelSubmenuGrupos1.Name = "panelSubmenuGrupos1";
            this.panelSubmenuGrupos1.Size = new System.Drawing.Size(170, 110);
            this.panelSubmenuGrupos1.TabIndex = 13;
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarGrupo.Location = new System.Drawing.Point(1, 73);
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
            // 
            // panelSubmenuEventos1
            // 
            this.panelSubmenuEventos1.AutoScroll = true;
            this.panelSubmenuEventos1.AutoSize = true;
            this.panelSubmenuEventos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmenuEventos1.Controls.Add(this.btnEliminarMisEvento);
            this.panelSubmenuEventos1.Controls.Add(this.btnVerMisEventos);
            this.panelSubmenuEventos1.Controls.Add(this.btnCrearEvento);
            this.panelSubmenuEventos1.Location = new System.Drawing.Point(192, 296);
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
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1499, 709);
            this.Controls.Add(this.panelSubmenuEventos1);
            this.Controls.Add(this.panelSubmenuGrupos1);
            this.Controls.Add(this.panelSubmenuActividades);
            this.Controls.Add(this.panelSubmenuEventos2);
            this.Controls.Add(this.panelSubmenuGrupos2);
            this.Controls.Add(this.groupPage1);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.txtBarraBusqueda);
            this.Controls.Add(this.panelCrearPost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.Name = "AppWindow";
            this.Text = "LinguaLink";
            this.panelCrearPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPerfil)).EndInit();
            this.panelSubmenuGrupos1.ResumeLayout(false);
            this.panelSubmenuEventos1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarraBusqueda;
        
        private mainPage1 mainPage1;
        private System.Windows.Forms.Panel panelCrearPost;
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
    }
}

