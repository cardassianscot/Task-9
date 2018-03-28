namespace Task_9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polynomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 52);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(800, 398);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polynomialToolStripMenuItem,
            this.trigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polynomialToolStripMenuItem
            // 
            this.polynomialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yxToolStripMenuItem,
            this.yxToolStripMenuItem1,
            this.yxToolStripMenuItem2});
            this.polynomialToolStripMenuItem.Name = "polynomialToolStripMenuItem";
            this.polynomialToolStripMenuItem.Size = new System.Drawing.Size(176, 48);
            this.polynomialToolStripMenuItem.Text = "Polynomial";
            // 
            // yxToolStripMenuItem
            // 
            this.yxToolStripMenuItem.Name = "yxToolStripMenuItem";
            this.yxToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.yxToolStripMenuItem.Text = "y=x";
            this.yxToolStripMenuItem.Click += new System.EventHandler(this.yxToolStripMenuItem_Click);
            // 
            // yxToolStripMenuItem1
            // 
            this.yxToolStripMenuItem1.Name = "yxToolStripMenuItem1";
            this.yxToolStripMenuItem1.Size = new System.Drawing.Size(396, 46);
            this.yxToolStripMenuItem1.Text = "y=x²";
            this.yxToolStripMenuItem1.Click += new System.EventHandler(this.yxToolStripMenuItem1_Click);
            // 
            // yxToolStripMenuItem2
            // 
            this.yxToolStripMenuItem2.Name = "yxToolStripMenuItem2";
            this.yxToolStripMenuItem2.Size = new System.Drawing.Size(396, 46);
            this.yxToolStripMenuItem2.Text = "y=x³";
            this.yxToolStripMenuItem2.Click += new System.EventHandler(this.yxToolStripMenuItem2_Click);
            // 
            // trigToolStripMenuItem
            // 
            this.trigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.tanToolStripMenuItem});
            this.trigToolStripMenuItem.Name = "trigToolStripMenuItem";
            this.trigToolStripMenuItem.Size = new System.Drawing.Size(78, 48);
            this.trigToolStripMenuItem.Text = "Trig";
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.sinToolStripMenuItem.Text = "sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.cosToolStripMenuItem.Text = "cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // tanToolStripMenuItem
            // 
            this.tanToolStripMenuItem.Name = "tanToolStripMenuItem";
            this.tanToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.tanToolStripMenuItem.Text = "tan";
            this.tanToolStripMenuItem.Click += new System.EventHandler(this.tanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polynomialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem trigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanToolStripMenuItem;
    }
}

