
namespace CapaVisual
{
    partial class CrearPost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCardCrearPost = new MaterialSkin.Controls.MaterialCard();
            this.comBoxSeleccionarGrupo = new System.Windows.Forms.ComboBox();
            this.panelTextoPost = new System.Windows.Forms.Panel();
            this.txtContenidoPost = new System.Windows.Forms.RichTextBox();
            this.panelImagenVideo = new System.Windows.Forms.Panel();
            this.lblAñadirImagen = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pboxImagenVideo = new System.Windows.Forms.PictureBox();
            this.botonPostear = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.menuCrearPost = new System.Windows.Forms.MenuStrip();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImagenVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLink = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLinkCrearPost = new System.Windows.Forms.ToolStripTextBox();
            this.btnTipoContenido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoIntercambioCultural = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoLenguaje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoEducacion = new System.Windows.Forms.ToolStripMenuItem();
            this.materialCardCrearPost.SuspendLayout();
            this.panelTextoPost.SuspendLayout();
            this.panelImagenVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenVideo)).BeginInit();
            this.menuCrearPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCardCrearPost
            // 
            this.materialCardCrearPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardCrearPost.Controls.Add(this.comBoxSeleccionarGrupo);
            this.materialCardCrearPost.Controls.Add(this.panelTextoPost);
            this.materialCardCrearPost.Controls.Add(this.panelImagenVideo);
            this.materialCardCrearPost.Controls.Add(this.botonPostear);
            this.materialCardCrearPost.Controls.Add(this.materialLabel1);
            this.materialCardCrearPost.Controls.Add(this.menuCrearPost);
            this.materialCardCrearPost.Depth = 0;
            this.materialCardCrearPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardCrearPost.Location = new System.Drawing.Point(0, 0);
            this.materialCardCrearPost.Margin = new System.Windows.Forms.Padding(14, 5, 14, 14);
            this.materialCardCrearPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardCrearPost.Name = "materialCardCrearPost";
            this.materialCardCrearPost.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.materialCardCrearPost.Size = new System.Drawing.Size(762, 180);
            this.materialCardCrearPost.TabIndex = 1;
            // 
            // comBoxSeleccionarGrupo
            // 
            this.comBoxSeleccionarGrupo.FormattingEnabled = true;
            this.comBoxSeleccionarGrupo.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "as",
            "d"});
            this.comBoxSeleccionarGrupo.Location = new System.Drawing.Point(469, 105);
            this.comBoxSeleccionarGrupo.Name = "comBoxSeleccionarGrupo";
            this.comBoxSeleccionarGrupo.Size = new System.Drawing.Size(165, 24);
            this.comBoxSeleccionarGrupo.TabIndex = 0;
            this.comBoxSeleccionarGrupo.Text = "Seleccione un grupo";
            this.comBoxSeleccionarGrupo.DropDown += new System.EventHandler(this.comBoxSeleccionarGrupo_DropDown_1);
            this.comBoxSeleccionarGrupo.SelectedIndexChanged += new System.EventHandler(this.comBoxSeleccionarGrupo_SelectedIndexChanged_1);
            this.comBoxSeleccionarGrupo.Leave += new System.EventHandler(this.comBoxSeleccionarGrupo_Leave_1);
            // 
            // panelTextoPost
            // 
            this.panelTextoPost.Controls.Add(this.txtContenidoPost);
            this.panelTextoPost.Location = new System.Drawing.Point(14, 39);
            this.panelTextoPost.Name = "panelTextoPost";
            this.panelTextoPost.Size = new System.Drawing.Size(431, 91);
            this.panelTextoPost.TabIndex = 12;
            // 
            // txtContenidoPost
            // 
            this.txtContenidoPost.Location = new System.Drawing.Point(3, 11);
            this.txtContenidoPost.Name = "txtContenidoPost";
            this.txtContenidoPost.Size = new System.Drawing.Size(420, 67);
            this.txtContenidoPost.TabIndex = 0;
            this.txtContenidoPost.Text = "";
            // 
            // panelImagenVideo
            // 
            this.panelImagenVideo.Controls.Add(this.lblAñadirImagen);
            this.panelImagenVideo.Controls.Add(this.btnBrowse);
            this.panelImagenVideo.Controls.Add(this.pboxImagenVideo);
            this.panelImagenVideo.Location = new System.Drawing.Point(14, 39);
            this.panelImagenVideo.Name = "panelImagenVideo";
            this.panelImagenVideo.Size = new System.Drawing.Size(431, 91);
            this.panelImagenVideo.TabIndex = 13;
            // 
            // lblAñadirImagen
            // 
            this.lblAñadirImagen.AutoSize = true;
            this.lblAñadirImagen.Location = new System.Drawing.Point(36, 36);
            this.lblAñadirImagen.Name = "lblAñadirImagen";
            this.lblAñadirImagen.Size = new System.Drawing.Size(212, 17);
            this.lblAñadirImagen.TabIndex = 1;
            this.lblAñadirImagen.Text = "Arrastra una imagen o sube una";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(264, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // pboxImagenVideo
            // 
            this.pboxImagenVideo.BackColor = System.Drawing.Color.Red;
            this.pboxImagenVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxImagenVideo.Location = new System.Drawing.Point(3, 11);
            this.pboxImagenVideo.Name = "pboxImagenVideo";
            this.pboxImagenVideo.Size = new System.Drawing.Size(420, 67);
            this.pboxImagenVideo.TabIndex = 0;
            this.pboxImagenVideo.TabStop = false;
            this.pboxImagenVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pboxImagenVideo_DragDrop_1);
            this.pboxImagenVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pboxImagenVideo_DragEnter_1);
            // 
            // botonPostear
            // 
            this.botonPostear.AutoSize = false;
            this.botonPostear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonPostear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.botonPostear.Depth = 0;
            this.botonPostear.HighEmphasis = true;
            this.botonPostear.Icon = null;
            this.botonPostear.Location = new System.Drawing.Point(469, 50);
            this.botonPostear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.botonPostear.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonPostear.Name = "botonPostear";
            this.botonPostear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.botonPostear.Size = new System.Drawing.Size(100, 36);
            this.botonPostear.TabIndex = 10;
            this.botonPostear.Text = "Postear";
            this.botonPostear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.botonPostear.UseAccentColor = false;
            this.botonPostear.UseVisualStyleBackColor = true;
            this.botonPostear.Click += new System.EventHandler(this.botonPostear_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 17);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Crear Post";
            // 
            // menuCrearPost
            // 
            this.menuCrearPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuCrearPost.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuCrearPost.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCrearPost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenidoToolStripMenuItem,
            this.btnImagenVideo,
            this.btnLink,
            this.btnTipoContenido});
            this.menuCrearPost.Location = new System.Drawing.Point(14, 136);
            this.menuCrearPost.Name = "menuCrearPost";
            this.menuCrearPost.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuCrearPost.Size = new System.Drawing.Size(734, 30);
            this.menuCrearPost.TabIndex = 8;
            this.menuCrearPost.Text = "menuStrip1";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.contenidoToolStripMenuItem.Text = "Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler(this.contenidoToolStripMenuItem_Click_1);
            // 
            // btnImagenVideo
            // 
            this.btnImagenVideo.Name = "btnImagenVideo";
            this.btnImagenVideo.Size = new System.Drawing.Size(120, 26);
            this.btnImagenVideo.Text = "Imagen & Video";
            this.btnImagenVideo.Click += new System.EventHandler(this.btnImagenVideo_Click_1);
            // 
            // btnLink
            // 
            this.btnLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLinkCrearPost});
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(49, 26);
            this.btnLink.Text = "Link";
            // 
            // txtLinkCrearPost
            // 
            this.txtLinkCrearPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLinkCrearPost.Name = "txtLinkCrearPost";
            this.txtLinkCrearPost.Size = new System.Drawing.Size(100, 27);
            this.txtLinkCrearPost.Text = "inserte su link";
            this.txtLinkCrearPost.Enter += new System.EventHandler(this.txtLinkCrearPost_Enter_1);
            this.txtLinkCrearPost.Leave += new System.EventHandler(this.txtLinkCrearPost_Leave_1);
            // 
            // btnTipoContenido
            // 
            this.btnTipoContenido.Checked = true;
            this.btnTipoContenido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnTipoContenido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnContenidoIntercambioCultural,
            this.btnContenidoLenguaje,
            this.btnContenidoEducacion});
            this.btnTipoContenido.Name = "btnTipoContenido";
            this.btnTipoContenido.Size = new System.Drawing.Size(124, 24);
            this.btnTipoContenido.Text = "Tipo contenido";
            // 
            // btnContenidoIntercambioCultural
            // 
            this.btnContenidoIntercambioCultural.CheckOnClick = true;
            this.btnContenidoIntercambioCultural.Name = "btnContenidoIntercambioCultural";
            this.btnContenidoIntercambioCultural.Size = new System.Drawing.Size(227, 26);
            this.btnContenidoIntercambioCultural.Text = "Intercambio Cultural";
            // 
            // btnContenidoLenguaje
            // 
            this.btnContenidoLenguaje.CheckOnClick = true;
            this.btnContenidoLenguaje.Name = "btnContenidoLenguaje";
            this.btnContenidoLenguaje.Size = new System.Drawing.Size(227, 26);
            this.btnContenidoLenguaje.Text = "Lenguaje";
            // 
            // btnContenidoEducacion
            // 
            this.btnContenidoEducacion.CheckOnClick = true;
            this.btnContenidoEducacion.Name = "btnContenidoEducacion";
            this.btnContenidoEducacion.Size = new System.Drawing.Size(227, 26);
            this.btnContenidoEducacion.Text = "Educacion";
            // 
            // CrearPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCardCrearPost);
            this.Name = "CrearPost";
            this.Size = new System.Drawing.Size(762, 180);
            this.materialCardCrearPost.ResumeLayout(false);
            this.materialCardCrearPost.PerformLayout();
            this.panelTextoPost.ResumeLayout(false);
            this.panelImagenVideo.ResumeLayout(false);
            this.panelImagenVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenVideo)).EndInit();
            this.menuCrearPost.ResumeLayout(false);
            this.menuCrearPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCardCrearPost;
        private System.Windows.Forms.ComboBox comBoxSeleccionarGrupo;
        private System.Windows.Forms.Panel panelTextoPost;
        private System.Windows.Forms.RichTextBox txtContenidoPost;
        private System.Windows.Forms.Panel panelImagenVideo;
        private System.Windows.Forms.Label lblAñadirImagen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pboxImagenVideo;
        private MaterialSkin.Controls.MaterialButton botonPostear;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.MenuStrip menuCrearPost;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImagenVideo;
        private System.Windows.Forms.ToolStripMenuItem btnLink;
        private System.Windows.Forms.ToolStripTextBox txtLinkCrearPost;
        private System.Windows.Forms.ToolStripMenuItem btnTipoContenido;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoIntercambioCultural;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoLenguaje;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoEducacion;
    }
}
