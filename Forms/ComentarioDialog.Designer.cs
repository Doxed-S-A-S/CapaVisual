
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 114);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedorDeComentarios);
            this.Controls.Add(this.panelContendorDePost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComentarioDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContendorDePost;
        private System.Windows.Forms.Panel panelContenedorDeComentarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}