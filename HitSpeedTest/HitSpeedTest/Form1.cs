using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
namespace HitSpeedTest
{
    public partial class Form1 : Form
    {
        HitCalc calc;
        Label lblL, lblH, lblB;
        Settings settings;
        

        Bitmap bitmap=new Bitmap(1200,600);//canvas
        Graphics g;
        Point a, b;
        Point c, d;
        Point bpmlineright0, bpmlineleft0;
        Point bpmlineright1, bpmlineleft1;
        Point bpmlineright2, bpmlineleft2;
        Point bpmlineright3, bpmlineleft3;
        Point bpmlineright4, bpmlineleft4;
        Point bpmlineright5, bpmlineleft5;
        Point bpmlineright6, bpmlineleft6;
        Point bpmlineright7, bpmlineleft7;
        Point bpmlineright8, bpmlineleft8;
        Point bpmlineright9, bpmlineleft9;
        Point bpmlineright10, bpmlineleft10;
        float scalefactor = 300;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add all enum Keys to combolistbox
            string[] keys = Enum.GetNames(typeof(Keys));
            calc = new HitCalc();
            settings = Settings.Load();

            cmbK1.Items.AddRange(keys);
            cmbK2.Items.AddRange(keys);
            cmbM1.Items.AddRange(keys);
            cmbM2.Items.AddRange(keys);
            loadconfig();

            calc.Updated += new EventHandler(calc_Updated);
            calc.Started += new EventHandler(calc_Started);
            calc.Stopped += new EventHandler(calc_Stopped);
            radioButton1_Click(null, null);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            calc.TargetTime = 50000000;//default test time (10000000 ticks=1 second)
            calc.TargetHits = 50;//default test hits

            reset();
        }
        //输入控制
        void calc_Stopped(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = true;
                txtLife.Enabled = true;
            }
            if (radioButton2.Checked == true)
            {
                txtHits.Enabled = true;
                groupBox2.Enabled = true;
            }
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            groupBox3.Enabled = true;
            displayBPM.Enabled = true;
            label4.Enabled = true; //displayBPM label
        }

        void calc_Started(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            txtLife.Enabled = false;
            txtHits.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
            displayBPM.Enabled = false;
            label4.Enabled = false; //displayBPM label

        }
        void loadconfig()
        {
            //由于事件已经在设计器注册，为防止事件破坏设置，使用局部settings，参看settingsChanged方法
            
            Settings settings = Settings.Load();
            cmbK1.Text = Enum.GetName(typeof(Keys), settings.K1);
            cmbK1.Enabled = settings.K1On;

            cmbK2.Text = Enum.GetName(typeof(Keys), settings.K2);
            cmbK2.Enabled = settings.K2On;

            cmbM1.Text = Enum.GetName(typeof(Keys), settings.M1);
            cmbM1.Enabled = settings.M1On;

            cmbM2.Text = Enum.GetName(typeof(Keys), settings.M2);
            cmbM2.Enabled = settings.M2On;

            chkK1.Checked = settings.K1On;
            chkK2.Checked = settings.K2On;
            chkM1.Checked = settings.M1On;
            chkM2.Checked = settings.M2On;
        }
        void calc_Updated(object sender, EventArgs e)
        {
            if (calc.Method == CalcMethod.ByTime)
            {
                lblL.Text = (calc.LeftTime / 10000000.0).ToString("#0.0");//how many seconds left
                lblH.Text = calc.Hits.ToString();//current hits

                double bpm = calc.BPM;
                lblB.Text = bpm.ToString("#0.0");//current average bpm

                if (calc.IsRunning)
                {
                    a = b;
                    c = d;
                    b = new Point((int)((calc.TargetTime - calc.LeftTime) * bitmap.Width / calc.TargetTime), (int)(bitmap.Height - (int)(bpm * bitmap.Height / picStatus.Height) / (scalefactor / 300)));
                    d = new Point((int)((calc.TargetTime - calc.LeftTime) * bitmap.Width / calc.TargetTime), (int)(bitmap.Height - (int)(calc.PartBPM(5) * bitmap.Height / picStatus.Height) / (scalefactor / 300)));
                    if (a != Point.Empty && b != Point.Empty) g.DrawLine(Pens.Green, a, b);
                    if (c != Point.Empty && d != Point.Empty) g.DrawLine(Pens.Blue, c, d);
                    picStatus.Refresh();
                }
            }
            else
            {
                lblL.Text = (calc.TargetHits - calc.Hits).ToString();
                lblH.Text = calc.Hits.ToString();

                double bpm = calc.BPM;
                lblB.Text = bpm.ToString("#0.0");

                if (calc.IsRunning)
                {
                    a = b;
                    c = d;
                    b = new Point((int)(calc.Hits * bitmap.Width / calc.TargetHits), (int)(bitmap.Height - (int)(bpm * bitmap.Height / picStatus.Height) / (scalefactor / 300)));
                    d = new Point((int)(calc.Hits * bitmap.Width / calc.TargetHits), (int)(bitmap.Height - (int)(calc.PartBPM(5) * bitmap.Height / picStatus.Height) / (scalefactor / 300)));
                    if (a != Point.Empty && b != Point.Empty) g.DrawLine(Pens.Green, a, b);
                    if (c != Point.Empty && d != Point.Empty) g.DrawLine(Pens.Blue, c, d);
                    picStatus.Refresh();
                }
            }
        }
        void reset()
        {
            lblBpm2.Text = lblHits2.Text = lblLifeHits.Text=lblBpm1.Text = lblHits1.Text = lblLifeTime.Text = "";
            
            g.Clear(Color.FromArgb(0, 255, 255, 255));//clear canvas
            a = Point.Empty;
            b = Point.Empty;
            c = Point.Empty;
            d = Point.Empty;
            drawmainlines();
            drawminorlines();
        }

        //for time test
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            calc.Method = CalcMethod.ByTime;
            lblL = lblLifeTime;
            lblH = lblHits1;
            lblB = lblBpm1;
        }

        //for hits test
        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            calc.Method = CalcMethod.ByHits;
            lblL = lblLifeHits;
            lblH = lblHits2;
            lblB = lblBpm2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calc.Stop();
            calc.Reset();
            reset();
            btnReset.Focus();
            this.Focus();
        }

        //only accept double
        private void txtLife_Leave(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txtLife.Text, out d))
            {
                calc.TargetTime = (long)(d * 10000000);
            }
            else
            {
                txtLife.Undo();
            }
        }

        //only accept int
        private void txtHits_Leave(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtHits.Text, out i))
            {
                calc.TargetHits = i;
            }
            else
            {
                txtHits.Undo();
            }
        }

        private void displayBPM_Leave(object sender, EventArgs e)
        {
            int bpm_scale;
            if (int.TryParse(displayBPM.Text, out bpm_scale))
            {
                scalefactor = (int)bpm_scale;
                drawmainlines();
                drawminorlines();
                writebpmlegends();
            }
            else
            {
                displayBPM.Undo();
            }
        }

        //picStatus & Form1
        /*warning! 
         * MouseButtons.Left -> Keys.LButton
         * MouseButtons.Middle -> Keys.MButton
         * MouseButtons.Right -> Keys.RButton
         */
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Keys k = Keys.PrintScreen;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    k = Keys.LButton;
                    break;
                case MouseButtons.Right:
                    k = Keys.RButton;
                    break;
                case MouseButtons.Middle:
                    k = Keys.MButton;
                    break;
            }
            if (k != Keys.PrintScreen)
            {
                downProc(k);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Keys k=Keys.PrintScreen;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    k = Keys.LButton;
                    break;
                case MouseButtons.Right:
                    k = Keys.RButton;
                    break;
                case MouseButtons.Middle:
                    k = Keys.MButton;
                    break;
            }
            if (k != Keys.PrintScreen)
            {
                upProc(k);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReset_Click(null, null);
            }
            downProc(e.KeyCode);
            if (calc.IsRunning) e.Handled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            upProc(e.KeyCode);
        }
        void downProc(Keys k)
        {
            if (k == settings.K1 && settings.K1On)
            {
                calc.K1Down();
            }
            if (k == settings.K2 && settings.K2On)
            {
                calc.K2Down();
            }
            if (k == settings.M1&&settings.M1On)
            {
                calc.M1Down();
            }
            if (k == settings.M2 && settings.M2On)
            {
                calc.M2Down();
            }
        }
        void upProc(Keys k)
        {
            if (k == settings.K1 && settings.K1On)
            {
                calc.K1Up();
            }
            if (k == settings.K2 && settings.K2On)
            {
                calc.K2Up();
            }
            if (k == settings.M1 && settings.M1On)
            {
                calc.M1Up();
            }
            if (k == settings.M2 && settings.M2On)
            {
                calc.M2Up();
            }
        }

        private void settingsChanged(object sender, EventArgs e)
        {
            settings.M2On=cmbM2.Enabled = chkM2.Checked;
            settings.M1On=cmbM1.Enabled = chkM1.Checked;
            settings.K2On=cmbK2.Enabled = chkK2.Checked;
            settings.K1On=cmbK1.Enabled = chkK1.Checked;

            settings.K1 = (Keys) Enum.Parse(typeof(Keys), (string)cmbK1.SelectedItem);
            settings.K2 = (Keys)Enum.Parse(typeof(Keys), (string)cmbK2.SelectedItem);
            settings.M1 = (Keys)Enum.Parse(typeof(Keys), (string)cmbM1.SelectedItem);
            settings.M2 = (Keys)Enum.Parse(typeof(Keys), (string)cmbM2.SelectedItem);
            
            //if enabled only 1 key,then single tap style
            int keys=0;
            if (settings.K1On) keys++;
            if (settings.K2On) keys++;
            if (settings.M1On) keys++;
            if (settings.M2On) keys++;
            calc.SingleKey = keys > 1 ? false : true;
              
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Save();
        }

        private void picStatus_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, picStatus.Width, picStatus.Height));
        }

        //禁止输入
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (calc.IsRunning) e.Handled = true;
        }
        public void drawmainlines()
        {
            //render 11 bpm lines from top to bottom
            //line 0 is at the very top and not normally visible
            bpmlineleft0 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * bitmap.Height / picStatus.Height) / (scalefactor / 300)) * 1));
            bpmlineright0 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * bitmap.Height / picStatus.Height) / (scalefactor / 300)) * 1));
            g.DrawLine(Pens.DarkGray, bpmlineleft0, bpmlineright0);
            bpmlineleft1 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.9 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright1 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.9 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft1, bpmlineright1);
            bpmlineleft2 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.8 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright2 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.8 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft2, bpmlineright2);
            bpmlineleft3 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.7 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright3 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.7 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft3, bpmlineright3);
            bpmlineleft4 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.6 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright4 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.6 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft4, bpmlineright4);
            bpmlineleft5 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.5 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright5 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.5 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft5, bpmlineright5);
            bpmlineleft6 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.4 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright6 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.4 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft6, bpmlineright6);
            bpmlineleft7 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.3 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright7 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.3 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft7, bpmlineright7);
            bpmlineleft8 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.2 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright8 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.2 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft8, bpmlineright8);
            bpmlineleft9 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.1 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright9 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.1 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.DarkGray, bpmlineleft9, bpmlineright9);
            //line 10 is at the very bottom and not normally visible
            bpmlineleft10 = new Point(0, (int)bitmap.Height);
            bpmlineright10 = new Point((int)bitmap.Width, (int)bitmap.Height);
            g.DrawLine(Pens.DarkGray, bpmlineleft10, bpmlineright10);
            picStatus.Refresh();
        }
        public void drawminorlines()
        {
            //render 10 lighter bpm lines from top to bottom
            bpmlineleft0 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.95 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright0 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.95 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft0, bpmlineright0);
            bpmlineleft1 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.85 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright1 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.85 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft1, bpmlineright1);
            bpmlineleft2 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.75 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright2 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.75 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft2, bpmlineright2);
            bpmlineleft3 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.65 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright3 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.65 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft3, bpmlineright3);
            bpmlineleft4 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.55 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright4 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.55 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft4, bpmlineright4);
            bpmlineleft5 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.45 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright5 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.45 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft5, bpmlineright5);
            bpmlineleft6 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.35 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright6 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.35 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft6, bpmlineright6);
            bpmlineleft7 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.25 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright7 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.25 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft7, bpmlineright7);
            bpmlineleft8 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.15 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright8 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.15 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft8, bpmlineright8);
            bpmlineleft9 = new Point(0, (int)((bitmap.Height - (int)(scalefactor * 0.05 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            bpmlineright9 = new Point((int)bitmap.Width, (int)((bitmap.Height - (int)(scalefactor * 0.05 * bitmap.Height / picStatus.Height) / (scalefactor / 300))));
            g.DrawLine(Pens.LightGray, bpmlineleft9, bpmlineright9);
            picStatus.Refresh();
        }
        public void writebpmlegends()
        {
            BPM0.Text = ((int)(scalefactor * 0)).ToString();
            BPM1.Text = ((int)(scalefactor * 0.1)).ToString();
            BPM2.Text = ((int)(scalefactor * 0.2)).ToString();
            BPM3.Text = ((int)(scalefactor * 0.3)).ToString();
            BPM4.Text = ((int)(scalefactor * 0.4)).ToString();
            BPM5.Text = ((int)(scalefactor * 0.5)).ToString();
            BPM6.Text = ((int)(scalefactor * 0.6)).ToString();
            BPM7.Text = ((int)(scalefactor * 0.7)).ToString();
            BPM8.Text = ((int)(scalefactor * 0.8)).ToString();
            BPM9.Text = ((int)(scalefactor * 0.9)).ToString();
            BPM10.Text = ((int)(scalefactor * 1)).ToString();
        }
    }
}
