using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    class pboxCircular
    {
        public void MakeCircularPictureBox(PictureBox pictureBox2)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(path);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
