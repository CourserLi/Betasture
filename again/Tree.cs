using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace again
{
    public partial class Tree : Form
    {
        public Tree()
        {
            InitializeComponent();
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
                    vlcControl1.Play(new Uri("http://114.115.254.164:8081/tree/tree.m3u8"));
                }
                else
                {
                    vlcControl1.Play(new Uri("http://114.115.254.164:8081/tree.mp4"));
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
