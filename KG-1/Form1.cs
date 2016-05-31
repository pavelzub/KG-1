using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bildPlot() {
            for (int i = 0; i < ((Bitmap)pictureBox.Image).Height; i++)
                for (int j = 0; j < ((Bitmap)pictureBox.Image).Width; j++) {
                    Color pixel = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadImage()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.OpenFile() != null)
                    {
                        pictureBox.ImageLocation = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            pictureBox.Width = (int)(pictureBox.Height * ((Double)(((Bitmap)pictureBox.Image).Width) / (Double)(((Bitmap)pictureBox.Image).Height)));
            bildPlot();
        }
    }
}
