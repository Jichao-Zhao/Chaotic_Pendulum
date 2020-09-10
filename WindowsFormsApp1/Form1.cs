using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text_Setup();
            Button_Enable_Setup();
            Chart1_Setup();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            //toolStripComboBox_speed.Items.Add(1);
            for (int i = 10; i <= 100; i = i + 10)
            {
                //toolStripComboBox_speed.Items.Add(i);
                //toolStripComboBox_speed.Text = "采集频率(次/秒)";
            }

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);

        }

        private void Chart1_Setup()
        {
            //////////////////////ChartArea1属性设置//////////////////////
            //设置网格的颜色
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGray;
            //设置坐标轴名称
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "角度";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "角速度";
            //启用3D显示
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;

            Series series = chart1.Series[0];                       //设置图线的样式
            series.ChartType = SeriesChartType.FastLine;            //画样条曲线（Spliine）
            series.BorderWidth = 1;                                 //线宽 2 个像素
            series.Color = System.Drawing.Color.Red;                //线的颜色 红色
            series.LegendText = "角速度";                           //图示上的文字

            //设置显示范围包括横纵轴坐标的最大最小值
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 1000;
            chartArea.AxisY.Minimum = -50d;
            chartArea.AxisY.Maximum = 50d;

            //滚动条位于图表区内还是图表区外 是否使能滑动条
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled =false;

            chart1.ChartAreas[0].AxisX.ScaleView.Position = 0;      //指当前（最后边）显示的是第几个

            //视野范围内共有多少个数据点，动态折线图的关键就是根据量的不同增加这个变量
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 100;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)    //串口数据接收事件
        {
            try
            {
                string str = serialPort1.ReadLine();                    //读一行数据
                string[] sArray1 = str.Split('/')[0].Split(':');
                string[] sArray2 = str.Split('/')[1].Split(':');

                textBox_rec.AppendText(str);
                textBox_rec.AppendText("\r\n");                         //添加回车换行键

                Series series = chart1.Series[0];
                series.Points.AddXY(sArray2[1], sArray1[1]);                 //添加一个点

                //图像显示位置一直保持在X的值减去5的位置
                chart1.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 90;
            }
            catch
            {
                MessageBox.Show("端口开启失败，请重新打开软件","失败",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void Button_Enable_Setup()
        {
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled  = false;
            toolStripButton3.Enabled = false;
        }

        private void Text_Setup()                                   //设计所有的文字显示内容
        {

            toolStripComboBox_com.Text = "请扫描端口";   
            //toolStripComboBox_speed.Text = "请选择测量速度";
            //label_rad.Text = "角速度";
        }

        private void toolStripButton_scan_Click(object sender, EventArgs e)
        {
            string[] t = SerialPort.GetPortNames();         //得到端口名字并赋值到字符串数组t
            int cc = 0;
            if (cc != t.Length)                             //扫描到有新的端口名字
            {
                toolStripComboBox_com.Items.Clear();
            }
            cc = t.Length;                                  //取得端口号长度

            if (!serialPort1.IsOpen)                        //如果1号串口没有打开
            {
                foreach (string com in SerialPort.GetPortNames())
                {
                    if (toolStripComboBox_com.Items.Count < cc)
                        toolStripComboBox_com.Items.Add(com);
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_com_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                serialPort1.PortName = Convert.ToString(toolStripComboBox_com.Text);//采集串口名字(全为字符模式)
                serialPort1.BaudRate = 9600;                         //定义串口传输波特率
                serialPort1.Open();                                 //串口开始传输

                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled  = true;

                try                                                 //尝试判断采集速率已经选择
                {
                    //string a = toolStripComboBox_speed.Text;        //判断速度框的字符串是否为数字
                    //int b = int.Parse(a);                           //判断速度框的字符串是否为数字
                    serialPort1.WriteLine(Convert.ToString(0));     //发送字符串0，表示开始
                }
                catch
                {
                    serialPort1.Close();
                    toolStripButton1.Enabled = true;                         //打开串口按钮不可用
                    toolStripButton2.Enabled = false;                        //停止测量按钮可用
                    MessageBox.Show("请选择测量速度", "速度错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("端口选择错误，请检查端口","错误", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();                                    //串口传输关闭

            toolStripButton1.Enabled = true;                            //开始按钮可用
            toolStripButton3.Enabled = true;                            //清除按钮可用
        }
        
        // 清除按钮
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            textBox_rec.Clear();
            chart1.Series.Clear();
            //label_rec.Text = "0";                                       //清除光线强度数据
        }
        
        private void comboBox_speed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rec_TextChanged(object sender, EventArgs e)
        {
            textBox_rec.ScrollToCaret();                                   //讲滚动条调至最下
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label_rad_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_speed_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("www.imakerlab.cn", "主页");
        }

        private void 联系我们CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("478984342@qq.com", "邮箱");
        }

        private void 作者信息WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("安力群大学生创新实验室", "天津科技大学");
        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            //双击恢复滚动条
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 100;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        }
    }
}
