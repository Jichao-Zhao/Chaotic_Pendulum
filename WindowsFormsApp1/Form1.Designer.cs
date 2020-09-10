namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我们CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者信息WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_rec = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_scan = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_com = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(163, 128);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(636, 365);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.Chart1_Click);
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(807, 27);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.另存为ToolStripMenuItem.Text = "另存为(&Ctrl+S)";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.退出ToolStripMenuItem.Text = "退出(&E)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除DToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.剪切ToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.复制ToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.粘贴ToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大ToolStripMenuItem,
            this.sToolStripMenuItem,
            this.全屏AToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.视图ToolStripMenuItem.Text = "视图(&V)";
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.放大ToolStripMenuItem.Text = "放大(&L)";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.sToolStripMenuItem.Text = "缩小(&S)";
            // 
            // 全屏AToolStripMenuItem
            // 
            this.全屏AToolStripMenuItem.Name = "全屏AToolStripMenuItem";
            this.全屏AToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.全屏AToolStripMenuItem.Text = "全屏(&A)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.联系我们CToolStripMenuItem,
            this.作者信息WToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 联系我们CToolStripMenuItem
            // 
            this.联系我们CToolStripMenuItem.Name = "联系我们CToolStripMenuItem";
            this.联系我们CToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.联系我们CToolStripMenuItem.Text = "联系我们(&C)";
            this.联系我们CToolStripMenuItem.Click += new System.EventHandler(this.联系我们CToolStripMenuItem_Click);
            // 
            // 作者信息WToolStripMenuItem
            // 
            this.作者信息WToolStripMenuItem.Name = "作者信息WToolStripMenuItem";
            this.作者信息WToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.作者信息WToolStripMenuItem.Text = "作者信息(&W)";
            this.作者信息WToolStripMenuItem.Click += new System.EventHandler(this.作者信息WToolStripMenuItem_Click);
            // 
            // textBox_rec
            // 
            this.textBox_rec.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox_rec.Location = new System.Drawing.Point(19, 148);
            this.textBox_rec.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rec.Multiline = true;
            this.textBox_rec.Name = "textBox_rec";
            this.textBox_rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_rec.Size = new System.Drawing.Size(163, 325);
            this.textBox_rec.TabIndex = 8;
            this.textBox_rec.TextChanged += new System.EventHandler(this.textBox_rec_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_scan,
            this.toolStripLabel2,
            this.toolStripComboBox_com,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 101);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_scan
            // 
            this.toolStripButton_scan.AutoSize = false;
            this.toolStripButton_scan.Image = global::WindowsFormsApp1.Properties.Resources.search_engine_64px_1206055_easyicon_net;
            this.toolStripButton_scan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_scan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_scan.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton_scan.Name = "toolStripButton_scan";
            this.toolStripButton_scan.Size = new System.Drawing.Size(68, 91);
            this.toolStripButton_scan.Text = "扫描";
            this.toolStripButton_scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_scan.Click += new System.EventHandler(this.toolStripButton_scan_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 98);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripComboBox_com
            // 
            this.toolStripComboBox_com.AutoToolTip = true;
            this.toolStripComboBox_com.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.toolStripComboBox_com.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripComboBox_com.Name = "toolStripComboBox_com";
            this.toolStripComboBox_com.Size = new System.Drawing.Size(109, 91);
            this.toolStripComboBox_com.Text = "请扫描端口";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 101);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WindowsFormsApp1.Properties.Resources.play_button_64px_1229008_easyicon_net;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 91);
            this.toolStripButton1.Text = "开始";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton2.Image = global::WindowsFormsApp1.Properties.Resources.pause_64px_1229007_easyicon_net;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 91);
            this.toolStripButton2.Text = "暂停";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::WindowsFormsApp1.Properties.Resources.cancel_64px_1228979_easyicon_net;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 91);
            this.toolStripButton3.Text = "清除";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 101);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoToolTip = true;
            this.toolStripButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripButton5.Size = new System.Drawing.Size(75, 25);
            this.toolStripButton5.Text = "请选择测量速度";
            this.toolStripButton5.ToolTipText = "请选择测量速度";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = global::WindowsFormsApp1.Properties.Resources.Save_as_64px_1186319_easyicon_net;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 91);
            this.toolStripButton4.Text = "保存";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 101);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_rec);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "混沌摆测量仪";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_rec;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系我们CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者信息WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全屏AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton_scan;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_com;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label1;
    }
}

