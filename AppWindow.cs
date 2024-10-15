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
    public partial class AppWindow : MaterialForm
    {


        public AppWindow()
        {
            InitializeComponent();

            mainPage1.Show();  
            groupPage1.Hide(); 

            mainPage1.Dock = DockStyle.Fill;
            groupPage1.Dock = DockStyle.Fill;

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
        
        public void ShowGroupPage()
        {
            mainPage1.Hide();
            groupPage1.Show();
        }

        
        public void ShowMainPage()
        {
            mainPage1.Show();
            groupPage1.Hide();
        }

    }

}
