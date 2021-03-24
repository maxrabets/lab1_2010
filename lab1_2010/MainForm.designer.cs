namespace lab1_2010
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.saveGrayButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveBinButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.histograms = new System.Windows.Forms.TabPage();
            this.grayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.binChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.binarization = new System.Windows.Forms.TabPage();
            this.binarizeButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openGray = new System.Windows.Forms.Button();
            this.buildGistogrammsButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.main.SuspendLayout();
            this.histograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binChart)).BeginInit();
            this.binarization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(6, 433);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(162, 36);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Откыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(174, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 185);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(365, 410);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(377, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(409, 410);
            this.dataGridView2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(437, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 185);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(802, 17);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(365, 410);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEndEdit);
            // 
            // saveGrayButton
            // 
            this.saveGrayButton.Location = new System.Drawing.Point(6, 517);
            this.saveGrayButton.Name = "saveGrayButton";
            this.saveGrayButton.Size = new System.Drawing.Size(162, 36);
            this.saveGrayButton.TabIndex = 9;
            this.saveGrayButton.Text = "Сохранить полутоновое";
            this.saveGrayButton.UseVisualStyleBackColor = true;
            this.saveGrayButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            // 
            // saveBinButton
            // 
            this.saveBinButton.Location = new System.Drawing.Point(6, 475);
            this.saveBinButton.Name = "saveBinButton";
            this.saveBinButton.Size = new System.Drawing.Size(162, 36);
            this.saveBinButton.TabIndex = 10;
            this.saveBinButton.Text = "Сохранить бинарное";
            this.saveBinButton.UseVisualStyleBackColor = true;
            this.saveBinButton.Click += new System.EventHandler(this.saveBinButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Построить гистограммы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main);
            this.tabControl1.Controls.Add(this.histograms);
            this.tabControl1.Controls.Add(this.binarization);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 658);
            this.tabControl1.TabIndex = 12;
            // 
            // main
            // 
            this.main.Controls.Add(this.dataGridView1);
            this.main.Controls.Add(this.saveBinButton);
            this.main.Controls.Add(this.button1);
            this.main.Controls.Add(this.saveGrayButton);
            this.main.Controls.Add(this.dataGridView2);
            this.main.Controls.Add(this.pictureBox2);
            this.main.Controls.Add(this.dataGridView3);
            this.main.Controls.Add(this.pictureBox1);
            this.main.Controls.Add(this.openFileButton);
            this.main.Location = new System.Drawing.Point(4, 22);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(1173, 632);
            this.main.TabIndex = 0;
            this.main.Text = "Главная";
            this.main.UseVisualStyleBackColor = true;
            // 
            // histograms
            // 
            this.histograms.Controls.Add(this.grayChart);
            this.histograms.Controls.Add(this.binChart);
            this.histograms.Location = new System.Drawing.Point(4, 22);
            this.histograms.Name = "histograms";
            this.histograms.Padding = new System.Windows.Forms.Padding(3);
            this.histograms.Size = new System.Drawing.Size(1173, 632);
            this.histograms.TabIndex = 1;
            this.histograms.Text = "Гистограммы";
            this.histograms.UseVisualStyleBackColor = true;
            // 
            // grayChart
            // 
            chartArea1.Name = "ChartArea1";
            this.grayChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grayChart.Legends.Add(legend1);
            this.grayChart.Location = new System.Drawing.Point(328, 6);
            this.grayChart.Name = "grayChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grayChart.Series.Add(series1);
            this.grayChart.Size = new System.Drawing.Size(300, 300);
            this.grayChart.TabIndex = 1;
            this.grayChart.Text = "chart2";
            // 
            // binChart
            // 
            chartArea2.Name = "ChartArea1";
            this.binChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.binChart.Legends.Add(legend2);
            this.binChart.Location = new System.Drawing.Point(3, 6);
            this.binChart.Name = "binChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.binChart.Series.Add(series2);
            this.binChart.Size = new System.Drawing.Size(300, 300);
            this.binChart.TabIndex = 0;
            this.binChart.Text = "chart1";
            // 
            // binarization
            // 
            this.binarization.Controls.Add(this.buildGistogrammsButton2);
            this.binarization.Controls.Add(this.binarizeButton);
            this.binarization.Controls.Add(this.numericUpDown1);
            this.binarization.Controls.Add(this.saveButton);
            this.binarization.Controls.Add(this.pictureBox4);
            this.binarization.Controls.Add(this.pictureBox3);
            this.binarization.Controls.Add(this.openGray);
            this.binarization.Location = new System.Drawing.Point(4, 22);
            this.binarization.Name = "binarization";
            this.binarization.Size = new System.Drawing.Size(1173, 632);
            this.binarization.TabIndex = 2;
            this.binarization.Text = "Бинаризация";
            this.binarization.UseVisualStyleBackColor = true;
            // 
            // binarizeButton
            // 
            this.binarizeButton.Location = new System.Drawing.Point(647, 12);
            this.binarizeButton.Name = "binarizeButton";
            this.binarizeButton.Size = new System.Drawing.Size(123, 36);
            this.binarizeButton.TabIndex = 13;
            this.binarizeButton.Text = "Бинаризовать";
            this.binarizeButton.UseVisualStyleBackColor = true;
            this.binarizeButton.Click += new System.EventHandler(this.binarizeButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(521, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(187, 18);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 36);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(536, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(511, 562);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(19, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(511, 562);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // openGray
            // 
            this.openGray.Location = new System.Drawing.Point(19, 18);
            this.openGray.Name = "openGray";
            this.openGray.Size = new System.Drawing.Size(162, 36);
            this.openGray.TabIndex = 1;
            this.openGray.Text = "Откыть";
            this.openGray.UseVisualStyleBackColor = true;
            this.openGray.Click += new System.EventHandler(this.openGray_Click);
            // 
            // buildGistogrammsButton2
            // 
            this.buildGistogrammsButton2.Location = new System.Drawing.Point(776, 12);
            this.buildGistogrammsButton2.Name = "buildGistogrammsButton2";
            this.buildGistogrammsButton2.Size = new System.Drawing.Size(162, 36);
            this.buildGistogrammsButton2.TabIndex = 14;
            this.buildGistogrammsButton2.Text = "Построить гистограммы";
            this.buildGistogrammsButton2.UseVisualStyleBackColor = true;
            this.buildGistogrammsButton2.Click += new System.EventHandler(this.buildGistogrammsButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 682);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Graphic Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.histograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grayChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binChart)).EndInit();
            this.binarization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button saveGrayButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveBinButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage histograms;
        private System.Windows.Forms.DataVisualization.Charting.Chart grayChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart binChart;
        private System.Windows.Forms.TabPage binarization;
        private System.Windows.Forms.Button openGray;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button binarizeButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buildGistogrammsButton2;
    }
}

