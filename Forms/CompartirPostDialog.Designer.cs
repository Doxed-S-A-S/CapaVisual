
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
            this.compartirEnGrupoDialog1 = new CapaVisual.CompartirEnGrupoDialog();
            this.compartirEnGrupoDialog2 = new CapaVisual.CompartirEnGrupoDialog();
            this.SuspendLayout();
            // 
            // compartirEnGrupoDialog1
            // 
            this.compartirEnGrupoDialog1.Location = new System.Drawing.Point(1, 0);
            this.compartirEnGrupoDialog1.Name = "compartirEnGrupoDialog1";
            this.compartirEnGrupoDialog1.Size = new System.Drawing.Size(279, 285);
            this.compartirEnGrupoDialog1.TabIndex = 0;
            // 
            // compartirEnGrupoDialog2
            // 
            this.compartirEnGrupoDialog2.Location = new System.Drawing.Point(13, 67);
            this.compartirEnGrupoDialog2.Name = "compartirEnGrupoDialog2";
            this.compartirEnGrupoDialog2.Size = new System.Drawing.Size(281, 343);
            this.compartirEnGrupoDialog2.TabIndex = 0;
            // 
            // CompartirPostDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 416);
            this.Controls.Add(this.compartirEnGrupoDialog2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompartirPostDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CompartirEnGrupoDialog compartirEnGrupoDialog1;
        private CompartirEnGrupoDialog compartirEnGrupoDialog2;
    }
}