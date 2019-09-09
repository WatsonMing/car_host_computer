using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace uart
{
    public partial class DataChart_Analysis : Form
    {
        public DataChart_Analysis()
        {
            InitializeComponent();
            dataStop.Enabled = false;
            dataStart.Enabled = false;
        }
        DateTime startTime=DateTime.Now;
        DateTime stopTime = DateTime.Now;
        DateTime dt;
        private void dataStart_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.Now;//获取当前时间
            if (dataStart.Value > dt)
            {
                MessageBox.Show("不允许超过当前时间");
                dataStart.Value = dt;
            }
            else if (dataStart.Value < dt)
            {
                dataStop.Enabled = true;
                startTime = dataStart.Value;
              //  MessageBox.Show("起始时间为:"+ startTime.ToString());
            }
        }
        private void dataStop_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.Now;//获取当前时间
            if (dataStop.Value > dt)
            {
                MessageBox.Show("不允许超过当前时间");
                dataStop.Value = dt;
            }
            else if (dataStop.Value < dt)
            {
                if (dataStop.Value > startTime)
                {
                    stopTime = dataStop.Value;
                   // MessageBox.Show("结束时间为:" + stopTime.ToString());
                    dbSelect(growId);
                } else {
                    dataStop.Value = dt;
                    MessageBox.Show("请选择大于起始日期！");
                }
            }     
        }
        private void clean_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            stopTime = DateTime.Now;
            chart1.Series.Clear();
            chart2.Series.Clear();
        }
/**************************************************************************************************/
        MysqlConnector mysqlC = new MysqlConnector();
        /**温度数据**/
        int[] Data = new int[1000];
        DateTime[] time = new DateTime[1000];
        /**湿度数据**/
        int[] date2 = new int[1000];
        DateTime[] time2 = new DateTime[1000];
        private void dbSelect(int x)
        {
            string selectCommand = "select * from Data where time>='" + startTime + "' and time<='" + stopTime + "'and DataType=1 and id="+x+"";
            try
            {
                MySqlDataReader reader = mysqlC.ExeQuery(selectCommand);
                int i = 0;
                while (reader.Read())
                { 
                    Data[i] = reader.GetInt32(reader.GetOrdinal("Data"));//数据集
                    time[i] = reader.GetDateTime(reader.GetOrdinal("time"));//数据集
                    i++;
                }
                chartUpdate(i,1, Data, time);
            }
            catch { MessageBox.Show("数据库读取异常"); }
            /************************************************************************************************************/
            string selectCommand2 = "select * from Data where time>='" + startTime + "' and time<='" + stopTime + "'and DataType=2";
            try
            {
                MySqlDataReader reader2 = mysqlC.ExeQuery(selectCommand2);
                int j = 0;
                while (reader2.Read())
                {
                    date2[j] = reader2.GetInt32(reader2.GetOrdinal("Data"));//数据集
                    time2[j] = reader2.GetDateTime(reader2.GetOrdinal("time"));//数据集
                    j++;
                }
                chartUpdate(j,2, date2,time2);
            }
            catch { MessageBox.Show("数据库读取异常"); }
        }
        private void chartUpdate(int length,int type, int[] da,DateTime[] de) {
            DateTime dt = new DateTime();
            string typeName = "";
            if (type == 1){ chart1.Series.Clear(); typeName = "温度"; }
            else if (type == 2){ chart2.Series.Clear(); typeName = "湿度"; }
            /********************************************************************/
            Series TempStrength = new Series(typeName);
            TempStrength.Color = Color.Red;
            TempStrength.ChartType = SeriesChartType.Spline;
            for (int i =0; i < 1000; i++)
            {
                if (time[i] != dt){ TempStrength.Points.AddXY(de[i].ToString("T"), da[i]); }
            }
            /*************************************************************************************/
            int Avg = 0;
            for (int i = 0; i < length; i++) { Avg=Avg+ da[i]; }
            Avg = Avg / length;
            if(type==2) humi_Avg.Text = Avg.ToString();
            else if(type==1) temp_Avg.Text = Avg.ToString();
            //MessageBox.Show(Avg.ToString());
            Series AvgStrength = new Series("平均值");
            AvgStrength.Color = Color.Blue;
            AvgStrength.ChartType = SeriesChartType.Spline;
            for (int i = 0; i < length; i++){ AvgStrength.Points.AddY(Avg); }   
            /*******************************************************************************/
            if (type == 1) {  chart1.Series.Add(TempStrength); chart1.Series.Add(AvgStrength);  }
            else if (type == 2) {  chart2.Series.Add(TempStrength); chart2.Series.Add(AvgStrength); }
            //MessageBox.Show("已查询条数：" + pointnNum.ToString());
        }
        private void growSelect(int j) {
            string selectCommand = " select* from grow where id = "+j+" order by time";
            MySqlDataReader reader = mysqlC.ExeQuery(selectCommand);
            double[] lenghtDate = new double[1000];
            double[] widthDate = new double[1000];
            DateTime[] time = new DateTime[1000];
            chart3.Series.Clear();
            int growFlag=0;
            int i = 0;
            bool flag = false;
            Series growLengthStrength = new Series("长度");
            Series growWidthStrength = new Series("宽度");
            while (reader.Read())
            {
                widthDate[i] = reader.GetInt32(reader.GetOrdinal("width"));//数据集
                lenghtDate[i] = reader.GetInt32(reader.GetOrdinal("length"));//数据集
                time[i] = reader.GetDateTime(reader.GetOrdinal("time"));//数据集
                growWidthStrength.Points.AddXY(time[i].ToString("dd"), widthDate[i]);
                growLengthStrength.Points.AddXY(time[i].ToString("dd"), lenghtDate[i]);
                if (reader.GetString(reader.GetOrdinal("phase")) != "幼苗期") {
                    if (!flag) { growFlag = i; flag = true; }
                }
                i++;
            }
            nurseryText.Text += growFlag.ToString() + "天";
            maturityText.Text += (i - growFlag).ToString() + "天";
            /*********************************************************************/
            growWidthStrength.Color = Color.Blue;
            growWidthStrength.ChartType = SeriesChartType.Spline;
            chart3.Series.Add(growWidthStrength);

            growLengthStrength.Color = Color.Red;
            growLengthStrength.ChartType = SeriesChartType.Spline;
            chart3.Series.Add(growLengthStrength);
        }
        int growId = 1;
        private void search_Click(object sender, EventArgs e)
        {
            string searchCommand = "SELECT *FROM detail WHERE name='" + strname.Text.ToString() + "'";
            MyDbRead myDbRead = new MyDbRead();
            try
            {
                myDbRead.mydbread(searchCommand);
                //数据处理显示
                myDbRead.Nt.ToString();
                myDbRead.Dt.ToString();
                myDbRead.Nh.ToString();
                myDbRead.Mh.ToString();
                growId = myDbRead.Id;
                //MessageBox.Show(i.ToString());
                growSelect(growId);
                dataStart.Enabled = true;
            }
            catch {
                MessageBox.Show("查询无数据");
            }
        }

        private void DataChart_Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
