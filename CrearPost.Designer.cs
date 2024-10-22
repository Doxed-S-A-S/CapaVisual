
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
            this.panelTextoPost = new System.Windows.Forms.Panel();
            this.txtContenidoPost = new System.Windows.Forms.RichTextBox();
            this.panelImagenVideo = new System.Windows.Forms.Panel();
            this.lblAñadirImagen = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
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
            this.pboxImagenVideo = new System.Windows.Forms.PictureBox();
            this.materialCardCrearPost.SuspendLayout();
            this.panelTextoPost.SuspendLayout();
            this.panelImagenVideo.SuspendLayout();
            this.menuCrearPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCardCrearPost
            // 
            this.materialCardCrearPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardCrearPost.Controls.Add(this.panelTextoPost);
            this.materialCardCrearPost.Controls.Add(this.panelImagenVideo);
            this.materialCardCrearPost.Controls.Add(this.botonPostear);
            this.materialCardCrearPost.Controls.Add(this.materialLabel1);
            this.materialCardCrearPost.Controls.Add(this.menuCrearPost);
            this.materialCardCrearPost.Depth = 0;
            this.materialCardCrearPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardCrearPost.Location = new System.Drawing.Point(0, 0);
            this.materialCardCrearPost.Margin = new System.Windows.Forms.Padding(10, 4, 10, 11);
            this.materialCardCrearPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardCrearPost.Name = "materialCardCrearPost";
            this.materialCardCrearPost.Padding = new System.Windows.Forms.Padding(10, 0, 10, 11);
            this.materialCardCrearPost.Size = new System.Drawing.Size(440, 146);
            this.materialCardCrearPost.TabIndex = 1;
            // 
            // panelTextoPost
            // 
            this.panelTextoPost.Controls.Add(this.txtContenidoPost);
            this.panelTextoPost.Location = new System.Drawing.Point(10, 32);
            this.panelTextoPost.Margin = new System.Windows.Forms.Padding(2);
            this.panelTextoPost.Name = "panelTextoPost";
            this.panelTextoPost.Size = new System.Drawing.Size(323, 74);
            this.panelTextoPost.TabIndex = 12;
            // 
            // txtContenidoPost
            // 
            this.txtContenidoPost.Location = new System.Drawing.Point(2, 9);
            this.txtContenidoPost.Margin = new System.Windows.Forms.Padding(2);
            this.txtContenidoPost.Name = "txtContenidoPost";
            this.txtContenidoPost.Size = new System.Drawing.Size(316, 55);
            this.txtContenidoPost.TabIndex = 0;
            this.txtContenidoPost.Text = "";
            // 
            // panelImagenVideo
            // 
            this.panelImagenVideo.Controls.Add(this.lblAñadirImagen);
            this.panelImagenVideo.Controls.Add(this.btnBrowse);
            this.panelImagenVideo.Controls.Add(this.pboxImagenVideo);
            this.panelImagenVideo.Location = new System.Drawing.Point(10, 32);
            this.panelImagenVideo.Margin = new System.Windows.Forms.Padding(2);
            this.panelImagenVideo.Name = "panelImagenVideo";
            this.panelImagenVideo.Size = new System.Drawing.Size(323, 74);
            this.panelImagenVideo.TabIndex = 13;
            // 
            // lblAñadirImagen
            // 
            this.lblAñadirImagen.AutoSize = true;
            this.lblAñadirImagen.Location = new System.Drawing.Point(27, 29);
            this.lblAñadirImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñadirImagen.Name = "lblAñadirImagen";
            this.lblAñadirImagen.Size = new System.Drawing.Size(157, 13);
            this.lblAñadirImagen.TabIndex = 1;
            this.lblAñadirImagen.Text = "Arrastra una imagen o sube una";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(198, 24);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 19);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // botonPostear
            // 
            this.botonPostear.AutoSize = false;
            this.botonPostear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonPostear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.botonPostear.Depth = 0;
            this.botonPostear.HighEmphasis = true;
            this.botonPostear.Icon = null;
            this.botonPostear.Location = new System.Drawing.Point(352, 41);
            this.botonPostear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.botonPostear.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonPostear.Name = "botonPostear";
            this.botonPostear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.botonPostear.Size = new System.Drawing.Size(75, 29);
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
            this.materialLabel1.Location = new System.Drawing.Point(12, 12);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 18);
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
            this.menuCrearPost.Location = new System.Drawing.Point(10, 111);
            this.menuCrearPost.Name = "menuCrearPost";
            this.menuCrearPost.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuCrearPost.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuCrearPost.Size = new System.Drawing.Size(420, 24);
            this.menuCrearPost.TabIndex = 8;
            this.menuCrearPost.Text = "menuStrip1";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.contenidoToolStripMenuItem.Text = "Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler(this.contenidoToolStripMenuItem_Click_1);
            // 
            // btnImagenVideo
            // 
            this.btnImagenVideo.Name = "btnImagenVideo";
            this.btnImagenVideo.Size = new System.Drawing.Size(95, 20);
            this.btnImagenVideo.Text = "Imagen & Video";
            this.btnImagenVideo.Click += new System.EventHandler(this.btnImagenVideo_Click_1);
            // 
            // btnLink
            // 
            this.btnLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLinkCrearPost});
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(41, 20);
            this.btnLink.Text = "Link";
            // 
            // txtLinkCrearPost
            // 
            this.txtLinkCrearPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLinkCrearPost.Name = "txtLinkCrearPost";
            this.txtLinkCrearPost.Size = new System.Drawing.Size(100, 23);
            this.txtLinkCrearPost.Text = "inserte su link";
            this.txtLinkCrearPost.Enter += new System.EventHandler(this.txtLinkCrearPost_Enter_1);
            this.txtLinkCrearPost.Leave += new System.EventHandler(this.txtLinkCrearPost_Leave_1);
            this.txtLinkCrearPost.MouseLeave += new System.EventHandler(this.txtLinkCrearPost_MouseLeave);
            this.txtLinkCrearPost.MouseHover += new System.EventHandler(this.txtLinkCrearPost_MouseHover);
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
            this.btnTipoContenido.Size = new System.Drawing.Size(99, 20);
            this.btnTipoContenido.Text = "Tipo contenido";
            // 
            // btnContenidoIntercambioCultural
            // 
            this.btnContenidoIntercambioCultural.CheckOnClick = true;
            this.btnContenidoIntercambioCultural.Name = "btnContenidoIntercambioCultural";
            this.btnContenidoIntercambioCultural.Size = new System.Drawing.Size(183, 22);
            this.btnContenidoIntercambioCultural.Text = "Intercambio Cultural";
            // 
            // btnContenidoLenguaje
            // 
            this.btnContenidoLenguaje.CheckOnClick = true;
            this.btnContenidoLenguaje.Name = "btnContenidoLenguaje";
            this.btnContenidoLenguaje.Size = new System.Drawing.Size(183, 22);
            this.btnContenidoLenguaje.Text = "Lenguaje";
            // 
            // btnContenidoEducacion
            // 
            this.btnContenidoEducacion.CheckOnClick = true;
            this.btnContenidoEducacion.Name = "btnContenidoEducacion";
            this.btnContenidoEducacion.Size = new System.Drawing.Size(183, 22);
            this.btnContenidoEducacion.Text = "Educacion";
            // 
            // pboxImagenVideo
            // 
            this.pboxImagenVideo.BackColor = System.Drawing.Color.White;
            this.pboxImagenVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxImagenVideo.Location = new System.Drawing.Point(2, 9);
            this.pboxImagenVideo.Margin = new System.Windows.Forms.Padding(2);
            this.pboxImagenVideo.Name = "pboxImagenVideo";
            this.pboxImagenVideo.Size = new System.Drawing.Size(315, 54);
            this.pboxImagenVideo.TabIndex = 0;
            this.pboxImagenVideo.TabStop = false;
            this.pboxImagenVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pboxImagenVideo_DragDrop_1);
            this.pboxImagenVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pboxImagenVideo_DragEnter_1);
            // 
            // CrearPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCardCrearPost);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearPost";
            this.Size = new System.Drawing.Size(441, 146);
            this.materialCardCrearPost.ResumeLayout(false);
            this.materialCardCrearPost.PerformLayout();
            this.panelTextoPost.ResumeLayout(false);
            this.panelImagenVideo.ResumeLayout(false);
            this.panelImagenVideo.PerformLayout();
            this.menuCrearPost.ResumeLayout(false);
            this.menuCrearPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCardCrearPost;
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
