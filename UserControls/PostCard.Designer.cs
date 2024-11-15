
namespace CapaVisual
{
    partial class PostCard
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtLikesPost = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.btnLikePost = new System.Windows.Forms.Button();
            this.btnComentarios = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBoxFotoPerfilPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagenPost = new System.Windows.Forms.PictureBox();
            this.txtContenidoPost = new System.Windows.Forms.RichTextBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPost)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtLikesPost);
            this.materialCard1.Controls.Add(this.btnCompartir);
            this.materialCard1.Controls.Add(this.btnLikePost);
            this.materialCard1.Controls.Add(this.btnComentarios);
            this.materialCard1.Controls.Add(this.lblUsername);
            this.materialCard1.Controls.Add(this.pictureBoxFotoPerfilPost);
            this.materialCard1.Controls.Add(this.pictureBoxImagenPost);
            this.materialCard1.Controls.Add(this.txtContenidoPost);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(523, 326);
            this.materialCard1.TabIndex = 0;
            // 
            // txtLikesPost
            // 
            this.txtLikesPost.AutoSize = true;
            this.txtLikesPost.Depth = 0;
            this.txtLikesPost.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLikesPost.Location = new System.Drawing.Point(104, 238);
            this.txtLikesPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLikesPost.Name = "txtLikesPost";
            this.txtLikesPost.Size = new System.Drawing.Size(1, 0);
            this.txtLikesPost.TabIndex = 8;
            // 
            // btnCompartir
            // 
            this.btnCompartir.Image = global::CapaVisual.Properties.Resources.Share_by_iconSvg_co_2_;
            this.btnCompartir.Location = new System.Drawing.Point(201, 232);
            this.btnCompartir.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Size = new System.Drawing.Size(32, 28);
            this.btnCompartir.TabIndex = 7;
            this.btnCompartir.UseVisualStyleBackColor = true;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click);
            // 
            // btnLikePost
            // 
            this.btnLikePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLikePost.Image = global::CapaVisual.Properties.Resources.Be_Like_by_iconSvg_co_2_;
            this.btnLikePost.Location = new System.Drawing.Point(128, 232);
            this.btnLikePost.Margin = new System.Windows.Forms.Padding(2);
            this.btnLikePost.Name = "btnLikePost";
            this.btnLikePost.Size = new System.Drawing.Size(32, 28);
            this.btnLikePost.TabIndex = 5;
            this.btnLikePost.UseVisualStyleBackColor = true;
            this.btnLikePost.Click += new System.EventHandler(this.btnLikePost_Click);
            // 
            // btnComentarios
            // 
            this.btnComentarios.Image = global::CapaVisual.Properties.Resources.Messaging_by_iconSvg_co;
            this.btnComentarios.Location = new System.Drawing.Point(164, 232);
            this.btnComentarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnComentarios.Name = "btnComentarios";
            this.btnComentarios.Size = new System.Drawing.Size(32, 28);
            this.btnComentarios.TabIndex = 4;
            this.btnComentarios.UseVisualStyleBackColor = true;
            this.btnComentarios.Click += new System.EventHandler(this.btnComentarios_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Miriam CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUsername.Location = new System.Drawing.Point(30, 78);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // pictureBoxFotoPerfilPost
            // 
            this.pictureBoxFotoPerfilPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoPerfilPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFotoPerfilPost.Image = global::CapaVisual.Properties.Resources.downytfytload;
            this.pictureBoxFotoPerfilPost.Location = new System.Drawing.Point(26, 24);
            this.pictureBoxFotoPerfilPost.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFotoPerfilPost.Name = "pictureBoxFotoPerfilPost";
            this.pictureBoxFotoPerfilPost.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxFotoPerfilPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFotoPerfilPost.TabIndex = 2;
            this.pictureBoxFotoPerfilPost.TabStop = false;
            // 
            // pictureBoxImagenPost
            // 
            this.pictureBoxImagenPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagenPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagenPost.Location = new System.Drawing.Point(100, 99);
            this.pictureBoxImagenPost.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImagenPost.Name = "pictureBoxImagenPost";
            this.pictureBoxImagenPost.Padding = new System.Windows.Forms.Padding(8);
            this.pictureBoxImagenPost.Size = new System.Drawing.Size(394, 129);
            this.pictureBoxImagenPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenPost.TabIndex = 1;
            this.pictureBoxImagenPost.TabStop = false;
            // 
            // txtContenidoPost
            // 
            this.txtContenidoPost.Location = new System.Drawing.Point(100, 24);
            this.txtContenidoPost.Margin = new System.Windows.Forms.Padding(2);
            this.txtContenidoPost.Name = "txtContenidoPost";
            this.txtContenidoPost.Size = new System.Drawing.Size(394, 71);
            this.txtContenidoPost.TabIndex = 0;
            this.txtContenidoPost.Text = "";
            // 
            // PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostCard";
            this.Size = new System.Drawing.Size(523, 326);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btnComentarios;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilPost;
        private System.Windows.Forms.PictureBox pictureBoxImagenPost;
        private System.Windows.Forms.RichTextBox txtContenidoPost;
        private System.Windows.Forms.Button btnLikePost;
        private System.Windows.Forms.Button btnCompartir;
        private MaterialSkin.Controls.MaterialLabel txtLikesPost;
    }
}
