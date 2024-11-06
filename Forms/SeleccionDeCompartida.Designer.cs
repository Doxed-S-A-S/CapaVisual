﻿
namespace CapaVisual
{
    partial class SeleccionDeCompartida
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompartirGrupo = new MaterialSkin.Controls.MaterialButton();
            this.btnCompartirMuro = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(83, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Compartir en:";
            // 
            // btnCompartirGrupo
            // 
            this.btnCompartirGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompartirGrupo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompartirGrupo.Depth = 0;
            this.btnCompartirGrupo.HighEmphasis = true;
            this.btnCompartirGrupo.Icon = null;
            this.btnCompartirGrupo.Location = new System.Drawing.Point(163, 77);
            this.btnCompartirGrupo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompartirGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompartirGrupo.Name = "btnCompartirGrupo";
            this.btnCompartirGrupo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompartirGrupo.Size = new System.Drawing.Size(70, 36);
            this.btnCompartirGrupo.TabIndex = 5;
            this.btnCompartirGrupo.Text = "Grupo";
            this.btnCompartirGrupo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompartirGrupo.UseAccentColor = false;
            this.btnCompartirGrupo.UseVisualStyleBackColor = true;
            this.btnCompartirGrupo.Click += new System.EventHandler(this.btnCompartirGrupo_Click_1);
            // 
            // btnCompartirMuro
            // 
            this.btnCompartirMuro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompartirMuro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompartirMuro.Depth = 0;
            this.btnCompartirMuro.HighEmphasis = true;
            this.btnCompartirMuro.Icon = null;
            this.btnCompartirMuro.Location = new System.Drawing.Point(35, 77);
            this.btnCompartirMuro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompartirMuro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompartirMuro.Name = "btnCompartirMuro";
            this.btnCompartirMuro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompartirMuro.Size = new System.Drawing.Size(64, 36);
            this.btnCompartirMuro.TabIndex = 4;
            this.btnCompartirMuro.Text = "Muro";
            this.btnCompartirMuro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompartirMuro.UseAccentColor = false;
            this.btnCompartirMuro.UseVisualStyleBackColor = true;
            this.btnCompartirMuro.Click += new System.EventHandler(this.btnCompartirMuro_Click_1);
            // 
            // SeleccionDeCompartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 145);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCompartirGrupo);
            this.Controls.Add(this.btnCompartirMuro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SeleccionDeCompartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCompartirGrupo;
        private MaterialSkin.Controls.MaterialButton btnCompartirMuro;
    }
}