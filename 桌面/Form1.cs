//using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using uart.桌面;
using uart.用户类;
using static uart.用户类.GPSRevieveData;

namespace uart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChart();
            mapInit();
            serialPortInit();
            /********************************************/
            /******************************************/
            /******************************************/
            mapUpdate();
            timer1.Interval = 1000;//1秒
            timer1.Enabled = false;
            dateTime.Value = DateTime.Now;
            /**********************************/
        }
/******************************************************************************************/
        private KeyEventHandler myKeyEventHandeler = null;//按键钩子
        private KeyboardHook k_hook = new KeyboardHook();
        int mapCount = 0;
        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 37: map[mapCount++] = 1; break;// 左
                case 38: map[mapCount++] = 2; break;// 上
                case 39: map[mapCount++] = 3; break;// 右
                case 40: map[mapCount++] = 4; break;// 下
                default: break;
            }
        }
        private void startListen()
        {
            myKeyEventHandeler = new KeyEventHandler(hook_KeyDown);
            k_hook.KeyDownEvent += myKeyEventHandeler;//钩住键按下
            k_hook.Start();//安装键盘钩子
        }
/*********************************************************************************/
/******************************************************************************************/
        static MysqlConnector mysqlC = new MysqlConnector();
        int  id=1 ;
        //数据库操作
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (scientificname.Text.Length == 0)
            {
                MessageBox.Show("请先输入作物名称");
                scientificname.Text = null;
            }
            else
            {
                MyDbRead myDbRead = new MyDbRead();
                string searchCommand = "SELECT *FROM detail WHERE name='" + scientificname.Text.ToString() + "'";    
                try
                {
                    myDbRead.mydbread(searchCommand);
                    //数据处理显示
                    nigtemp.Text = myDbRead.Nt.ToString();
                    daytemp.Text = myDbRead.Dt.ToString();
                    nurhumi.Text = myDbRead.Nh.ToString();
                    mathumi.Text = myDbRead.Mh.ToString();
                    id = myDbRead.Id;
                    detail.Text = myDbRead.Introduce;
                    //照片读取
                    string startupPath = Application.StartupPath;
                    startupPath += "\\cropImage\\"+ myDbRead.Id.ToString()+ ".jpg";
                    pictureBox1.Image = Image.FromFile(startupPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch { MessageBox.Show("无数据"); pictureBox1.Image = null; }
            }
        }
/*****************************************************************************************/
/**************************************************************************************************************************************/
        //Test     

        private int Settime=2;
        bool goflag = false;
        private void Receive_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Interval = 3000;
                timer.Start();
                if (amount.Text != "")
                {
                    Settime = int.Parse(amount.Text.ToString());
                    timer.Interval = Settime * 1000;
                }
                timer.Enabled = true;
            }
            catch (Exception)
            { MessageBox.Show("设备连接异常"); }
        }
        public delegate void MyInvoke(float temp);
        float yTemp;
        float yHumi;
        //int count = 0;
        private void TempHumiRead()
        {
            if (goflag==false) { goflag = true; }
            else {
                byte[] data = new byte[1];
                byte[] buffer = new byte[4];
                data[0] = 5;
                serialPort.DiscardOutBuffer();
                serialPort.Write(data, 0, 1);
                serialPort.Read(buffer, 0, 4);
                string h = buffer[0].ToString()+"."+ buffer[1].ToString();
                string t = buffer[2].ToString() + "." + buffer[3].ToString();
                yHumi = Convert.ToSingle(h);
                yTemp = Convert.ToSingle(t);
                if (yTemp < 50.0)
                {
                    string insertCommand = "INSERT INTO data(Id, Time, DataType, Data) VALUES("+ id + ", '" + DateTime.Now.ToString() + "', 1, " + yTemp + ")";
                    mysqlC.ExeUpdate(insertCommand);/*
                    if (yTemp > 30) { MessageBox.Show("高温预警，请注意", "当前温度:" + yTemp + "℃"); }
                    else if (yTemp < 5) { MessageBox.Show("低温预警，请注意", "当前温度:" + yTemp + "℃"); }*/
                    MyInvoke TInvoke = new MyInvoke(SetTPoint);
                    BeginInvoke(TInvoke, yTemp );
                }
                if (yHumi >0.0)
                {
                    string insertCommand = "INSERT INTO data(Id, Time, DataType, Data) VALUES("+id+", '" + DateTime.Now.AddSeconds(2).ToString() + "', 2, " + yHumi + ")";
                    mysqlC.ExeUpdate(insertCommand);/*
                    if (yHumi > 80) { MessageBox.Show("湿度预警，请注意", "当前湿度:" + yHumi + "%"); }
                    else if (yHumi < 40) { MessageBox.Show("湿度预警，请注意", "当前湿度:" + yHumi + "%"); }*/
                    MyInvoke HInvoke = new MyInvoke(SetHPoint);
                    BeginInvoke(HInvoke, yHumi );
                }
            }
        }
        private void SetTPoint(float Data)
        {
            series1.Points.AddXY(DateTime.Now.ToString("T"), Data);
        }
        private void SetHPoint(float Data)
        {
            series2.Points.AddXY(DateTime.Now.ToString("T"), Data);
        }
        /****************************************************************************************************/
        DateTime setTime ;
       // Boolean timeFlag = false;
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setTime = dateTime.Value;
            timer1.Enabled = true;
        }
        /*********************************************************************************************************/
        double[] xy = new double[2]; //{ latitude , longitude };
        private void mapInit()
        {
            try
            {
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "BdMap.html"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
/********************************************************************************************************/
        Series series1=new Series("温度");//温度
        Series series2=new Series("湿度");//湿度
        private void InitChart()
        {
            tempe.Series.Clear();
            //定义图表区域
            series1.Color = Color.Red;
            series1.ChartType = SeriesChartType.Spline;
            //series1.Points.AddXY(0,0);
            tempe.Series.Add(series1);
            /**********************************************************************************************/
            //定义图表区域
            humi.Series.Clear();
            series2.Color = Color.Blue;
            series2.ChartType = SeriesChartType.Column;
            //series2.Points.AddXY(0, 0);
            humi.Series.Add(series2);
        }
/*******************************************************************************************************/
        public static SerialPort serialPort = new SerialPort();
        string port = "COM1";
        public void serialPortInit()//默认串口配置
        {
            serialPort.BaudRate = 115200;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.PortName = port;
            serialPort.ReadTimeout =10000;
            serialPort.ReadBufferSize = 256;
        }
        bool onsp = true;
        bool openComeFlag = false;
        private void connectport_Click(object sender, EventArgs e)
        {
            port = cboPort.SelectedItem.ToString();
            try
            {
                if (port != null)
                {
                    if (onsp == true)
                    {
                        if (!serialPort.IsOpen)
                        {
                            serialPort.PortName = port;
                            serialPort.Open();
                            if (serialPort.IsOpen)
                            {
                                openComeFlag = true;
                                MessageBox.Show("串口已打开");//清空提示文本
                                connectport.Text = "关闭串口";
                                Receive2.Enabled = true;
                                Receive.Enabled = true;
                                onsp = false;
                            }
                        }
                        else
                        {
                            if (openComeFlag == false) MessageBox.Show("串口被占用");
                            else MessageBox.Show("串口已打开");
                        }
                    }
                    else
                    {
                        serialPort.Close();
                        serialPort.Dispose();
                        MessageBox.Show("串口已关闭");
                        onsp = true;
                        connectport.Text = "打开串口";
                    }
                }
            }
            catch (Exception) { MessageBox.Show("设备连接异常"); }
        }
        private void readport_Click_1(object sender, EventArgs e)
        {
            cboPort.Items.Clear();
            string[] ArrayPort = SerialPort.GetPortNames();
            for (int i = 0; i < ArrayPort.Length; i++)
            {
                cboPort.Items.Add(ArrayPort[i]);
            }
        }
        private void scientificname_TextChanged(object sender, EventArgs e)
        {
            Search.Enabled = true;
        }
        public static byte[] itob(int[] intarr)
        {
            int bytelength = intarr.Length * 4;//长度  
            byte[] bt = new byte[bytelength];//开辟数组  
            int curint = 0;
            for (int j = 0, k = 0; j < intarr.Length; j++, k += 4)
            {
                curint = intarr[j];
                bt[k] = (byte)((curint >> 24) & 0b1111_1111);//右移4位，与1作与运算  
                bt[k + 1] = (byte)((curint >> 16) & 0b1111_1111);
                bt[k + 2] = (byte)((curint >> 8) & 0b1111_1111);
                bt[k + 3] = (byte)((curint >> 0) & 0b1111_1111);
            }


            return bt;
        }
        private void send_Map()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    byte[] send = new byte[]{ 1,1,2,2,2,3,3,2,2,2,3,3,4,4,3,3,4,4,3,3,4,4,4,3 };
                    //send = itob(map);
                    for (int i = 0; i < send.Length; i++)
                    {
                        serialPort.Write(send, i, i + 1);
                        //webBrowser1.Document.InvokeScript("setLocation", new object[] { xy[0], xy[1] });
                        Thread.Sleep(5000);
                    }
                }
                else { MessageBox.Show("请先连接设备"); }
            }
            catch (Exception)
            {
                MessageBox.Show("发送异常");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            send_Map();
        }
        Boolean gpsFlag = true;
        Boolean gpsOpenFlag = false;
        private void Receive2_Click(object sender, EventArgs e)
        {
            byte[] gps = new byte[1];
            if (gpsFlag == true)
            {
                gps[0] = 6;
                serialPort.Write(gps, 0, 1);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                gpsOpenFlag = true;
                gpsFlag = false;
                Receive2.Text = "关闭";
            }
            else
            {
                gps[0] = 7;
                serialPort.Write(gps, 0, 1);
                Receive2.Text = "定位";
                if (gpsOpenFlag == true) { gpsFlag = true; }
            }
            }
        //private  static  GpsTranslation;
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strRecv;
            string[] strGPS;
            strRecv = serialPort.ReadLine();
            int index = strRecv.IndexOf('$');
            if (index == -1) {return; }
            else  strRecv.Remove(0, index);
            strGPS = strRecv.Replace('*', ',').Split(',');
            GpsProcess gpsProcess = new GpsProcess();
            switch (strGPS[0])
            {
                case "$GPGGA": {//GPS定位信息 
                        if (strGPS.Length < 13){  return;   }
                        GPGGA gpgga = new GPGGA();
                        gpsProcess.ReadGPGGA(strGPS, gpgga);    
                        BeginInvoke(new MethodInvoker(delegate () 
                        {
                            gpsProcess.WriteGPGGA(gpgga);
                            xy=GpsTranslation.wgs2bd(gpsProcess.Latitude, gpsProcess.Longitude);
                            Jd.Text = "经度：" + xy[0].ToString();//lon
                            Wd.Text = "纬度：" + xy[1].ToString();//lat
                        }));
                        break;
                    }
                case "$GPVTG": {//地面速度信息
                        if (strGPS.Length < 10){return; }
                        GPVTG gpvtg = new GPVTG();
                        gpsProcess.ReadGPVTG(strGPS, gpvtg);
                        BeginInvoke(new MethodInvoker(delegate () { speed.Text="速度："+gpsProcess.WriteGPVTG(gpvtg); }));
                        break;
                    }
                default: break;
            }
        }

        private void logindb_Click(object sender, EventArgs e)
        {
            MyDatabase  dbManager= new MyDatabase();
            dbManager.ShowDialog();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            DataChart_Analysis dataChart_Analysis = new DataChart_Analysis();
            dataChart_Analysis.ShowDialog();
        }

        private void goGrowMemery_Click(object sender, EventArgs e)
        {
            GrowMemary growMemary = new GrowMemary();
            growMemary.ShowDialog();
        }
        private void goMapDraw_Click(object sender, EventArgs e)
        {
            mapDraw.ShowDialog();
        }
        MapDraw mapDraw = new MapDraw();
        /*******************************************************************/
        private void mapUpdate() {
            string searchCommand = "select name from map ";
            MySqlDataReader reader = mysqlC.ExeQuery(searchCommand);
            BindingSource bs = new BindingSource
            {
                DataSource = reader
            };
            dataGridView2.DataSource = bs;
        }
        string Mapname;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mapname = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show(Mapname);
        }
        /*******************************路径绑定******************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            //数据库查询路径
            map= mapDraw.readMemory(Mapname);
            /*********串口发送路径数组****/
        }
        int[] map = new int[100];//路径设置
        private void button3_Click(object sender, EventArgs e)//开始录制
        {
            startListen();
        }
        private void button4_Click(object sender, EventArgs e)//结束录制
        {
            mapCount = 0;
            mapDraw.Show();
            mapDraw.DrawCurve(map);
            mapDraw.Curvebuf = map;
        }
        Boolean flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int min = 0;
            int hou = 0;
            int sec = 0;
            DateTime clock=DateTime.Now;
            TimeSpan ts = setTime - clock;
            min = ts.Minutes;
            hou = ts.Hours;
            sec = ts.Seconds;
            if (flag == true)
            {
                if ((min == 0) && (hou == 0) && (sec == 0)) {
                    MessageBox.Show("到达工作时间，开始工作");
                    flag = false;
                    send_Map();
                }
            }
            else flag = true;
            time.Text = hou.ToString() + " 时 "+min.ToString()+" 分 " + sec.ToString() + " 秒 ";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TempHumiRead();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pot pot = new Pot();
            pot.ShowDialog();
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tempe_Click(object sender, EventArgs e)
        {

        }
    }
}


