using System.IO;
using System.Windows.Forms;

namespace again
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rjRadioButton2 = new again.RJRadioButton();
            this.rjRadioButton1 = new again.RJRadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 102);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(673, 379);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 1;
            this.vlcControl1.Text = "vlcControl1";
            // this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcLibDirectory = (new DirectoryInfo(string.Format(@"{0}\\vlc", Application.StartupPath)));
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("庞门正道标题体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "软件介绍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("江西拙楷", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(185, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "软件名称: Betasture, 全称为 The Beauty of data structures, 译为数据结构之美, 是一款\r\n学习类视频软件。 软件涵盖了" +
    "多种数据结构与算法的原创视频, 并提供了 MP4 和 M3U8\r\n两种视频播放格式, 和五种不同的播放速率, 便于用户更好的选择。\r\n";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Crimson;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("庞门正道标题体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(706, 102);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "详细说明";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(713, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "更多指南↘↘";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(941, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "视频右侧";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文细黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(886, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 48);
            this.label4.TabIndex = 20;
            this.label4.Text = "每个视频的最右侧(软件最大化后), 都\r\n设有对该算法详细的介绍, 帮助用户更\r\n方便的了解算法的背景。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(941, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "播放速率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文细黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(886, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 48);
            this.label7.TabIndex = 22;
            this.label7.Text = "考虑到不同层次的用户, 为了照顾不同\r\n的用户, 软件设有五种不同的播放速率, \r\n分别为 0.75, 1.25, 1.5, 2.0 和原速。";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(889, 221);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(252, 45);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.Value = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(897, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "0.75    1.0    1.25    1.5    2.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文细黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(886, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 32);
            this.label9.TabIndex = 26;
            this.label9.Text = "简单解释一下 M3U8 格式, 该播放格式\r\n能实现稳定, 无卡顿的播放整个视频。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(941, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "播放格式";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("华文细黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(886, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 32);
            this.label11.TabIndex = 28;
            this.label11.Text = "软件还特别提供了快照功能, 点击快照\r\n按钮即可保存视频截图到当前目录。";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(941, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 27);
            this.label12.TabIndex = 27;
            this.label12.Text = "视频快照";
            // 
            // rjRadioButton2
            // 
            this.rjRadioButton2.AutoSize = true;
            this.rjRadioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton2.Font = new System.Drawing.Font("江西拙楷", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjRadioButton2.Location = new System.Drawing.Point(1041, 360);
            this.rjRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton2.Name = "rjRadioButton2";
            this.rjRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton2.Size = new System.Drawing.Size(63, 24);
            this.rjRadioButton2.TabIndex = 30;
            this.rjRadioButton2.Text = "mp4";
            this.rjRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.Checked = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Font = new System.Drawing.Font("江西拙楷", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rjRadioButton1.Location = new System.Drawing.Point(917, 360);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(72, 24);
            this.rjRadioButton1.TabIndex = 29;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "m3u8";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(699, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "软件拓扑结构说明";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("隶书", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(733, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "一级视频";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("隶书", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(733, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "二级视频";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(720, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 23);
            this.label16.TabIndex = 34;
            this.label16.Text = "KMP   二叉树";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label17.Location = new System.Drawing.Point(725, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "线性表 2 个";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label18.Location = new System.Drawing.Point(716, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 23);
            this.label18.TabIndex = 36;
            this.label18.Text = "栈和队列 2 个";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label19.Location = new System.Drawing.Point(749, 378);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 23);
            this.label19.TabIndex = 37;
            this.label19.Text = "图 2 个";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label20.Location = new System.Drawing.Point(739, 409);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 38;
            this.label20.Text = "排序 8 个";
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rjRadioButton2);
            this.Controls.Add(this.rjRadioButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vlcControl1);
            this.Name = "Introduction";
            this.Text = "Introduction";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private RJRadioButton rjRadioButton2;
        private RJRadioButton rjRadioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}