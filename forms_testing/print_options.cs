using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace forms_testing
{
    public partial class print_options : Form
    {
        public print_options()
        {
            InitializeComponent();
        }

        private void printLocation_Click(object sender, EventArgs e)
        {
            Bitmap baseImage;
            Bitmap overlayImage;

            baseImage = (Bitmap)Image.FromFile(@"C:\Users\Brandt\Desktop\img6060.jpg");

            overlayImage = (Bitmap)Image.FromFile(@"C:\Users\Brandt\Desktop\6x8.png");

            var finalImage = new Bitmap(overlayImage.Width, overlayImage.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(finalImage);
            graphics.CompositingMode = CompositingMode.SourceOver;

            graphics.DrawImage(baseImage, 0, 0);
            graphics.DrawImage(overlayImage, 0, 0);

            //save the final composite image to disk
            finalImage.Save(@"C:\Users\Brandt\Desktop\composite.png", ImageFormat.Jpeg);
        }
    }
}
