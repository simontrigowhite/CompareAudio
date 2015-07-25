namespace CompareAudio
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Mute1Button = new System.Windows.Forms.Button();
            this.Mute2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.File1Label = new System.Windows.Forms.Label();
            this.File2Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2034, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWaveToolStripMenuItem,
            this.showPositionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 39);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWaveToolStripMenuItem
            // 
            this.openWaveToolStripMenuItem.Name = "openWaveToolStripMenuItem";
            this.openWaveToolStripMenuItem.Size = new System.Drawing.Size(247, 40);
            this.openWaveToolStripMenuItem.Text = "Open Wave ...";
            this.openWaveToolStripMenuItem.Click += new System.EventHandler(this.OpenWaveToolStripMenuItem_Click);
            // 
            // showPositionToolStripMenuItem
            // 
            this.showPositionToolStripMenuItem.Name = "showPositionToolStripMenuItem";
            this.showPositionToolStripMenuItem.Size = new System.Drawing.Size(247, 40);
            this.showPositionToolStripMenuItem.Text = "Show position";
            this.showPositionToolStripMenuItem.Click += new System.EventHandler(this.ShowPositionToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(223, 88);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1773, 262);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(223, 423);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1773, 262);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // Mute1Button
            // 
            this.Mute1Button.Location = new System.Drawing.Point(60, 177);
            this.Mute1Button.Name = "Mute1Button";
            this.Mute1Button.Size = new System.Drawing.Size(110, 56);
            this.Mute1Button.TabIndex = 3;
            this.Mute1Button.Text = "Mute";
            this.Mute1Button.UseVisualStyleBackColor = true;
            this.Mute1Button.Click += new System.EventHandler(this.Mute1Button_Click);
            // 
            // Mute2Button
            // 
            this.Mute2Button.Location = new System.Drawing.Point(60, 523);
            this.Mute2Button.Name = "Mute2Button";
            this.Mute2Button.Size = new System.Drawing.Size(110, 56);
            this.Mute2Button.TabIndex = 4;
            this.Mute2Button.Text = "Mute";
            this.Mute2Button.UseVisualStyleBackColor = true;
            this.Mute2Button.Click += new System.EventHandler(this.Mute2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // File1Label
            // 
            this.File1Label.AutoSize = true;
            this.File1Label.Location = new System.Drawing.Point(240, 353);
            this.File1Label.Name = "File1Label";
            this.File1Label.Size = new System.Drawing.Size(70, 26);
            this.File1Label.TabIndex = 6;
            this.File1Label.Text = "label2";
            // 
            // File2Label
            // 
            this.File2Label.AutoSize = true;
            this.File2Label.Location = new System.Drawing.Point(240, 688);
            this.File2Label.Name = "File2Label";
            this.File2Label.Size = new System.Drawing.Size(70, 26);
            this.File2Label.TabIndex = 7;
            this.File2Label.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2034, 768);
            this.Controls.Add(this.File2Label);
            this.Controls.Add(this.File1Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mute2Button);
            this.Controls.Add(this.Mute1Button);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWaveToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem showPositionToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button Mute1Button;
        private System.Windows.Forms.Button Mute2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label File1Label;
        private System.Windows.Forms.Label File2Label;
    }
}

