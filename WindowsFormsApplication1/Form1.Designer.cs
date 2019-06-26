namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(237, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 0;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ADJUST AMPLITUDE";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.trackBar2.Location = new System.Drawing.Point(138, 224);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(130, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "AMPLITUDE (Vpp)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(169, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "INSERT AMPLITUDE";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "POSITION :";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label12.Location = new System.Drawing.Point(184, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 39);
            this.label12.TabIndex = 12;
            this.label12.Text = "0.0000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "COM PORT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "230400",
            "460800"});
            this.comboBox2.Location = new System.Drawing.Point(79, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "9600";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "BAUD RATE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Location = new System.Drawing.Point(464, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 107);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM CONTROL";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.button4.Location = new System.Drawing.Point(106, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "CLOSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.button3.Location = new System.Drawing.Point(12, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "OPEN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(41, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(13, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(131, 47);
            this.progressBar1.TabIndex = 17;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Location = new System.Drawing.Point(679, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 107);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM PORT STATUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "INSERT FREQUENCY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "200";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(175, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "200";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "FREQUENCY (Hz)";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.trackBar1.Location = new System.Drawing.Point(144, 79);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ADJUST FREQUENCY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(237, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox3.Location = new System.Drawing.Point(125, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 325);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONTROL PANEL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox4.Location = new System.Drawing.Point(125, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 107);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ANGLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 474);
            this.panel1.TabIndex = 24;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(2)))));
            this.sidePanel.Location = new System.Drawing.Point(3, 12);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(11, 73);
            this.sidePanel.TabIndex = 25;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(25, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 73);
            this.button7.TabIndex = 2;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(25, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 73);
            this.button6.TabIndex = 1;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(25, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 73);
            this.button5.TabIndex = 0;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.userControl11.Location = new System.Drawing.Point(122, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(735, 353);
            this.userControl11.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(854, 474);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Timer timer1;
        private UserControl1 userControl11;
    }
}

