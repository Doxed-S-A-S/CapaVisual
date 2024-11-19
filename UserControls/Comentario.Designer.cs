
namespace CapaVisual.UserControls
{
    partial class Comentario
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
            this.txtContenidoComentario = new System.Windows.Forms.RichTextBox();
            this.txtLikeCount = new System.Windows.Forms.Label();
            this.txtUsuarioComentario = new System.Windows.Forms.Label();
            this.txtFechaComentario = new System.Windows.Forms.Label();
            this.btnLikeComentario = new System.Windows.Forms.Button();
            this.pboxPerfilComentario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfilComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContenidoComentario
            // 
            this.txtContenidoComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenidoComentario.Location = new System.Drawing.Point(100, 16);
            this.txtContenidoComentario.Name = "txtContenidoComentario";
            this.txtContenidoComentario.Size = new System.Drawing.Size(426, 76);
            this.txtContenidoComentario.TabIndex = 2;
            this.txtContenidoComentario.Text = "";
            // 
            // txtLikeCount
            // 
            this.txtLikeCount.AutoSize = true;
            this.txtLikeCount.Location = new System.Drawing.Point(97, 107);
            this.txtLikeCount.Name = "txtLikeCount";
            this.txtLikeCount.Size = new System.Drawing.Size(0, 13);
            this.txtLikeCount.TabIndex = 5;
            // 
            // txtUsuarioComentario
            // 
            this.txtUsuarioComentario.AutoSize = true;
            this.txtUsuarioComentario.Location = new System.Drawing.Point(13, 79);
            this.txtUsuarioComentario.Name = "txtUsuarioComentario";
            this.txtUsuarioComentario.Size = new System.Drawing.Size(0, 13);
            this.txtUsuarioComentario.TabIndex = 6;
            // 
            // txtFechaComentario
            // 
            this.txtFechaComentario.AutoSize = true;
            this.txtFechaComentario.Location = new System.Drawing.Point(460, 98);
            this.txtFechaComentario.Name = "txtFechaComentario";
            this.txtFechaComentario.Size = new System.Drawing.Size(0, 13);
            this.txtFechaComentario.TabIndex = 7;
            // 
            // btnLikeComentario
            // 
            this.btnLikeComentario.BackColor = System.Drawing.Color.White;
            this.btnLikeComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLikeComentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLikeComentario.Image = global::CapaVisual.Properties.Resources.Heart_Attack_by_iconSvg1;
            this.btnLikeComentario.Location = new System.Drawing.Point(138, 98);
            this.btnLikeComentario.Name = "btnLikeComentario";
            this.btnLikeComentario.Size = new System.Drawing.Size(36, 31);
            this.btnLikeComentario.TabIndex = 4;
            this.btnLikeComentario.UseVisualStyleBackColor = false;
            // 
            // pboxPerfilComentario
            // 
            this.pboxPerfilComentario.Location = new System.Drawing.Point(12, 16);
            this.pboxPerfilComentario.Name = "pboxPerfilComentario";
            this.pboxPerfilComentario.Size = new System.Drawing.Size(62, 59);
            this.pboxPerfilComentario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPerfilComentario.TabIndex = 3;
            this.pboxPerfilComentario.TabStop = false;
            // 
            // Comentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFechaComentario);
            this.Controls.Add(this.txtUsuarioComentario);
            this.Controls.Add(this.txtLikeCount);
            this.Controls.Add(this.btnLikeComentario);
            this.Controls.Add(this.pboxPerfilComentario);
            this.Controls.Add(this.txtContenidoComentario);
            this.Name = "Comentario";
            this.Size = new System.Drawing.Size(565, 132);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPerfilComentario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPerfilComentario;
        private System.Windows.Forms.RichTextBox txtContenidoComentario;
        private System.Windows.Forms.Button btnLikeComentario;
        private System.Windows.Forms.Label txtLikeCount;
        private System.Windows.Forms.Label txtUsuarioComentario;
        private System.Windows.Forms.Label txtFechaComentario;
    }
}
