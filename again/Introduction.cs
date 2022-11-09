using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace again
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "详细说明")
            {
                vlcControl1.Play(new Uri("http://114.115.254.164:8081/newbegin/newbegin.m3u8"));
                rjButton1.Text = "暂停";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                String message = "视频会提及到软件所涉及到的全部数据结构和算法\r\nPS: 初始加载时间较慢，请耐心食用哦~";
                RJMessageBox.Show(message, "小提示 (￣∀￣)", buttons);
            }
            else if(rjButton1.Text == "暂停")
            {
                vlcControl1.Pause();
                rjButton1.Text = "播放";
            }
            else
            {
                vlcControl1.Play();
                rjButton1.Text = "暂停";
            }
        }
    }
}
