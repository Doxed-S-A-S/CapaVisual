
namespace CapaVisual
{
    partial class AppWindow
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
            this.txtBarraBusqueda = new System.Windows.Forms.TextBox();
            this.groupPage1 = new CapaVisual.GroupPage();
            this.mainPage1 = new CapaVisual.mainPage1();
            this.SuspendLayout();
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarraBusqueda.Location = new System.Drawing.Point(428, 33);
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(459, 20);
            this.txtBarraBusqueda.TabIndex = 7;
            // 
            // groupPage1
            // 
            this.groupPage1.Location = new System.Drawing.Point(0, 62);
            this.groupPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPage1.Name = "groupPage1";
            this.groupPage1.Size = new System.Drawing.Size(1493, 752);
            this.groupPage1.TabIndex = 9;
            // 
            // mainPage1
            // 
            this.mainPage1.Location = new System.Drawing.Point(5, 66);
            this.mainPage1.Margin = new System.Windows.Forms.Padding(2);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1120, 611);
            this.mainPage1.TabIndex = 10;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1499, 815);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.groupPage1);
            this.Controls.Add(this.txtBarraBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.Name = "AppWindow";
            this.Text = "LinguaLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarraBusqueda;
        private GroupPage groupPage1;
        private mainPage1 mainPage1;
    }
}

