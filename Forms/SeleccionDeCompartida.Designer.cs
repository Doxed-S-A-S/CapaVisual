
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
            this.dondeCompartir1 = new CapaVisual.UserControls.DondeCompartir();
            this.SuspendLayout();
            // 
            // dondeCompartir1
            // 
            this.dondeCompartir1.Location = new System.Drawing.Point(2, 65);
            this.dondeCompartir1.Name = "dondeCompartir1";
            this.dondeCompartir1.Size = new System.Drawing.Size(311, 156);
            this.dondeCompartir1.TabIndex = 0;
            // 
            // SeleccionDeCompartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 231);
            this.Controls.Add(this.dondeCompartir1);
            this.Name = "SeleccionDeCompartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DondeCompartir dondeCompartir1;
    }
}