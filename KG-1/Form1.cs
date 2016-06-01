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
using System.Windows.Forms.DataVisualization.Charting;

namespace KG_1
{
    public partial class Form1 : Form
    {
        int nemenyat = 3, h, w;
        int[,] rArr, bArr, gArr;
        TextBox[,] tbArray = new TextBox[15,15];
        double[,] digitArray = new double[15, 15];
        int[,] pixels = new int[4,256];

        public Form1()
        {
            InitializeComponent();
            w = ((Bitmap)pictureBox.Image).Width;
            h = ((Bitmap)pictureBox.Image).Height;
            rArr = new int[h, w]; gArr = new int[h, w]; bArr = new int[h, w];
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++)
                {
                    Color c = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                    rArr[i, j] = c.R; gArr[i, j] = c.G; bArr[i, j] = c.B;
                }
            loadInfo();
            buildPlot(chart1, 0);
            buildPlot(chart2, 1);
            buildPlot(chart3, 2);
            buildPlot(chart4, 3);
            generateArray();
        }

        private void hideAll() {
            for (int i = 0; i < 15; i++){
                for (int j = 0; j < 15; j++){
                    tbArray[i, j].Visible = false;
                }
            }
        }

        private void showArr(int count){
            for (int i = 0; i < count; i++){
                for (int j = 0; j < count; j++){
                    tbArray[i, j].Visible = true;
                }
            }
        }

        private void setttt(object sender, EventArgs e){
            int i = Convert.ToInt32(((TextBox)sender).Tag) / 15, j = Convert.ToInt32(((TextBox)sender).Tag) % 15;
            Double.TryParse(((TextBox)sender).Text, out digitArray[i, j]);
            ((TextBox)sender).Text = digitArray[i, j].ToString();
        }

        private void generateArray() {
            for(int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    tbArray[i, j] = new TextBox();
                    tbArray[i, j].Parent = groupBox2;
                    tbArray[i, j].Top = i * 30 + 20;
                    tbArray[i, j].Left = j * 40 + 20;
                    tbArray[i, j].Width = 30;
                    tbArray[i, j].Height = 20;
                    tbArray[i, j].Leave += setttt;
                    tbArray[i, j].Tag = (i * 15 + j).ToString();
                    tbArray[i, j].Text = "0";
                    tbArray[i, j].Font = new Font("EpsilonCTT", 11);
                }
            }
            hideAll();
            showArr(3);
        }

        private int normalize(int val) {
            int l = (int)numericUpDown1.Value;   
            int r = (int)numericUpDown2.Value;
            return val > r ? 255 : val < l ? 0 : (int)((val - l) * 255 / (r - l));
        }

        private void loadInfo() {
            pixels = new int[4, 256];
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++){
                    int R = normalize(rArr[i, j]), G = normalize(gArr[i, j]), B = normalize(bArr[i, j]);
                    pixels[0, G]++; pixels[1, R]++; pixels[2, B]++;
                    pixels[3, (int)((R + G + B) / 3)]++;
                    ((Bitmap)pictureBox.Image).SetPixel(j, i, Color.FromArgb(0, R, G, B));
                }
            pictureBox.Invalidate();
        }

        private void buildPlot(object sender, int i) {
            ((Chart)sender).Series[0].Points.Clear();
            ((Chart)sender).ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int y = 1; y < 255; y++)
            {

                ((Chart)sender).Series[0].Points.AddY(pixels[i, y]);
                if (y % 10 == 0) ((Chart)sender).ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(y, y + 10, y.ToString(), 0, LabelMarkStyle.LineSideMark));
                else ((Chart)sender).ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(y, y, "", 0, LabelMarkStyle.LineSideMark));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.OpenFile() != null)
                    {
                        pictureBox.Load(openFileDialog.FileName);
                        pictureBox.Width = (int)(pictureBox.Height * ((Double)(((Bitmap)pictureBox.Image).Width) / (Double)(((Bitmap)pictureBox.Image).Height)));
                        w = ((Bitmap)pictureBox.Image).Width;
                        h = ((Bitmap)pictureBox.Image).Height;
                        rArr = new int[h, w]; gArr = new int[h, w]; bArr = new int[h, w];
                        for (int i = 0; i < h; i++)
                            for (int j = 0; j < w; j++) { 
                                Color c = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                                rArr[i, j] = c.R; gArr[i, j] = c.G; bArr[i, j] = c.B;
                            }
                        numericUpDown1.Value = 0; numericUpDown2.Value = 255;
                        BuildGraph_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BuildGraph_Click(object sender, EventArgs e)
        {
            loadInfo();
            buildPlot(chart1, 0);
            buildPlot(chart2, 1);
            buildPlot(chart3, 2);
            buildPlot(chart4, 3);
        }

        private void цветокорекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value <= numericUpDown1.Value) numericUpDown2.Value = numericUpDown1.Value + 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value <= numericUpDown1.Value) numericUpDown1.Value = numericUpDown2.Value - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideAll();
            nemenyat = (int)((NumericUpDown)numericUpDown3).Value;
            showArr(nemenyat);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown3.Value % 2 == 0) numericUpDown3.Value = (int)numericUpDown3.Value + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            //(float)Convert.ToDouble(textBox1.Text)0.84089642
            double sigma = 0.84089642;
            double coeff = 1.0f / (2.0f * Math.PI * sigma * sigma);
            for (int i = 0; i < nemenyat; i++)
            {
                for (int j = 0; j < nemenyat; j++)
                {
                    digitArray[i, j] = coeff * Math.Exp(-(Math.Pow(i - nemenyat / 2, 2) + Math.Pow(j - nemenyat / 2, 2)) / (2.0 * sigma * sigma));
                    tbArray[i, j].Text =  digitArray[i, j].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++) {
                    double resR = 0, resG = 0, resB = 0;
                    for (int k = i - nemenyat / 2; k < i + nemenyat / 2 + 1; k++)
                        for (int o = j - nemenyat / 2; o < j + nemenyat / 2 + 1; o++) {
                            resR += rArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + nemenyat / 2, j - o + nemenyat / 2];
                            resG += gArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + nemenyat / 2, j - o + nemenyat / 2];
                            resB += bArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + nemenyat / 2, j - o + nemenyat / 2];
                        }
                    progressBar1.Value = (int)((i + 1.0) / h * 100);
                    ((Bitmap)pictureBox.Image).SetPixel(j, i, Color.FromArgb(0, Math.Max(0, Math.Min((int)resR, 255)), Math.Max(0, Math.Min((int)resG, 255)), Math.Max(0, Math.Min((int)resB, 255))));
                }
            pictureBox.Invalidate();
            progressBar1.Value = 0;
        }
    }
}
