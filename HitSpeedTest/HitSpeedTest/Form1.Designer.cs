﻿namespace HitSpeedTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.lblLifeTime = new System.Windows.Forms.Label();
            this.lblHits1 = new System.Windows.Forms.Label();
            this.lblBpm1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.lblLifeHits = new System.Windows.Forms.Label();
            this.lblHits2 = new System.Windows.Forms.Label();
            this.lblBpm2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkK1 = new System.Windows.Forms.CheckBox();
            this.cmbK1 = new System.Windows.Forms.ComboBox();
            this.chkK2 = new System.Windows.Forms.CheckBox();
            this.cmbK2 = new System.Windows.Forms.ComboBox();
            this.chkM1 = new System.Windows.Forms.CheckBox();
            this.cmbM1 = new System.Windows.Forms.ComboBox();
            this.chkM2 = new System.Windows.Forms.CheckBox();
            this.cmbM2 = new System.Windows.Forms.ComboBox();
            this.displayBPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BPM0 = new System.Windows.Forms.Label();
            this.BPM10 = new System.Windows.Forms.Label();
            this.BPM9 = new System.Windows.Forms.Label();
            this.BPM8 = new System.Windows.Forms.Label();
            this.BPM7 = new System.Windows.Forms.Label();
            this.BPM6 = new System.Windows.Forms.Label();
            this.BPM5 = new System.Windows.Forms.Label();
            this.BPM4 = new System.Windows.Forms.Label();
            this.BPM3 = new System.Windows.Forms.Label();
            this.BPM2 = new System.Windows.Forms.Label();
            this.BPM1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picStatus
            // 
            this.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStatus.Location = new System.Drawing.Point(35, 231);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(577, 299);
            this.picStatus.TabIndex = 3;
            this.picStatus.TabStop = false;
            this.picStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.picStatus_Paint);
            this.picStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.picStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(532, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 50);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset (Enter)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLife);
            this.groupBox1.Controls.Add(this.lblLifeTime);
            this.groupBox1.Controls.Add(this.lblHits1);
            this.groupBox1.Controls.Add(this.lblBpm1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 132);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Average BPM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number of clicks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time remaining:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Timed testing";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test time (seconds):";
            // 
            // txtLife
            // 
            this.txtLife.Location = new System.Drawing.Point(111, 41);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(85, 20);
            this.txtLife.TabIndex = 11;
            this.txtLife.Text = "5";
            this.txtLife.Leave += new System.EventHandler(this.txtLife_Leave);
            // 
            // lblLifeTime
            // 
            this.lblLifeTime.AutoSize = true;
            this.lblLifeTime.Location = new System.Drawing.Point(90, 73);
            this.lblLifeTime.Name = "lblLifeTime";
            this.lblLifeTime.Size = new System.Drawing.Size(34, 13);
            this.lblLifeTime.TabIndex = 18;
            this.lblLifeTime.Text = "1.234";
            // 
            // lblHits1
            // 
            this.lblHits1.AutoSize = true;
            this.lblHits1.Location = new System.Drawing.Point(100, 103);
            this.lblHits1.Name = "lblHits1";
            this.lblHits1.Size = new System.Drawing.Size(25, 13);
            this.lblHits1.TabIndex = 16;
            this.lblHits1.Text = "183";
            // 
            // lblBpm1
            // 
            this.lblBpm1.AutoSize = true;
            this.lblBpm1.Location = new System.Drawing.Point(260, 103);
            this.lblBpm1.Name = "lblBpm1";
            this.lblBpm1.Size = new System.Drawing.Size(34, 13);
            this.lblBpm1.TabIndex = 19;
            this.lblBpm1.Text = "123.4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHits);
            this.groupBox2.Controls.Add(this.lblLifeHits);
            this.groupBox2.Controls.Add(this.lblHits2);
            this.groupBox2.Controls.Add(this.lblBpm2);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Average BPM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Number of clicks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Number of remaining clicks:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(324, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "Click count testing";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Number of clicks:";
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(98, 41);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(85, 20);
            this.txtHits.TabIndex = 20;
            this.txtHits.Text = "50";
            this.txtHits.Leave += new System.EventHandler(this.txtHits_Leave);
            // 
            // lblLifeHits
            // 
            this.lblLifeHits.AutoSize = true;
            this.lblLifeHits.Location = new System.Drawing.Point(146, 75);
            this.lblLifeHits.Name = "lblLifeHits";
            this.lblLifeHits.Size = new System.Drawing.Size(19, 13);
            this.lblLifeHits.TabIndex = 27;
            this.lblLifeHits.Text = "23";
            // 
            // lblHits2
            // 
            this.lblHits2.AutoSize = true;
            this.lblHits2.Location = new System.Drawing.Point(101, 103);
            this.lblHits2.Name = "lblHits2";
            this.lblHits2.Size = new System.Drawing.Size(25, 13);
            this.lblHits2.TabIndex = 25;
            this.lblHits2.Text = "183";
            // 
            // lblBpm2
            // 
            this.lblBpm2.AutoSize = true;
            this.lblBpm2.Location = new System.Drawing.Point(254, 103);
            this.lblBpm2.Name = "lblBpm2";
            this.lblBpm2.Size = new System.Drawing.Size(34, 13);
            this.lblBpm2.TabIndex = 28;
            this.lblBpm2.Text = "123.4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 50);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkK1);
            this.flowLayoutPanel1.Controls.Add(this.cmbK1);
            this.flowLayoutPanel1.Controls.Add(this.chkK2);
            this.flowLayoutPanel1.Controls.Add(this.cmbK2);
            this.flowLayoutPanel1.Controls.Add(this.chkM1);
            this.flowLayoutPanel1.Controls.Add(this.cmbM1);
            this.flowLayoutPanel1.Controls.Add(this.chkM2);
            this.flowLayoutPanel1.Controls.Add(this.cmbM2);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkK1
            // 
            this.chkK1.Checked = true;
            this.chkK1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkK1.Location = new System.Drawing.Point(3, 3);
            this.chkK1.Name = "chkK1";
            this.chkK1.Size = new System.Drawing.Size(44, 22);
            this.chkK1.TabIndex = 8;
            this.chkK1.Text = "K1:";
            this.chkK1.UseVisualStyleBackColor = true;
            this.chkK1.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbK1
            // 
            this.cmbK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK1.FormattingEnabled = true;
            this.cmbK1.Location = new System.Drawing.Point(53, 3);
            this.cmbK1.Name = "cmbK1";
            this.cmbK1.Size = new System.Drawing.Size(69, 21);
            this.cmbK1.TabIndex = 9;
            this.cmbK1.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkK2
            // 
            this.chkK2.Checked = true;
            this.chkK2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkK2.Location = new System.Drawing.Point(128, 3);
            this.chkK2.Name = "chkK2";
            this.chkK2.Size = new System.Drawing.Size(44, 22);
            this.chkK2.TabIndex = 7;
            this.chkK2.Text = "K2:";
            this.chkK2.UseVisualStyleBackColor = true;
            this.chkK2.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbK2
            // 
            this.cmbK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK2.FormattingEnabled = true;
            this.cmbK2.Location = new System.Drawing.Point(178, 3);
            this.cmbK2.Name = "cmbK2";
            this.cmbK2.Size = new System.Drawing.Size(69, 21);
            this.cmbK2.TabIndex = 10;
            this.cmbK2.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkM1
            // 
            this.chkM1.Checked = true;
            this.chkM1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkM1.Location = new System.Drawing.Point(253, 3);
            this.chkM1.Name = "chkM1";
            this.chkM1.Size = new System.Drawing.Size(44, 22);
            this.chkM1.TabIndex = 6;
            this.chkM1.Text = "M1:";
            this.chkM1.UseVisualStyleBackColor = true;
            this.chkM1.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbM1
            // 
            this.cmbM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM1.FormattingEnabled = true;
            this.cmbM1.Location = new System.Drawing.Point(303, 3);
            this.cmbM1.Name = "cmbM1";
            this.cmbM1.Size = new System.Drawing.Size(69, 21);
            this.cmbM1.TabIndex = 11;
            this.cmbM1.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkM2
            // 
            this.chkM2.Checked = true;
            this.chkM2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkM2.Location = new System.Drawing.Point(378, 3);
            this.chkM2.Name = "chkM2";
            this.chkM2.Size = new System.Drawing.Size(44, 22);
            this.chkM2.TabIndex = 5;
            this.chkM2.Text = "M2:";
            this.chkM2.UseVisualStyleBackColor = true;
            this.chkM2.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbM2
            // 
            this.cmbM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM2.FormattingEnabled = true;
            this.cmbM2.Location = new System.Drawing.Point(428, 3);
            this.cmbM2.Name = "cmbM2";
            this.cmbM2.Size = new System.Drawing.Size(69, 21);
            this.cmbM2.TabIndex = 12;
            this.cmbM2.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // displayBPM
            // 
            this.displayBPM.Location = new System.Drawing.Point(441, 206);
            this.displayBPM.Name = "displayBPM";
            this.displayBPM.Size = new System.Drawing.Size(85, 20);
            this.displayBPM.TabIndex = 30;
            this.displayBPM.Text = "300";
            this.displayBPM.Leave += new System.EventHandler(this.displayBPM_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Max displayed BPM:";
            // 
            // BPM0
            // 
            this.BPM0.AutoSize = true;
            this.BPM0.Location = new System.Drawing.Point(4, 523);
            this.BPM0.Name = "BPM0";
            this.BPM0.Size = new System.Drawing.Size(13, 13);
            this.BPM0.TabIndex = 21;
            this.BPM0.Text = "0";
            // 
            // BPM10
            // 
            this.BPM10.AutoSize = true;
            this.BPM10.Location = new System.Drawing.Point(4, 225);
            this.BPM10.Name = "BPM10";
            this.BPM10.Size = new System.Drawing.Size(25, 13);
            this.BPM10.TabIndex = 31;
            this.BPM10.Text = "300";
            // 
            // BPM9
            // 
            this.BPM9.AutoSize = true;
            this.BPM9.Location = new System.Drawing.Point(4, 256);
            this.BPM9.Name = "BPM9";
            this.BPM9.Size = new System.Drawing.Size(25, 13);
            this.BPM9.TabIndex = 33;
            this.BPM9.Text = "270";
            // 
            // BPM8
            // 
            this.BPM8.AutoSize = true;
            this.BPM8.Location = new System.Drawing.Point(4, 285);
            this.BPM8.Name = "BPM8";
            this.BPM8.Size = new System.Drawing.Size(25, 13);
            this.BPM8.TabIndex = 34;
            this.BPM8.Text = "240";
            // 
            // BPM7
            // 
            this.BPM7.AutoSize = true;
            this.BPM7.Location = new System.Drawing.Point(4, 315);
            this.BPM7.Name = "BPM7";
            this.BPM7.Size = new System.Drawing.Size(25, 13);
            this.BPM7.TabIndex = 35;
            this.BPM7.Text = "210";
            // 
            // BPM6
            // 
            this.BPM6.AutoSize = true;
            this.BPM6.Location = new System.Drawing.Point(4, 345);
            this.BPM6.Name = "BPM6";
            this.BPM6.Size = new System.Drawing.Size(25, 13);
            this.BPM6.TabIndex = 36;
            this.BPM6.Text = "180";
            // 
            // BPM5
            // 
            this.BPM5.AutoSize = true;
            this.BPM5.Location = new System.Drawing.Point(4, 375);
            this.BPM5.Name = "BPM5";
            this.BPM5.Size = new System.Drawing.Size(25, 13);
            this.BPM5.TabIndex = 37;
            this.BPM5.Text = "150";
            // 
            // BPM4
            // 
            this.BPM4.AutoSize = true;
            this.BPM4.Location = new System.Drawing.Point(4, 405);
            this.BPM4.Name = "BPM4";
            this.BPM4.Size = new System.Drawing.Size(25, 13);
            this.BPM4.TabIndex = 38;
            this.BPM4.Text = "120";
            // 
            // BPM3
            // 
            this.BPM3.AutoSize = true;
            this.BPM3.Location = new System.Drawing.Point(4, 435);
            this.BPM3.Name = "BPM3";
            this.BPM3.Size = new System.Drawing.Size(19, 13);
            this.BPM3.TabIndex = 39;
            this.BPM3.Text = "90";
            // 
            // BPM2
            // 
            this.BPM2.AutoSize = true;
            this.BPM2.Location = new System.Drawing.Point(4, 465);
            this.BPM2.Name = "BPM2";
            this.BPM2.Size = new System.Drawing.Size(19, 13);
            this.BPM2.TabIndex = 40;
            this.BPM2.Text = "60";
            // 
            // BPM1
            // 
            this.BPM1.AutoSize = true;
            this.BPM1.Location = new System.Drawing.Point(4, 495);
            this.BPM1.Name = "BPM1";
            this.BPM1.Size = new System.Drawing.Size(19, 13);
            this.BPM1.TabIndex = 41;
            this.BPM1.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "BPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BPM1);
            this.Controls.Add(this.BPM2);
            this.Controls.Add(this.BPM3);
            this.Controls.Add(this.BPM4);
            this.Controls.Add(this.BPM5);
            this.Controls.Add(this.BPM6);
            this.Controls.Add(this.BPM7);
            this.Controls.Add(this.BPM8);
            this.Controls.Add(this.BPM9);
            this.Controls.Add(this.BPM10);
            this.Controls.Add(this.BPM0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayBPM);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "HitSpeedTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBpm1;
        private System.Windows.Forms.Label lblLifeTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHits1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLife;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBpm2;
        private System.Windows.Forms.Label lblLifeHits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHits2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkK1;
        private System.Windows.Forms.ComboBox cmbK1;
        private System.Windows.Forms.CheckBox chkK2;
        private System.Windows.Forms.ComboBox cmbK2;
        private System.Windows.Forms.CheckBox chkM1;
        private System.Windows.Forms.ComboBox cmbM1;
        private System.Windows.Forms.CheckBox chkM2;
        private System.Windows.Forms.ComboBox cmbM2;
        private System.Windows.Forms.TextBox displayBPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BPM0;
        private System.Windows.Forms.Label BPM10;
        private System.Windows.Forms.Label BPM9;
        private System.Windows.Forms.Label BPM8;
        private System.Windows.Forms.Label BPM7;
        private System.Windows.Forms.Label BPM6;
        private System.Windows.Forms.Label BPM5;
        private System.Windows.Forms.Label BPM4;
        private System.Windows.Forms.Label BPM3;
        private System.Windows.Forms.Label BPM2;
        private System.Windows.Forms.Label BPM1;
        private System.Windows.Forms.Label label6;
    }
}

