using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVisual.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;


namespace CapaVisual
{
    public partial class MainPage : MaterialForm
    {

        
        private string url_imagen;
        
        public MainPage()
        {
            InitializeComponent();

            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Red600,
                MaterialSkin.Primary.Red700,
                MaterialSkin.Primary.Red200,
                MaterialSkin.Accent.Green400,
                MaterialSkin.TextShade.BLACK
                );

        }

        private void pboxImagenVideo_DragEnter(object sender, DragEventArgs e)
        {

            
        }


        private void pboxImagenVideo_DragDrop(object sender, DragEventArgs e)
        {

            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }


        

        
        



        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

            
        }


        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {

            
        }

 
        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLinkCrearPost_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtLinkCrearPost_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtLinkCrearPost_Click(object sender, EventArgs e)
        {

        }

        private void comBoxSeleccionarGrupo_DropDown(object sender, EventArgs e)
        {
            
        }

        private void comBoxSeleccionarGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comBoxSeleccionarGrupo_Leave(object sender, EventArgs e)
        {
           
        }


        
        private void botonPostear_Click(object sender, EventArgs e)
        {
            
        }
    }

}
