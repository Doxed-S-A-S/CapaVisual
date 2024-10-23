
namespace CapaVisual
{
    partial class CompartirEnGrupoDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeleccionarGrupo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSeleccionarGrupo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 253);
            this.panel1.TabIndex = 0;
            // 
            // panelSeleccionarGrupo
            // 
            this.panelSeleccionarGrupo.BackColor = System.Drawing.Color.LightGray;
            this.panelSeleccionarGrupo.Location = new System.Drawing.Point(22, 59);
            this.panelSeleccionarGrupo.Name = "panelSeleccionarGrupo";
            this.panelSeleccionarGrupo.Size = new System.Drawing.Size(235, 173);
            this.panelSeleccionarGrupo.TabIndex = 0;
            // 
            // CompartirEnGrupoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CompartirEnGrupoDialog";
            this.Size = new System.Drawing.Size(279, 253);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeleccionarGrupo;
    }
}
