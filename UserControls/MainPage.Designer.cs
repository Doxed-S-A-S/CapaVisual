
namespace CapaVisual
{
    partial class mainPage1
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
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.divisorDerecho = new MaterialSkin.Controls.MaterialDivider();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutCrearPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.crearPost1 = new CapaVisual.CrearPost();
            this.flowLayoutCrearPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.Silver;
            this.panelDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDerecho.Location = new System.Drawing.Point(1456, 2);
            this.panelDerecho.Margin = new System.Windows.Forms.Padding(2);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(214, 996);
            this.panelDerecho.TabIndex = 10;
            // 
            // divisorDerecho
            // 
            this.divisorDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divisorDerecho.Depth = 0;
            this.divisorDerecho.Location = new System.Drawing.Point(2, 0);
            this.divisorDerecho.Margin = new System.Windows.Forms.Padding(2);
            this.divisorDerecho.MouseState = MaterialSkin.MouseState.HOVER;
            this.divisorDerecho.Name = "divisorDerecho";
            this.divisorDerecho.Size = new System.Drawing.Size(10, 982);
            this.divisorDerecho.TabIndex = 7;
            this.divisorDerecho.Text = "materialDivider1";
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPosts.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(16, 220);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Padding = new System.Windows.Forms.Padding(230, 0, 100, 0);
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(1436, 778);
            this.flowLayoutPanelPosts.TabIndex = 8;
            // 
            // flowLayoutCrearPosts
            // 
            this.flowLayoutCrearPosts.AutoSize = true;
            this.flowLayoutCrearPosts.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutCrearPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutCrearPosts.Controls.Add(this.crearPost1);
            this.flowLayoutCrearPosts.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutCrearPosts.Location = new System.Drawing.Point(16, 2);
            this.flowLayoutCrearPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutCrearPosts.Name = "flowLayoutCrearPosts";
            this.flowLayoutCrearPosts.Padding = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.flowLayoutCrearPosts.Size = new System.Drawing.Size(1436, 214);
            this.flowLayoutCrearPosts.TabIndex = 9;
            this.flowLayoutCrearPosts.WrapContents = false;
            // 
            // crearPost1
            // 
            this.crearPost1.Location = new System.Drawing.Point(232, 2);
            this.crearPost1.Margin = new System.Windows.Forms.Padding(2);
            this.crearPost1.Name = "crearPost1";
            this.crearPost1.Size = new System.Drawing.Size(584, 202);
            this.crearPost1.TabIndex = 1;
            // 
            // mainPage1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.flowLayoutCrearPosts);
            this.Controls.Add(this.divisorDerecho);
            this.Controls.Add(this.flowLayoutPanelPosts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainPage1";
            this.Size = new System.Drawing.Size(1672, 1009);
            this.flowLayoutCrearPosts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDerecho;
        private MaterialSkin.Controls.MaterialDivider divisorDerecho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCrearPosts;
        private CrearPost crearPost1;
    }
}
