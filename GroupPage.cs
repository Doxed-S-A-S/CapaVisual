using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class GroupPage : UserControl
    {
        public GroupPage()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent as AppWindow;
            if (parentForm != null)
            {
                parentForm.ShowMainPage(); // Call the method on the form to switch
            }

        }
    }
}
