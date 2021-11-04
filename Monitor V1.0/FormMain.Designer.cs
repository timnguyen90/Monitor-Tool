namespace Monitor_V1._0
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel1F1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel2F2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel3F2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel4F3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(0, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1184, 634);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Turquoise;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("Arial", 8F);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.CustomProperties = "IsXAxisQuantitative=False, LabelStyle=Top";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1178, 615);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.channel1F1ToolStripMenuItem,
            this.channel2F2ToolStripMenuItem,
            this.channel3F2ToolStripMenuItem,
            this.channel4F3ToolStripMenuItem,
            this.channel2ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.add_to_folder;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(150, 23);
            this.fileToolStripMenuItem.Text = "Mở File ( Ctr + O )";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // channel1F1ToolStripMenuItem
            // 
            this.channel1F1ToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.Calculator_alt;
            this.channel1F1ToolStripMenuItem.Name = "channel1F1ToolStripMenuItem";
            this.channel1F1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.channel1F1ToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.channel1F1ToolStripMenuItem.Text = "Kênh 1   ( F1 )";
            this.channel1F1ToolStripMenuItem.Click += new System.EventHandler(this.channel1F1ToolStripMenuItem_Click_1);
            // 
            // channel2F2ToolStripMenuItem
            // 
            this.channel2F2ToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.Calculator_alt;
            this.channel2F2ToolStripMenuItem.Name = "channel2F2ToolStripMenuItem";
            this.channel2F2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.channel2F2ToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.channel2F2ToolStripMenuItem.Text = "Kênh 2   ( F2 )";
            this.channel2F2ToolStripMenuItem.Click += new System.EventHandler(this.channel2F2ToolStripMenuItem_Click_1);
            // 
            // channel3F2ToolStripMenuItem
            // 
            this.channel3F2ToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.Calculator_alt;
            this.channel3F2ToolStripMenuItem.Name = "channel3F2ToolStripMenuItem";
            this.channel3F2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.channel3F2ToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.channel3F2ToolStripMenuItem.Text = "Kênh 3   ( F3 )";
            this.channel3F2ToolStripMenuItem.Click += new System.EventHandler(this.channel3F2ToolStripMenuItem_Click_1);
            // 
            // channel4F3ToolStripMenuItem
            // 
            this.channel4F3ToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.Calculator_alt;
            this.channel4F3ToolStripMenuItem.Name = "channel4F3ToolStripMenuItem";
            this.channel4F3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.channel4F3ToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.channel4F3ToolStripMenuItem.Text = "Kênh 4   ( F4 )";
            this.channel4F3ToolStripMenuItem.Click += new System.EventHandler(this.channel4F3ToolStripMenuItem_Click_1);
            // 
            // channel2ToolStripMenuItem
            // 
            this.channel2ToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.refresh;
            this.channel2ToolStripMenuItem.Name = "channel2ToolStripMenuItem";
            this.channel2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.channel2ToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.channel2ToolStripMenuItem.Text = "Reset   ( F5 )";
            this.channel2ToolStripMenuItem.Click += new System.EventHandler(this.channel2ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Monitor_V1._0.Properties.Resources.save;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 23);
            this.aboutToolStripMenuItem.Text = "Save To Image   ( F6 )";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Resource Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel1F1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel2F2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel3F2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel4F3ToolStripMenuItem;
    }
}

