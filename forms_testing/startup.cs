using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace forms_testing
{

    public partial class startup : Form
    {
        
        public static string defaultOverlay;
        public static string images;
        public static string imagePathTxt = @"C:\Users\Brandt\Documents\Visual Studio 2017\Projects\forms_testing\forms_testing\imagePath.txt";
        public static string defaultOverlayTxt = @"C:\Users\Brandt\Documents\Visual Studio 2017\Projects\forms_testing\forms_testing\defaultOverlay.txt";
        public startup()
        {
            InitializeComponent();
            testConfig();
        }

        private void showConfig()
        {
            config frm = new config();
            frm.Show();
        }
        private void testConfig()
            //test to see if config files are set up
        {
            if(File.Exists(imagePathTxt) && File.Exists(defaultOverlayTxt))
            {
                using (StreamReader sr = new StreamReader(imagePathTxt))
                {
                    if (sr.ReadLine() != null)
                    {
                        images = sr.ReadLine();
                    }
                    else
                    {
                        showConfig();
                    } 
                }
                using (StreamReader sr = new StreamReader(defaultOverlayTxt))
                {
                    if (sr.ReadLine() != null)
                    {
                        defaultOverlay = sr.ReadLine();
                    }
                    else
                    {
                        showConfig();
                    }
                }
            }
            else
            {
                //Files not found open up the config
                showConfig();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verticle_pos frm = new verticle_pos();
            frm.Show();
        }
    }
}
