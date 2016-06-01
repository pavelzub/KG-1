namespace KG_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea31 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend31 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea32 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend32 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BuildGraph = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветокорекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 360);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "q.jpg";
            this.openFileDialog.Filter = "image (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "\"D:\\Users\\zubarev_ps\\Desktop\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("EpsilonCTT", 38F);
            this.button1.Location = new System.Drawing.Point(53, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(536, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea29.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea29);
            this.chart1.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend29.Enabled = false;
            legend29.Name = "Legend1";
            this.chart1.Legends.Add(legend29);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series29.Legend = "Legend1";
            series29.Name = "Series1";
            this.chart1.Series.Add(series29);
            this.chart1.Size = new System.Drawing.Size(361, 170);
            this.chart1.TabIndex = 3;
            // 
            // BuildGraph
            // 
            this.BuildGraph.Font = new System.Drawing.Font("EpsilonCTT", 20F);
            this.BuildGraph.Location = new System.Drawing.Point(241, 389);
            this.BuildGraph.Name = "BuildGraph";
            this.BuildGraph.Size = new System.Drawing.Size(263, 49);
            this.BuildGraph.TabIndex = 4;
            this.BuildGraph.Text = "Постоить графики";
            this.BuildGraph.UseVisualStyleBackColor = true;
            this.BuildGraph.Click += new System.EventHandler(this.BuildGraph_Click);
            // 
            // chart2
            // 
            chartArea30.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea30);
            this.chart2.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend30.Enabled = false;
            legend30.Name = "Legend1";
            this.chart2.Legends.Add(legend30);
            this.chart2.Location = new System.Drawing.Point(398, 19);
            this.chart2.Name = "chart2";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series30.Legend = "Legend1";
            series30.Name = "Series1";
            this.chart2.Series.Add(series30);
            this.chart2.Size = new System.Drawing.Size(361, 170);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea31.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea31);
            this.chart3.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend31.Enabled = false;
            legend31.Name = "Legend1";
            this.chart3.Legends.Add(legend31);
            this.chart3.Location = new System.Drawing.Point(6, 204);
            this.chart3.Name = "chart3";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series31.Legend = "Legend1";
            series31.Name = "Series1";
            this.chart3.Series.Add(series31);
            this.chart3.Size = new System.Drawing.Size(361, 170);
            this.chart3.TabIndex = 6;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea32.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea32);
            this.chart4.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend32.Enabled = false;
            legend32.Name = "Legend1";
            this.chart4.Legends.Add(legend32);
            this.chart4.Location = new System.Drawing.Point(398, 204);
            this.chart4.Name = "chart4";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series32.Legend = "Legend1";
            series32.Name = "Series1";
            this.chart4.Series.Add(series32);
            this.chart4.Size = new System.Drawing.Size(361, 170);
            this.chart4.TabIndex = 7;
            this.chart4.Text = "chart4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.BuildGraph);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.chart3);
            this.groupBox1.Controls.Add(this.chart4);
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Location = new System.Drawing.Point(675, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 488);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("EpsilonCTT", 11F);
            this.numericUpDown2.Location = new System.Drawing.Point(510, 389);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("EpsilonCTT", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(174, 389);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1452, 25);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветокорекцияToolStripMenuItem,
            this.размытиеToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("EpsilonCTT", 9F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // цветокорекцияToolStripMenuItem
            // 
            this.цветокорекцияToolStripMenuItem.Name = "цветокорекцияToolStripMenuItem";
            this.цветокорекцияToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.цветокорекцияToolStripMenuItem.Text = "Цветокорекция";
            this.цветокорекцияToolStripMenuItem.Click += new System.EventHandler(this.цветокорекцияToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(675, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 488);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("EpsilonCTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(685, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Гаусс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("EpsilonCTT", 11F);
            this.numericUpDown3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(685, 19);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 28);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("EpsilonCTT", 18F);
            this.button3.Location = new System.Drawing.Point(685, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ядро";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("EpsilonCTT", 18F);
            this.button2.Location = new System.Drawing.Point(651, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Размыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(752, 10);
            this.progressBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "KG-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BuildGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветокорекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

