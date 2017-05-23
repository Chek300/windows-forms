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
            /*
             * get the base image and the overlay image
             */



            Image baseImage = Image.FromFile(@"C:\Users\Brandt\Desktop\capimages\img6060.jpg");
            Bitmap overlayImage;
            var principalForm = Application.OpenForms.OfType<verticle_pos>().Single();
            
            foreach (var prop in baseImage.PropertyItems)
            {
                if (prop.Id == 0x0112) // value of EXIF
                {
                    int orientationValue = baseImage.GetPropertyItem(prop.Id).Value[0];
                    RotateFlipType rotateFlipType = principalForm.GetOrientationToFlipType(orientationValue);
                    baseImage.RotateFlip(rotateFlipType);
                    break;
                }
            }

            overlayImage = (Bitmap)Image.FromFile(@"C:\Users\Brandt\Desktop\6x8.png");

            var finalImage = new Bitmap(overlayImage.Width, overlayImage.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(finalImage);
            graphics.CompositingMode = CompositingMode.SourceOver;

            graphics.DrawImage((Bitmap)baseImage, 0, 0);
            graphics.DrawImage(overlayImage, 0, 0);

            //save the final composite image to disk
            finalImage.Save(@"C:\Users\Brandt\Desktop\capimages\composite.png", ImageFormat.Jpeg);
        }
    }
}
