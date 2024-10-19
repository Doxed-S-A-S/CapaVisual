
namespace CapaVisual
{
    partial class mainPage1
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
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.divisorDerecho = new MaterialSkin.Controls.MaterialDivider();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImagenVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLink = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLinkCrearPost = new System.Windows.Forms.ToolStripTextBox();
            this.btnTipoContenido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoIntercambioCultural = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoLenguaje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContenidoEducacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCrearPost = new System.Windows.Forms.MenuStrip();
            this.crearPost1 = new CapaVisual.CrearPost();
            this.flowLayoutCrearPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.menuCrearPost.SuspendLayout();
            this.flowLayoutCrearPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.LightGray;
            this.panelDerecho.Location = new System.Drawing.Point(818, 1);
            this.panelDerecho.Margin = new System.Windows.Forms.Padding(2);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(150, 605);
            this.panelDerecho.TabIndex = 10;
            // 
            // divisorDerecho
            // 
            this.divisorDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divisorDerecho.Depth = 0;
            this.divisorDerecho.Location = new System.Drawing.Point(2, 0);
            this.divisorDerecho.Margin = new System.Windows.Forms.Padding(2);
            this.divisorDerecho.MouseState = MaterialSkin.MouseState.HOVER;
            this.divisorDerecho.Name = "divisorDerecho";
            this.divisorDerecho.Size = new System.Drawing.Size(10, 605);
            this.divisorDerecho.TabIndex = 7;
            this.divisorDerecho.Text = "materialDivider1";
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanelPosts.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(16, 160);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Padding = new System.Windows.Forms.Padding(78, 0, 52, 0);
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(797, 446);
            this.flowLayoutPanelPosts.TabIndex = 8;
            this.flowLayoutPanelPosts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanelPosts_Scroll);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(734, 30);
            this.miniToolStrip.TabIndex = 8;
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.contenidoToolStripMenuItem.Text = "Contenido";
            // 
            // btnImagenVideo
            // 
            this.btnImagenVideo.Name = "btnImagenVideo";
            this.btnImagenVideo.Size = new System.Drawing.Size(95, 26);
            this.btnImagenVideo.Text = "Imagen & Video";
            // 
            // btnLink
            // 
            this.btnLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLinkCrearPost});
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(41, 26);
            this.btnLink.Text = "Link";
            // 
            // txtLinkCrearPost
            // 
            this.txtLinkCrearPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLinkCrearPost.Name = "txtLinkCrearPost";
            this.txtLinkCrearPost.Size = new System.Drawing.Size(100, 23);
            this.txtLinkCrearPost.Text = "inserte su link";
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
            this.btnTipoContenido.Size = new System.Drawing.Size(99, 26);
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
            // crearPost1
            // 
            this.crearPost1.Location = new System.Drawing.Point(80, 2);
            this.crearPost1.Margin = new System.Windows.Forms.Padding(2);
            this.crearPost1.Name = "crearPost1";
            this.crearPost1.Size = new System.Drawing.Size(572, 146);
            this.crearPost1.TabIndex = 0;
            // 
            // flowLayoutCrearPosts
            // 
            this.flowLayoutCrearPosts.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutCrearPosts.Controls.Add(this.crearPost1);
            this.flowLayoutCrearPosts.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutCrearPosts.Location = new System.Drawing.Point(16, 2);
            this.flowLayoutCrearPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutCrearPosts.Name = "flowLayoutCrearPosts";
            this.flowLayoutCrearPosts.Padding = new System.Windows.Forms.Padding(78, 0, 0, 0);
            this.flowLayoutCrearPosts.Size = new System.Drawing.Size(797, 153);
            this.flowLayoutCrearPosts.TabIndex = 9;
            // 
            // mainPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.flowLayoutCrearPosts);
            this.Controls.Add(this.divisorDerecho);
            this.Controls.Add(this.flowLayoutPanelPosts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainPage1";
            this.Size = new System.Drawing.Size(972, 611);
            this.menuCrearPost.ResumeLayout(false);
            this.menuCrearPost.PerformLayout();
            this.flowLayoutCrearPosts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDerecho;
        private MaterialSkin.Controls.MaterialDivider divisorDerecho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImagenVideo;
        private System.Windows.Forms.ToolStripMenuItem btnLink;
        private System.Windows.Forms.ToolStripTextBox txtLinkCrearPost;
        private System.Windows.Forms.ToolStripMenuItem btnTipoContenido;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoIntercambioCultural;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoLenguaje;
        private System.Windows.Forms.ToolStripMenuItem btnContenidoEducacion;
        private System.Windows.Forms.MenuStrip menuCrearPost;
        private CrearPost crearPost1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCrearPosts;
    }
}
