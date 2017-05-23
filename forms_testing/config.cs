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
using System.Diagnostics;

namespace forms_testing
{

    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        private void writeConfig(string file, string text)
        {
            using (StreamWriter writeText = new StreamWriter(file))
            {
                writeText.WriteLine(text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                startup.images = path;
                writeConfig(startup.imagePathTxt, path);
                //write the image path to the first line in the config file
                Debug.WriteLine("Files found: " + Directory.GetFiles(folderBrowserDialog1.SelectedPath).Length.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                startup.defaultOverlay = openFileDialog1.FileName;
                writeConfig(startup.defaultOverlayTxt, openFileDialog1.FileName);
                //write the default overlay to the second line in the config file
            }
        }
    }
}
