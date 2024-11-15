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
    class richTxtBoxCircularcs
    {
        public void MakeCircularRichTextBox(RichTextBox richTextBox, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(richTextBox.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(richTextBox.Width - cornerRadius, richTextBox.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(0, richTextBox.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            richTextBox.Region = new Region(path);
        }
    }
}
