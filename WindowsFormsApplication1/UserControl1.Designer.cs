namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea3.BorderColor = System.Drawing.Color.DarkRed;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.DodgerBlue;
            series7.Legend = "Legend1";
            series7.Name = "Ref";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Sin";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Lime;
            series9.Legend = "Legend1";
            series9.Name = "Cos";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(729, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(43, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(6, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 95);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox4.Location = new System.Drawing.Point(368, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "V_COS";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 43);
            this.progressBar4.Maximum = 26;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(148, 22);
            this.progressBar4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(43, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox3.Location = new System.Drawing.Point(199, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 81);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "V_SIN";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 43);
            this.progressBar3.Maximum = 26;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(148, 22);
            this.progressBar3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox2.Location = new System.Drawing.Point(26, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "V_REF";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 43);
            this.progressBar2.Maximum = 26;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(148, 22);
            this.progressBar2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox1.Location = new System.Drawing.Point(535, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FREQUENCY";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 43);
            this.progressBar1.Maximum = 2000;
            this.progressBar1.Minimum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(148, 22);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 200;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1.Location = new System.Drawing.Point(636, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "REF SIGNAL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(635, 136);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "SIN SIGNAL";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.ForeColor = System.Drawing.Color.Lime;
            this.checkBox3.Location = new System.Drawing.Point(635, 159);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "COS SIGNAL";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(735, 353);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar4;
        public System.Windows.Forms.ProgressBar progressBar3;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox3;
    }
}
