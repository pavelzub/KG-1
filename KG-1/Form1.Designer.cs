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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnLoadimage = new System.Windows.Forms.Button();
            this.RedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnColorcorect = new System.Windows.Forms.Button();
            this.GreenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BlueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TopLine = new System.Windows.Forms.NumericUpDown();
            this.BottomLine = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветокорекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделеинеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnGauskernel = new System.Windows.Forms.Button();
            this.KernleSizeControl = new System.Windows.Forms.NumericUpDown();
            this.BtnKernel = new System.Windows.Forms.Button();
            this.Btnblur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.BtnGetBorder = new System.Windows.Forms.Button();
            this.GammaContorl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLine)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KernleSizeControl)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaContorl)).BeginInit();
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
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "q.jpg";
            this.openFileDialog.Filter = "image (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "\"D:\\Users\\zubarev_ps\\Desktop\"";
            // 
            // BtnLoadimage
            // 
            this.BtnLoadimage.Font = new System.Drawing.Font("EpsilonCTT", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLoadimage.Location = new System.Drawing.Point(53, 427);
            this.BtnLoadimage.Name = "BtnLoadimage";
            this.BtnLoadimage.Size = new System.Drawing.Size(536, 72);
            this.BtnLoadimage.TabIndex = 2;
            this.BtnLoadimage.Text = "Загрузить изображение";
            this.BtnLoadimage.UseVisualStyleBackColor = true;
            this.BtnLoadimage.Click += new System.EventHandler(this.BtnLoadImageClick);
            // 
            // RedChart
            // 
            chartArea5.Name = "ChartArea1";
            this.RedChart.ChartAreas.Add(chartArea5);
            this.RedChart.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.RedChart.Legends.Add(legend5);
            this.RedChart.Location = new System.Drawing.Point(6, 19);
            this.RedChart.Name = "RedChart";
            this.RedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.White;
            series5.Name = "Series1";
            this.RedChart.Series.Add(series5);
            this.RedChart.Size = new System.Drawing.Size(361, 170);
            this.RedChart.TabIndex = 3;
            this.RedChart.Tag = "0";
            // 
            // BtnColorcorect
            // 
            this.BtnColorcorect.Font = new System.Drawing.Font("EpsilonCTT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnColorcorect.Location = new System.Drawing.Point(241, 389);
            this.BtnColorcorect.Name = "BtnColorcorect";
            this.BtnColorcorect.Size = new System.Drawing.Size(263, 49);
            this.BtnColorcorect.TabIndex = 4;
            this.BtnColorcorect.Text = "Цветокоректкнуть";
            this.BtnColorcorect.UseVisualStyleBackColor = true;
            this.BtnColorcorect.Click += new System.EventHandler(this.BuildGraph_Click);
            // 
            // GreenChart
            // 
            chartArea6.Name = "ChartArea1";
            this.GreenChart.ChartAreas.Add(chartArea6);
            this.GreenChart.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.GreenChart.Legends.Add(legend6);
            this.GreenChart.Location = new System.Drawing.Point(398, 19);
            this.GreenChart.Name = "GreenChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Color = System.Drawing.Color.Lime;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.GreenChart.Series.Add(series6);
            this.GreenChart.Size = new System.Drawing.Size(361, 170);
            this.GreenChart.TabIndex = 5;
            this.GreenChart.Tag = "1";
            this.GreenChart.Text = "chart2";
            // 
            // BlueChart
            // 
            chartArea7.Name = "ChartArea1";
            this.BlueChart.ChartAreas.Add(chartArea7);
            this.BlueChart.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.BlueChart.Legends.Add(legend7);
            this.BlueChart.Location = new System.Drawing.Point(6, 204);
            this.BlueChart.Name = "BlueChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.BlueChart.Series.Add(series7);
            this.BlueChart.Size = new System.Drawing.Size(361, 170);
            this.BlueChart.TabIndex = 6;
            this.BlueChart.Tag = "2";
            this.BlueChart.Text = "chart3";
            // 
            // AverageChart
            // 
            chartArea8.Name = "ChartArea1";
            this.AverageChart.ChartAreas.Add(chartArea8);
            this.AverageChart.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.AverageChart.Legends.Add(legend8);
            this.AverageChart.Location = new System.Drawing.Point(398, 204);
            this.AverageChart.Name = "AverageChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.Color = System.Drawing.Color.Gray;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.AverageChart.Series.Add(series8);
            this.AverageChart.Size = new System.Drawing.Size(361, 170);
            this.AverageChart.TabIndex = 7;
            this.AverageChart.Tag = "3";
            this.AverageChart.Text = "chart4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TopLine);
            this.groupBox1.Controls.Add(this.BottomLine);
            this.groupBox1.Controls.Add(this.BtnColorcorect);
            this.groupBox1.Controls.Add(this.RedChart);
            this.groupBox1.Controls.Add(this.BlueChart);
            this.groupBox1.Controls.Add(this.AverageChart);
            this.groupBox1.Controls.Add(this.GreenChart);
            this.groupBox1.Location = new System.Drawing.Point(675, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 488);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "0";
            // 
            // TopLine
            // 
            this.TopLine.Font = new System.Drawing.Font("EpsilonCTT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLine.Location = new System.Drawing.Point(510, 389);
            this.TopLine.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TopLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TopLine.Name = "TopLine";
            this.TopLine.Size = new System.Drawing.Size(61, 29);
            this.TopLine.TabIndex = 11;
            this.TopLine.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TopLine.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // BottomLine
            // 
            this.BottomLine.Font = new System.Drawing.Font("EpsilonCTT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomLine.Location = new System.Drawing.Point(174, 389);
            this.BottomLine.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.BottomLine.Name = "BottomLine";
            this.BottomLine.Size = new System.Drawing.Size(61, 29);
            this.BottomLine.TabIndex = 10;
            this.BottomLine.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            this.размытиеToolStripMenuItem,
            this.выделеинеГраницToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("EpsilonCTT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // цветокорекцияToolStripMenuItem
            // 
            this.цветокорекцияToolStripMenuItem.Name = "цветокорекцияToolStripMenuItem";
            this.цветокорекцияToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.цветокорекцияToolStripMenuItem.Tag = "0";
            this.цветокорекцияToolStripMenuItem.Text = "Цветокорекция";
            this.цветокорекцияToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.размытиеToolStripMenuItem.Tag = "1";
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // выделеинеГраницToolStripMenuItem
            // 
            this.выделеинеГраницToolStripMenuItem.Name = "выделеинеГраницToolStripMenuItem";
            this.выделеинеГраницToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.выделеинеГраницToolStripMenuItem.Tag = "2";
            this.выделеинеГраницToolStripMenuItem.Text = "Выделеине границ";
            this.выделеинеГраницToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GammaContorl);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.BtnGauskernel);
            this.groupBox2.Controls.Add(this.KernleSizeControl);
            this.groupBox2.Controls.Add(this.BtnKernel);
            this.groupBox2.Controls.Add(this.Btnblur);
            this.groupBox2.Location = new System.Drawing.Point(675, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 488);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "1";
            this.groupBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(752, 10);
            this.progressBar1.TabIndex = 15;
            // 
            // BtnGauskernel
            // 
            this.BtnGauskernel.Font = new System.Drawing.Font("EpsilonCTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGauskernel.Location = new System.Drawing.Point(685, 103);
            this.BtnGauskernel.Name = "BtnGauskernel";
            this.BtnGauskernel.Size = new System.Drawing.Size(74, 44);
            this.BtnGauskernel.TabIndex = 7;
            this.BtnGauskernel.Text = "Гаусс";
            this.BtnGauskernel.UseVisualStyleBackColor = true;
            this.BtnGauskernel.Click += new System.EventHandler(this.button4_Click);
            // 
            // KernleSizeControl
            // 
            this.KernleSizeControl.Font = new System.Drawing.Font("EpsilonCTT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KernleSizeControl.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KernleSizeControl.Location = new System.Drawing.Point(685, 19);
            this.KernleSizeControl.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.KernleSizeControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KernleSizeControl.Name = "KernleSizeControl";
            this.KernleSizeControl.Size = new System.Drawing.Size(38, 29);
            this.KernleSizeControl.TabIndex = 6;
            this.KernleSizeControl.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KernleSizeControl.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // BtnKernel
            // 
            this.BtnKernel.Font = new System.Drawing.Font("EpsilonCTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnKernel.Location = new System.Drawing.Point(685, 53);
            this.BtnKernel.Name = "BtnKernel";
            this.BtnKernel.Size = new System.Drawing.Size(74, 44);
            this.BtnKernel.TabIndex = 5;
            this.BtnKernel.Text = "Ядро";
            this.BtnKernel.UseVisualStyleBackColor = true;
            this.BtnKernel.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btnblur
            // 
            this.Btnblur.Font = new System.Drawing.Font("EpsilonCTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btnblur.Location = new System.Drawing.Point(651, 424);
            this.Btnblur.Name = "Btnblur";
            this.Btnblur.Size = new System.Drawing.Size(108, 46);
            this.Btnblur.TabIndex = 4;
            this.Btnblur.Text = "Размыть";
            this.Btnblur.UseVisualStyleBackColor = true;
            this.Btnblur.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.BtnGetBorder);
            this.groupBox3.Location = new System.Drawing.Point(675, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 488);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "2";
            this.groupBox3.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 472);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(752, 10);
            this.progressBar2.TabIndex = 15;
            // 
            // BtnGetBorder
            // 
            this.BtnGetBorder.Font = new System.Drawing.Font("EpsilonCTT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGetBorder.Location = new System.Drawing.Point(196, 204);
            this.BtnGetBorder.Name = "BtnGetBorder";
            this.BtnGetBorder.Size = new System.Drawing.Size(375, 70);
            this.BtnGetBorder.TabIndex = 4;
            this.BtnGetBorder.Text = "Выделить границы";
            this.BtnGetBorder.UseVisualStyleBackColor = true;
            this.BtnGetBorder.Click += new System.EventHandler(this.BtnGetBorder_Click);
            // 
            // GammaContorl
            // 
            this.GammaContorl.Font = new System.Drawing.Font("EpsilonCTT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GammaContorl.Location = new System.Drawing.Point(686, 153);
            this.GammaContorl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GammaContorl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GammaContorl.Name = "GammaContorl";
            this.GammaContorl.Size = new System.Drawing.Size(73, 29);
            this.GammaContorl.TabIndex = 16;
            this.GammaContorl.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 567);
            this.Controls.Add(this.BtnLoadimage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "KG-1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLine)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KernleSizeControl)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GammaContorl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BtnLoadimage;
        private System.Windows.Forms.DataVisualization.Charting.Chart RedChart;
        private System.Windows.Forms.Button BtnColorcorect;
        private System.Windows.Forms.DataVisualization.Charting.Chart GreenChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BlueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btnblur;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветокорекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown TopLine;
        private System.Windows.Forms.NumericUpDown BottomLine;
        private System.Windows.Forms.Button BtnGauskernel;
        private System.Windows.Forms.NumericUpDown KernleSizeControl;
        private System.Windows.Forms.Button BtnKernel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem выделеинеГраницToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button BtnGetBorder;
        private System.Windows.Forms.NumericUpDown GammaContorl;
    }
}

