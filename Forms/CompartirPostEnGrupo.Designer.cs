
namespace CapaVisual
{
    partial class CompartirPostDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompartir = new MaterialSkin.Controls.MaterialButton();
            this.panelSeleccionarGrupo = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelSeleccionarGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCompartir);
            this.panel1.Controls.Add(this.panelSeleccionarGrupo);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 282);
            this.panel1.TabIndex = 1;
            // 
            // btnCompartir
            // 
            this.btnCompartir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompartir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompartir.Depth = 0;
            this.btnCompartir.HighEmphasis = true;
            this.btnCompartir.Icon = null;
            this.btnCompartir.Location = new System.Drawing.Point(83, 232);
            this.btnCompartir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompartir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompartir.Size = new System.Drawing.Size(104, 36);
            this.btnCompartir.TabIndex = 1;
            this.btnCompartir.Text = "Compartir";
            this.btnCompartir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompartir.UseAccentColor = false;
            this.btnCompartir.UseVisualStyleBackColor = true;
            // 
            // panelSeleccionarGrupo
            // 
            this.panelSeleccionarGrupo.BackColor = System.Drawing.Color.LightGray;
            this.panelSeleccionarGrupo.Controls.Add(this.dataGridView2);
            this.panelSeleccionarGrupo.Location = new System.Drawing.Point(22, 59);
            this.panelSeleccionarGrupo.Name = "panelSeleccionarGrupo";
            this.panelSeleccionarGrupo.Size = new System.Drawing.Size(235, 164);
            this.panelSeleccionarGrupo.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(235, 164);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick_1);
            // 
            // CompartirPostDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 287);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompartirPostDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSeleccionarGrupo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnCompartir;
        private System.Windows.Forms.Panel panelSeleccionarGrupo;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}