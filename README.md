# Betasture

<div align=center><img src="https://s1.ax1x.com/2022/11/10/zSvcuT.png"></div>

## APP 介绍

**Betasture，全称为The Beauty of data structures，译为数据结构之美。它是一款学习类视频软件，极具美感设计的同时，软件涵盖了多种数据结构与算法的原创视频播放，并提供了 MP4 和 M3U8 两种视频播放格式，和五种不同的播放速率等功能，便于用户更好的适应与学习**

软件具备功能：

1. 视频播放功能（需要联网）
2. 可选择不同的章节模块（共六大章节）
3. 内容概述（拖动右下角向右拉伸）
4. 播放速率（五种速率）
5. 播放格式（MP4 和 M3U8）
6. 视频快照（保存至当前目录下）

#### 部分软件截图

<div align=center><img src="https://s1.ax1x.com/2022/11/10/zSvgDU.png"></div>

<div align=center><img src="https://s1.ax1x.com/2022/11/10/zSv2bF.png"></div>

<div align=center><img src="https://s1.ax1x.com/2022/11/10/zSvWE4.png"></div>

## 项目开发

#### 开发步骤一：C# Winform 制作 APP 的壳

大致分为以下三个步骤（详情点击）：

- 初建框架
- 扩展菜单与显示
- 优化与打包

#### 开发步骤二：Nginx 流媒体服务器存储视频

大致分为以下三个步骤（整体介绍点击）：

- 安装 Nginx（其本身就提供了视频流传输和播放功能）
- 配置 Nginx，使得 8081 端口提供视频文件的 HTTP 服务（1935 端口提供 RTMP 推流）
- 使用 VLC 连接 .m3u8 格式的视频文件

## 最后

**这里我也提供给大家两个用于开放测试的 URL**

```
# 注意 .m3u8 格式视频只能用 Safari 浏览器或 Webkit 内核打开，或者用 VLC 取流播放
http://114.115.254.164:8081/test.mp4
http://114.115.254.164:8081/test/test.m3u8
```

PS：本项目非常感谢业界大佬无私的技术开源！！