
namespace CapaVisual
{
    partial class ComentarioDialog
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
            this.panelContendorDePost = new System.Windows.Forms.Panel();
            this.panelContenedorDeComentarios = new System.Windows.Forms.Panel();
            this.panelCrearComentario = new System.Windows.Forms.Panel();
            this.btnCompartirComentario = new System.Windows.Forms.Button();
            this.pboxPerfilCrearComentario = new System.Windows.Forms.PictureBox();
            this.txtCrearComentario = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCrearComentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfilCrearComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContendorDePost
            // 
            this.panelContendorDePost.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelContendorDePost.Location = new System.Drawing.Point(0, 0);
            this.panelContendorDePost.Name = "panelContendorDePost";
            this.panelContendorDePost.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panelContendorDePost.Size = new System.Drawing.Size(697, 362);
            this.panelContendorDePost.TabIndex = 0;
            // 
            // panelContenedorDeComentarios
            // 
            this.panelContenedorDeComentarios.AutoScroll = true;
            this.panelContenedorDeComentarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedorDeComentarios.Location = new System.Drawing.Point(0, 363);
            this.panelContenedorDeComentarios.Name = "panelContenedorDeComentarios";
            this.panelContenedorDeComentarios.Size = new System.Drawing.Size(703, 10);
            this.panelContenedorDeComentarios.TabIndex = 1;
            // 
            // panelCrearComentario
            // 
            this.panelCrearComentario.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCrearComentario.Controls.Add(this.btnCompartirComentario);
            this.panelCrearComentario.Controls.Add(this.pboxPerfilCrearComentario);
            this.panelCrearComentario.Controls.Add(this.txtCrearComentario);
            this.panelCrearComentario.Location = new System.Drawing.Point(0, 374);
            this.panelCrearComentario.Name = "panelCrearComentario";
            this.panelCrearComentario.Size = new System.Drawing.Size(697, 100);
            this.panelCrearComentario.TabIndex = 2;
            // 
            // btnCompartirComentario
            // 
            this.btnCompartirComentario.BackColor = System.Drawing.Color.White;
            this.btnCompartirComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompartirComentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompartirComentario.Image = global::CapaVisual.Properties.Resources.Send_Email_by_iconSvg_co;
            this.btnCompartirComentario.Location = new System.Drawing.Point(543, 56);
            this.btnCompartirComentario.Name = "btnCompartirComentario";
            this.btnCompartirComentario.Size = new System.Drawing.Size(36, 31);
            this.btnCompartirComentario.TabIndex = 2;
            this.btnCompartirComentario.UseVisualStyleBackColor = false;
            this.btnCompartirComentario.Click += new System.EventHandler(this.btnCompartirComentario_Click);
            // 
            // pboxPerfilCrearComentario
            // 
            this.pboxPerfilCrearComentario.Location = new System.Drawing.Point(14, 11);
            this.pboxPerfilCrearComentario.Name = "pboxPerfilCrearComentario";
            this.pboxPerfilCrearComentario.Size = new System.Drawing.Size(62, 59);
            this.pboxPerfilCrearComentario.TabIndex = 1;
            this.pboxPerfilCrearComentario.TabStop = false;
            this.pboxPerfilCrearComentario.Click += new System.EventHandler(this.pboxPerfilCrearComentario_Click);
            // 
            // txtCrearComentario
            // 
            this.txtCrearComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrearComentario.Location = new System.Drawing.Point(102, 11);
            this.txtCrearComentario.Name = "txtCrearComentario";
            this.txtCrearComentario.Size = new System.Drawing.Size(426, 76);
            this.txtCrearComentario.TabIndex = 0;
            this.txtCrearComentario.Text = "";
            this.txtCrearComentario.TextChanged += new System.EventHandler(this.txtCrearComentario_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 494);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 187);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ComentarioDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 683);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelCrearComentario);
            this.Controls.Add(this.panelContenedorDeComentarios);
            this.Controls.Add(this.panelContendorDePost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComentarioDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.panelCrearComentario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfilCrearComentario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContendorDePost;
        private System.Windows.Forms.Panel panelContenedorDeComentarios;
        private System.Windows.Forms.Panel panelCrearComentario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCompartirComentario;
        private System.Windows.Forms.PictureBox pboxPerfilCrearComentario;
        private System.Windows.Forms.RichTextBox txtCrearComentario;
    }
}