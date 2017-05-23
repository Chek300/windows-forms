using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace forms_testing
{ 
    public partial class verticle_pos : Form
    {

        public string[] images = Directory.GetFiles(startup.images);
        public int cursor = 0;

        private static RotateFlipType GetOrientationToFlipType(int orientationValue)
        {
            RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;

            switch (orientationValue)
            {
                case 1:
                    rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                    break;
                case 2:
                    rotateFlipType = RotateFlipType.RotateNoneFlipX;
                    break;
                case 3:
                    rotateFlipType = RotateFlipType.Rotate180FlipNone;
                    break;
                case 4:
                    rotateFlipType = RotateFlipType.Rotate180FlipX;
                    break;
                case 5:
                    rotateFlipType = RotateFlipType.Rotate90FlipX;
                    break;
                case 6:
                    rotateFlipType = RotateFlipType.Rotate90FlipNone;
                    break;
                case 7:
                    rotateFlipType = RotateFlipType.Rotate270FlipX;
                    break;
                case 8:
                    rotateFlipType = RotateFlipType.Rotate270FlipNone;
                    break;
                default:
                    rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                    break;
            }

            return rotateFlipType;
        }


        public static bool fullScreen = false;
        public class DoubleClickPicture : PictureBox
        {
            public DoubleClickPicture()
            {
                SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            }
        }
        public void loadImage(int pointer)
        {
            Image img = Image.FromFile(images[pointer]);
            foreach (var prop in img.PropertyItems)
            {
                if (prop.Id == 0x0112) // value of EXIF
                {
                    int orientationValue = img.GetPropertyItem(prop.Id).Value[0];
                    RotateFlipType rotateFlipType = GetOrientationToFlipType(orientationValue);
                    img.RotateFlip(rotateFlipType);
                    break;
                }
            }
            pictureBox1.BackgroundImage = img;
            
        }

        public verticle_pos()
        {
            InitializeComponent();
            pictureBox1.DoubleClick += new EventHandler(pictureBox1_DoubleClick);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Load(startup.defaultOverlay);
            loadImage(0);
        }
       

        private void printOptions_Click(object sender, EventArgs e)
        {
            print_options frm = new print_options();
            frm.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (!fullScreen)
            {
                //toggle full screen on image
                // hide buttons
                leftBtn.Visible = false;
                rightBtn.Visible = false;
                printOptions.Visible = false;
                keyBoard.Visible = false;
                pictureBox1.Dock = DockStyle.Fill;
                fullScreen = true;
            }
            else
            {
                //revert back to normal
                //show buttons
                leftBtn.Visible = true;
                rightBtn.Visible = true;
                printOptions.Visible = true;
                keyBoard.Visible = true;
                pictureBox1.Dock = DockStyle.None;
                fullScreen = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (cursor > 0)
            {
                cursor--;
                loadImage(cursor);
            }
            
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if (cursor < images.Length - 1)
            {
                cursor++;
                loadImage(cursor);
            }
        }
    }
}
