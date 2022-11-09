using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace again
{
    public partial class Hill : Form
    {
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private RJProgressBar rjProgressBar1;
        private CustomControls.RJControls.RJButton rjButton3;
        private Label label3;
        private Label label2;
        private TrackBar trackBar1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label1;
        private RJRadioButton rjRadioButton2;
        private RJRadioButton rjRadioButton1;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private PictureBox pictureBox1;
        private Timer timer1;
        private IContainer components;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;

        public Hill()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hill));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rjProgressBar1 = new again.RJProgressBar();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rjRadioButton2 = new again.RJRadioButton();
            this.rjRadioButton1 = new again.RJRadioButton();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(898, 100);
            this.label9.MaximumSize = new System.Drawing.Size(240, 400);
            this.label9.MinimumSize = new System.Drawing.Size(240, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 400);
            this.label9.TabIndex = 43;
            this.label9.Text = "希尔排序是非稳定排序算法。该方法因 D.L.Shell 于 1959 年提出而得名。希尔排序是把记录按下标的一定增量分组，对每组使用直接插入排序算法排序；随着增量" +
    "逐渐减少，每组包含的关键词越来越多，当增量减至 1 时，整个文件恰被分成一组，算法便终止。\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(932, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 34);
            this.label8.TabIndex = 42;
            this.label8.Text = "希尔排序";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("庞门正道标题体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(333, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 42);
            this.label7.TabIndex = 41;
            this.label7.Text = "希尔排序";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(712, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 35);
            this.label6.TabIndex = 37;
            this.label6.Text = "算法说明>>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("幼圆", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(347, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(714, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "00:00/00:00";
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar1.ChannelHeight = 12;
            this.rjProgressBar1.Font = new System.Drawing.Font("幼圆", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.CornflowerBlue;
            this.rjProgressBar1.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar1.Location = new System.Drawing.Point(12, 453);
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = false;
            this.rjProgressBar1.ShowValue = again.TextPosition.None;
            this.rjProgressBar1.Size = new System.Drawing.Size(682, 40);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.CornflowerBlue;
            this.rjProgressBar1.SliderHeight = 18;
            this.rjProgressBar1.SymbolAfter = "%";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 34;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.HotPink;
            this.rjButton3.BackgroundColor = System.Drawing.Color.HotPink;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("庞门正道标题体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.Location = new System.Drawing.Point(716, 320);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(150, 40);
            this.rjButton3.TabIndex = 33;
            this.rjButton3.Text = "快照";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(812, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(709, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "播放速率:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(705, 411);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 45);
            this.trackBar1.TabIndex = 30;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("庞门正道标题体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(716, 274);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 29;
            this.rjButton2.Text = "暂停";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("庞门正道标题体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(716, 228);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 28;
            this.rjButton1.Text = "开始";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(717, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "选择播放视频格式[提示]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rjRadioButton2
            // 
            this.rjRadioButton2.AutoSize = true;
            this.rjRadioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton2.Font = new System.Drawing.Font("江西拙楷", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjRadioButton2.Location = new System.Drawing.Point(721, 181);
            this.rjRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton2.Name = "rjRadioButton2";
            this.rjRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton2.Size = new System.Drawing.Size(77, 32);
            this.rjRadioButton2.TabIndex = 26;
            this.rjRadioButton2.Text = "mp4";
            this.rjRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.Checked = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Font = new System.Drawing.Font("江西拙楷", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjRadioButton1.Location = new System.Drawing.Point(721, 143);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(153, 32);
            this.rjRadioButton1.TabIndex = 25;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "m3u8 [推荐]";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 63);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(682, 384);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 24;
            this.vlcControl1.Text = "vlcControl1";
            // this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcLibDirectory = (new DirectoryInfo(string.Format(@"{0}\\vlc", Application.StartupPath)));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(716, -26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, -26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // Hill
            // 
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rjProgressBar1);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjRadioButton2);
            this.Controls.Add(this.rjRadioButton1);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Hill";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            String message = "M3U8 播放视频更加稳定，但初始加载时间较长\r\nMP4 播放视频加载时间较短，但接收信号不稳定";
            RJMessageBox.Show(message, "播放小提示 (￣∀￣)", buttons);
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "开始")
            {
                timer1.Start();
                if (rjRadioButton1.Checked)
                {
                    vlcControl1.Play(new Uri("http://114.115.254.164:8081/hill/hill.m3u8"));
                }
                else
                {
                    vlcControl1.Play(new Uri("http://114.115.254.164:8081/hill.mp4"));
                }
                rjButton1.Text = "立即停止";
            }
            else
            {
                vlcControl1.Stop();
                timer1.Stop();
                rjButton1.Text = "开始";
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (rjButton2.Text == "播放")
            {
                vlcControl1.Play();
                timer1.Start();
                rjButton2.Text = "暂停";
            }
            else
            {
                vlcControl1.Pause();
                timer1.Stop();
                rjButton2.Text = "播放";
            }
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {
            float position = vlcControl1.Position;
            long tmp = vlcControl1.Length; // 总毫秒
            float nowtimes = position*tmp;
            int nowtime = Convert.ToInt32(nowtimes);
            int nowminute = nowtime / 1000 / 60;
            int nowsecond = nowtime / 1000 % 60;
            String NOWTIME = "";
            if (nowminute < 10)
                NOWTIME = "(" + "0" + nowminute.ToString() + "：";
            else
                NOWTIME = "(" + nowminute.ToString() + "：";
            if (nowsecond < 10)
                NOWTIME = NOWTIME + "0" + nowsecond.ToString() + ")";
            else
                NOWTIME = NOWTIME + nowsecond.ToString() + ")";
            vlcControl1.TakeSnapshot(".\\Snap_" + NOWTIME + ".png"); // 保存到本地当前目录
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            String message = "已经存储快照到当前目录啦~  注意名称是当前时间戳哦~";
            RJMessageBox.Show(message, "快照小提示 (￣∀￣)", buttons);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            String temp = trackBar1.Value.ToString();
            switch (temp)
            {
                case "1":
                    vlcControl1.Rate = 0.75f;
                    label3.Text = "0.75";
                    break;
                case "2":
                    vlcControl1.Rate = 1f;
                    label3.Text = "1.0";
                    break;
                case "3":
                    vlcControl1.Rate = 1.25f;
                    label3.Text = "1.25";
                    break;
                case "4":
                    vlcControl1.Rate = 1.5f;
                    label3.Text = "1.5";
                    break;
                case "5":
                    vlcControl1.Rate = 2.0f;
                    label3.Text = "2.0";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float position = vlcControl1.Position;
            // 用于即时计算（Position -> 进度条百分比、播放时间）
            if (position < 1)
            {
                long tmp = vlcControl1.Length; // 总毫秒
                int temp = Convert.ToInt32(tmp);
                int minute = temp / 1000 / 60;
                int second = temp / 1000 % 60;
                String TIME = "";
                String NOWTIME = "";
                // 进度条百分比
                float percents = position*100;
                String percent = percents.ToString();
                String Percents = "";
                if (percents < 10)
                    Percents = percent.Substring(0, 1);
                else
                    Percents = percent.Substring(0, 2);
                label5.Text = Percents + "%";
                rjProgressBar1.Value = Convert.ToInt32(Percents);
                // 播放时间
                float nowtimes = position*tmp;
                int nowtime = Convert.ToInt32(nowtimes);
                int nowminute = nowtime / 1000 / 60;
                int nowsecond = nowtime / 1000 % 60;
                if (nowminute < 10)
                    NOWTIME = "0" + nowminute.ToString() + ":";
                else
                    NOWTIME = nowminute.ToString() + ":";
                if (nowsecond < 10)
                    NOWTIME = NOWTIME + "0" + nowsecond.ToString();
                else
                    NOWTIME = NOWTIME + nowsecond.ToString();
                if (minute < 10)
                    TIME = "0" + minute.ToString() + ":";
                else
                    TIME = minute.ToString() + ":";
                if (second < 10)
                    TIME = TIME + "0" + second.ToString();
                else
                    TIME = TIME + second.ToString();
                label4.Text = NOWTIME + "/" + TIME;
            }
        }
    }
}
