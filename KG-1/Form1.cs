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
        int CoreSize = 3, h, w;
        int[,] rArr, bArr, gArr;
        TextBox[,] tbArray = new TextBox[15,15];
        double[,] digitArray = new double[15, 15];
        int[,] pixels = new int[4,256];
        Chart[] charts;
        GroupBox[] Boxs;

        public Form1(){
            InitializeComponent();
            charts = new Chart[4] { RedChart, GreenChart, BlueChart, AverageChart };
            Boxs = new GroupBox[3] {groupBox1, groupBox2, groupBox3};
            LoadImage(@"..\..\image\test.jpg");
            generateArray();
        }

        void LoadImage(string Name) {
            pictureBox.Load(Name);
            pictureBox.Width = (int)(pictureBox.Height * ((Double)(((Bitmap)pictureBox.Image).Width) / (Double)(((Bitmap)pictureBox.Image).Height)));
            w = ((Bitmap)pictureBox.Image).Width; h = ((Bitmap)pictureBox.Image).Height;
            rArr = new int[h, w]; gArr = new int[h, w]; bArr = new int[h, w];

            RefreshImageInfo();
            loadInfo();
            BuildPlots(charts);
        }

        void RefreshImageInfo() {
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++){
                    Color c = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                    rArr[i, j] = c.R; gArr[i, j] = c.G; bArr[i, j] = c.B;
                }
            BottomLine.Value = 0; TopLine.Value = 255;
        }

        private void BuildPlots(Chart[] charts) {
            foreach (Chart chart in charts) {
                chart.Series[0].Points.Clear();
                chart.ChartAreas[0].AxisX.CustomLabels.Clear();
                for (int y = 1; y < 255; y++){
                    chart.Series[0].Points.AddY(pixels[Convert.ToInt32(chart.Tag), y]);
                    if (y % 10 == 0) chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(y, y + 10, y.ToString(), 0, LabelMarkStyle.LineSideMark));
                    else chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(y, y, "", 0, LabelMarkStyle.LineSideMark));
                }
            }
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
            int l = (int)BottomLine.Value;   
            int r = (int)TopLine.Value;
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

        private void BtnLoadImageClick(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    if (openFileDialog.OpenFile() != null) {
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
                        BottomLine.Value = 0; TopLine.Value = 255;
                        BuildGraph_Click(sender, e);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void BuildGraph_Click(object sender, EventArgs e){
            loadInfo();
            BuildPlots(charts);
        }

        private void MenuItem_Click(object sender, EventArgs e){
            foreach (GroupBox box in Boxs) 
                if (((ToolStripMenuItem)sender).Tag == box.Tag) {
                    box.Visible = true;}
                    else box.Visible = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (TopLine.Value <= BottomLine.Value) TopLine.Value = BottomLine.Value + 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (TopLine.Value <= BottomLine.Value) BottomLine.Value = TopLine.Value - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideAll();
            CoreSize = (int)((NumericUpDown)KernleSizeControl).Value;
            showArr(CoreSize);
        }

        private void BtnGetBorder_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((int)KernleSizeControl.Value % 2 == 0) KernleSizeControl.Value = (int)KernleSizeControl.Value + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            //0.84089642
            double sum = 0, sigma = (double)GammaContorl.Value / 100.0;
            double coeff = 1.0f / (2.0f * Math.PI * sigma * sigma);
            for (int i = 0; i < CoreSize; i++)
                for (int j = 0; j < CoreSize; j++) {
                    digitArray[i, j] = coeff * Math.Exp(-(Math.Pow(i - CoreSize / 2, 2) + Math.Pow(j - CoreSize / 2, 2)) / (2.0 * sigma * sigma));
                    sum += digitArray[i, j];
                }
            for (int i = 0; i < CoreSize; i++)
                for (int j = 0; j < CoreSize; j++) {
                    digitArray[i, j] /= sum;
                    tbArray[i, j].Text = digitArray[i, j].ToString();
                }
            
        }

        Color ColorFromAgb(double r, double g, double b){
            int rr = Math.Max(Math.Min((int)r, 255), 0);
            int gg = Math.Max(Math.Min((int)g, 255), 0);
            int bb = Math.Max(Math.Min((int)b, 255), 0);
            return Color.FromArgb(0, rr, gg, bb);
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++) {
                    double resR = 0, resG = 0, resB = 0;
                    for (int k = i - CoreSize / 2; k < i + CoreSize / 2 + 1; k++)
                        for (int o = j - CoreSize / 2; o < j + CoreSize / 2 + 1; o++) {
                            resR += rArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + CoreSize / 2, j - o + CoreSize / 2];
                            resG += gArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + CoreSize / 2, j - o + CoreSize / 2];
                            resB += bArr[k < 0 ? 0 : k >= h - 1 ? h - 1 : k, o < 0 ? 0 : o >= w - 1 ? w - 1 : o] * digitArray[i - k + CoreSize / 2, j - o + CoreSize / 2];
                        }
                    ((Bitmap)pictureBox.Image).SetPixel(j, i, ColorFromAgb(resR, resG, resB));
                    progressBar1.Value = (int)((i + 1.0) / h * 100);
                }
            pictureBox.Invalidate();
            progressBar1.Value = 0;
        }
    }
}
