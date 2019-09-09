using System;

namespace uart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Send = new System.Windows.Forms.Button();
            this.Receive = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daytemp = new System.Windows.Forms.TextBox();
            this.nurhumi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nigtemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mathumi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.scientificname = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.connectport = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ListBox();
            this.readport = new System.Windows.Forms.Button();
            this.tempe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.humi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Receive2 = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.RichTextBox();
            this.logindb = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goGrowMemery = new System.Windows.Forms.Button();
            this.goMapDraw = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.work = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Wd = new System.Windows.Forms.Label();
            this.Jd = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.White;
            this.Send.BackgroundImage = global::uart.Properties.Resources.button;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send.ForeColor = System.Drawing.Color.White;
            this.Send.Location = new System.Drawing.Point(713, 798);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(123, 31);
            this.Send.TabIndex = 0;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Receive
            // 
            this.Receive.BackColor = System.Drawing.Color.White;
            this.Receive.BackgroundImage = global::uart.Properties.Resources.button;
            this.Receive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Receive.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Receive.ForeColor = System.Drawing.Color.White;
            this.Receive.Location = new System.Drawing.Point(228, 143);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(71, 40);
            this.Receive.TabIndex = 1;
            this.Receive.Text = "读取";
            this.Receive.UseVisualStyleBackColor = false;
            this.Receive.Click += new System.EventHandler(this.Receive_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.BackgroundImage = global::uart.Properties.Resources.button;
            this.Search.Enabled = false;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(705, 109);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(140, 40);
            this.Search.TabIndex = 4;
            this.Search.Text = "绑定";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(501, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // daytemp
            // 
            this.daytemp.BackColor = System.Drawing.Color.White;
            this.daytemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daytemp.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daytemp.Location = new System.Drawing.Point(691, 280);
            this.daytemp.Name = "daytemp";
            this.daytemp.Size = new System.Drawing.Size(55, 26);
            this.daytemp.TabIndex = 8;
            // 
            // nurhumi
            // 
            this.nurhumi.BackColor = System.Drawing.Color.White;
            this.nurhumi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nurhumi.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nurhumi.Location = new System.Drawing.Point(690, 327);
            this.nurhumi.Name = "nurhumi";
            this.nurhumi.Size = new System.Drawing.Size(55, 26);
            this.nurhumi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(512, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "白天最适温度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(512, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "育苗期最适湿度:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(512, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "夜晚最适温度:";
            // 
            // nigtemp
            // 
            this.nigtemp.BackColor = System.Drawing.Color.White;
            this.nigtemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nigtemp.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nigtemp.Location = new System.Drawing.Point(691, 245);
            this.nigtemp.Name = "nigtemp";
            this.nigtemp.Size = new System.Drawing.Size(55, 26);
            this.nigtemp.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(512, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "成熟期最适湿度:";
            // 
            // mathumi
            // 
            this.mathumi.BackColor = System.Drawing.Color.White;
            this.mathumi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mathumi.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mathumi.Location = new System.Drawing.Point(691, 362);
            this.mathumi.Name = "mathumi";
            this.mathumi.Size = new System.Drawing.Size(55, 26);
            this.mathumi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(757, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "℃";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(757, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "℃";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(756, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "%相对湿度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(756, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "%相对湿度";
            // 
            // scientificname
            // 
            this.scientificname.BackColor = System.Drawing.Color.White;
            this.scientificname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scientificname.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scientificname.Location = new System.Drawing.Point(691, 192);
            this.scientificname.Name = "scientificname";
            this.scientificname.Size = new System.Drawing.Size(169, 30);
            this.scientificname.TabIndex = 21;
            this.scientificname.TextChanged += new System.EventHandler(this.scientificname_TextChanged);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.SystemColors.Window;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amount.Location = new System.Drawing.Point(141, 195);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(94, 26);
            this.amount.TabIndex = 30;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(512, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 19);
            this.label17.TabIndex = 32;
            this.label17.Text = "作物信息:";
            // 
            // dateTime
            // 
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTime.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(618, 641);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(238, 26);
            this.dateTime.TabIndex = 34;
            this.dateTime.Value = new System.DateTime(2017, 5, 6, 0, 0, 0, 0);
            this.dateTime.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // connectport
            // 
            this.connectport.BackColor = System.Drawing.Color.White;
            this.connectport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectport.BackgroundImage")));
            this.connectport.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectport.ForeColor = System.Drawing.Color.White;
            this.connectport.Location = new System.Drawing.Point(228, 87);
            this.connectport.Name = "connectport";
            this.connectport.Size = new System.Drawing.Size(140, 40);
            this.connectport.TabIndex = 39;
            this.connectport.Text = "打开串口";
            this.connectport.UseVisualStyleBackColor = false;
            this.connectport.Click += new System.EventHandler(this.connectport_Click);
            // 
            // cboPort
            // 
            this.cboPort.BackColor = System.Drawing.Color.White;
            this.cboPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboPort.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPort.FormattingEnabled = true;
            this.cboPort.ItemHeight = 16;
            this.cboPort.Location = new System.Drawing.Point(45, 35);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(150, 146);
            this.cboPort.TabIndex = 41;
            // 
            // readport
            // 
            this.readport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.readport.BackColor = System.Drawing.Color.White;
            this.readport.BackgroundImage = global::uart.Properties.Resources.button;
            this.readport.Cursor = System.Windows.Forms.Cursors.Default;
            this.readport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readport.ForeColor = System.Drawing.Color.White;
            this.readport.Image = ((System.Drawing.Image)(resources.GetObject("readport.Image")));
            this.readport.Location = new System.Drawing.Point(228, 32);
            this.readport.Name = "readport";
            this.readport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.readport.Size = new System.Drawing.Size(140, 40);
            this.readport.TabIndex = 42;
            this.readport.Text = "读取端口";
            this.readport.UseVisualStyleBackColor = false;
            this.readport.Click += new System.EventHandler(this.readport_Click_1);
            // 
            // tempe
            // 
            chartArea1.Name = "ChartArea1";
            this.tempe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempe.Legends.Add(legend1);
            this.tempe.Location = new System.Drawing.Point(45, 237);
            this.tempe.Margin = new System.Windows.Forms.Padding(5);
            this.tempe.Name = "tempe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.tempe.Series.Add(series1);
            this.tempe.Size = new System.Drawing.Size(400, 250);
            this.tempe.TabIndex = 51;
            this.tempe.Click += new System.EventHandler(this.tempe_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(896, -3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(685, 883);
            this.webBrowser1.TabIndex = 52;
            // 
            // humi
            // 
            chartArea2.Name = "ChartArea1";
            this.humi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.humi.Legends.Add(legend2);
            this.humi.Location = new System.Drawing.Point(45, 519);
            this.humi.Name = "humi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.humi.Series.Add(series2);
            this.humi.Size = new System.Drawing.Size(400, 250);
            this.humi.TabIndex = 53;
            // 
            // Receive2
            // 
            this.Receive2.BackColor = System.Drawing.Color.White;
            this.Receive2.BackgroundImage = global::uart.Properties.Resources.button;
            this.Receive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Receive2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Receive2.ForeColor = System.Drawing.Color.White;
            this.Receive2.Location = new System.Drawing.Point(296, 143);
            this.Receive2.Name = "Receive2";
            this.Receive2.Size = new System.Drawing.Size(72, 40);
            this.Receive2.TabIndex = 55;
            this.Receive2.Text = "定位";
            this.Receive2.UseVisualStyleBackColor = false;
            this.Receive2.Click += new System.EventHandler(this.Receive2_Click);
            // 
            // detail
            // 
            this.detail.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detail.Location = new System.Drawing.Point(509, 442);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(351, 192);
            this.detail.TabIndex = 56;
            this.detail.Text = "";
            // 
            // logindb
            // 
            this.logindb.BackColor = System.Drawing.Color.White;
            this.logindb.BackgroundImage = global::uart.Properties.Resources.button;
            this.logindb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logindb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logindb.ForeColor = System.Drawing.Color.White;
            this.logindb.Location = new System.Drawing.Point(689, 32);
            this.logindb.Name = "logindb";
            this.logindb.Size = new System.Drawing.Size(172, 37);
            this.logindb.TabIndex = 57;
            this.logindb.Text = "数据库管理";
            this.logindb.UseVisualStyleBackColor = false;
            this.logindb.Click += new System.EventHandler(this.logindb_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(241, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "秒";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(42, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "定时采集：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(513, 645);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "定时工作:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::uart.Properties.Resources.button;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(533, 836);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 61;
            this.button1.Text = "数据分析";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // goGrowMemery
            // 
            this.goGrowMemery.BackColor = System.Drawing.Color.White;
            this.goGrowMemery.BackgroundImage = global::uart.Properties.Resources.button;
            this.goGrowMemery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGrowMemery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goGrowMemery.ForeColor = System.Drawing.Color.White;
            this.goGrowMemery.Location = new System.Drawing.Point(712, 835);
            this.goGrowMemery.Name = "goGrowMemery";
            this.goGrowMemery.Size = new System.Drawing.Size(123, 34);
            this.goGrowMemery.TabIndex = 62;
            this.goGrowMemery.Text = "种植记录";
            this.goGrowMemery.UseVisualStyleBackColor = false;
            this.goGrowMemery.Click += new System.EventHandler(this.goGrowMemery_Click);
            // 
            // goMapDraw
            // 
            this.goMapDraw.BackColor = System.Drawing.Color.White;
            this.goMapDraw.BackgroundImage = global::uart.Properties.Resources.button;
            this.goMapDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goMapDraw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goMapDraw.ForeColor = System.Drawing.Color.White;
            this.goMapDraw.Location = new System.Drawing.Point(534, 798);
            this.goMapDraw.Name = "goMapDraw";
            this.goMapDraw.Size = new System.Drawing.Size(122, 31);
            this.goMapDraw.TabIndex = 63;
            this.goMapDraw.Text = "路径查询";
            this.goMapDraw.UseVisualStyleBackColor = false;
            this.goMapDraw.Click += new System.EventHandler(this.goMapDraw_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(159, 798);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(170, 82);
            this.dataGridView2.TabIndex = 64;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::uart.Properties.Resources.button;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(57, 842);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 65;
            this.button2.Text = "路径绑定";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::uart.Properties.Resources.button;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(335, 807);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 27);
            this.button3.TabIndex = 66;
            this.button3.Text = "开始";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::uart.Properties.Resources.button;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(335, 842);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 27);
            this.button4.TabIndex = 67;
            this.button4.Text = "结束";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(340, 778);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "路径录入";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(660, 683);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(60, 19);
            this.time.TabIndex = 69;
            this.time.Text = "时间:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // work
            // 
            this.work.AutoSize = true;
            this.work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.work.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.work.Location = new System.Drawing.Point(512, 724);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(0, 19);
            this.work.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(53, 810);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 71;
            this.label13.Text = "路径选择";
            // 
            // Wd
            // 
            this.Wd.AutoSize = true;
            this.Wd.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wd.ForeColor = System.Drawing.Color.Red;
            this.Wd.Location = new System.Drawing.Point(913, 755);
            this.Wd.Name = "Wd";
            this.Wd.Size = new System.Drawing.Size(56, 16);
            this.Wd.TabIndex = 72;
            this.Wd.Text = "纬度：";
            // 
            // Jd
            // 
            this.Jd.AutoSize = true;
            this.Jd.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Jd.ForeColor = System.Drawing.Color.Red;
            this.Jd.Location = new System.Drawing.Point(913, 787);
            this.Jd.Name = "Jd";
            this.Jd.Size = new System.Drawing.Size(56, 16);
            this.Jd.TabIndex = 73;
            this.Jd.Text = "经度：";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speed.ForeColor = System.Drawing.Color.Red;
            this.speed.Location = new System.Drawing.Point(913, 822);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(56, 16);
            this.speed.TabIndex = 74;
            this.speed.Text = "速度：";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::uart.Properties.Resources.button;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(533, 748);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 31);
            this.button5.TabIndex = 75;
            this.button5.Text = "浇灌量";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::uart.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 881);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.Jd);
            this.Controls.Add(this.Wd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.work);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.goMapDraw);
            this.Controls.Add(this.goGrowMemery);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.logindb);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.Receive2);
            this.Controls.Add(this.humi);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tempe);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.readport);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.connectport);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.scientificname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mathumi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nigtemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nurhumi);
            this.Controls.Add(this.daytemp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.Send);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1600, 920);
            this.MinimumSize = new System.Drawing.Size(1600, 920);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "蚁后控制系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Receive;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox daytemp;
        private System.Windows.Forms.TextBox nurhumi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nigtemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mathumi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox scientificname;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button connectport;
        private System.Windows.Forms.ListBox cboPort;
        private System.Windows.Forms.Button readport;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataVisualization.Charting.Chart humi;
        private System.Windows.Forms.Button Receive2;
        private System.Windows.Forms.RichTextBox detail;
        private System.Windows.Forms.Button logindb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goGrowMemery;
        private System.Windows.Forms.Button goMapDraw;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label work;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Wd;
        private System.Windows.Forms.Label Jd;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button5;
    }
}

