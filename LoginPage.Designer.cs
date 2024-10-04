
namespace CapaVisual
{
    partial class LoginPage
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtPassword);
            this.materialCard1.Controls.Add(this.txtEmail);
            this.materialCard1.Controls.Add(this.btnRegistrarse);
            this.materialCard1.Controls.Add(this.btnInicio);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(484, 320);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(502, 317);
            this.materialCard1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(62, 112);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(388, 50);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(62, 56);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 50);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.CursorChanged += new System.EventHandler(this.txtEmail_KeyUp);
            this.txtEmail.MouseEnter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarse.Depth = 0;
            this.btnRegistrarse.HighEmphasis = true;
            this.btnRegistrarse.Icon = null;
            this.btnRegistrarse.Location = new System.Drawing.Point(192, 252);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarse.Size = new System.Drawing.Size(116, 36);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarse.UseAccentColor = false;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInicio.Depth = 0;
            this.btnInicio.HighEmphasis = true;
            this.btnInicio.Icon = null;
            this.btnInicio.Location = new System.Drawing.Point(212, 204);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInicio.Size = new System.Drawing.Size(73, 36);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInicio.UseAccentColor = false;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(613, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 164);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 776);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCard1);
            this.Name = "LoginPage";
            this.Text = "LinguaLink";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private MaterialSkin.Controls.MaterialButton btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
    }
}