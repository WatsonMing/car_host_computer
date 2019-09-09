using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace uart.桌面
{
    public partial class MapDraw : Form
    {
        public MapDraw()
        {
            InitializeComponent();
            //DrawCurve(Curvebuf);      
        }
        private int height = 620;
        private int width = 620;
        private Bitmap bitmap;
        private Graphics graphics;
        int[] curvebuf = new int[100]; //{1,1,2,2,2,3,3,2,2,2,3,3,4,4,3,3,4,4,3,3,4,4,4,3 };
        public int[] Curvebuf { get => curvebuf; set => curvebuf = value; }

        private void DrawInit() {
            //创建位图
            bitmap = new Bitmap(width, height);
            //创建Graphics类对象
            graphics = Graphics.FromImage(bitmap);
            //清空图片背景色
            //graphics.Clear(Color.White);
            Font font = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            //填充背景
            graphics.FillRectangle(Brushes.CadetBlue, 0, 0, width, height);
           // Brush brush1 = new SolidBrush(Color.Blue);
           // Brush brush2 = new SolidBrush(Color.SaddleBrown);         
            Pen mypenBlue = new Pen(Color.Blue, 1);//线条             
            //绘制线条
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                graphics.DrawLine(mypenBlue, x, 0, x, 600); //绘制纵向线条
                graphics.DrawLine(mypenBlue, 0, x, 600, x);//绘制横向线条
                x = x + 30;
            }
            //x轴上对应的标记
            String[] n = { " 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", " 10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
            x = 0;
            for (int i = 0; i < 20; i++)
            {
                graphics.DrawString(n[i].ToString(), font, Brushes.Red, x, 600); //设置文字内容及输出位置
                x += 30;
            }
            x = 0;
            //y轴上对应的标记
            for (int i = 19; i >= 0; i--)
            {
                graphics.DrawString(n[i].ToString(), font, Brushes.Red, 600, x); //设置文字内容及输出位置
                x += 30;
            }
            /************************************************************************************************************/
        }
        public void DrawCurve(int[] buf)
        {
            /***************************************************************************/
            //Brush brushPoint = new SolidBrush(Color.Red);
            //Pen mypenYellow = new Pen(Color.Yellow, 1);//点颜色
            //DrawInit();
            //画曲线
            int len = buf.Length;
            PointF[] CurvePointF = new PointF[len];//坐标点
            /**********************
                1; break;// 左x--
                2; break;// 上y--
                3; break;// 右x++
                4; break;// 下y++
            ***********************/
            int pointX = 300;int pointY = 500;
            int NewpointX=0; int NewpointY=0;
            for (int i = 0; i < len; i++)
            {
                switch (buf[i])
                {
                    case 1:
                        NewpointX = pointX - 30;
                        drawmap(pointX, pointY, NewpointX, pointY) ;
                        pointX = NewpointX;
                        break;
                    case 2:
                        NewpointY = pointY - 30;
                        drawmap(pointX, pointY, pointX, NewpointY);
                        pointY = NewpointY;
                        break;  
                    case 3:
                        NewpointX = pointX + 30;
                        drawmap(pointX, pointY, NewpointX, pointY);
                        pointX = NewpointX;
                        break;
                    case 4:
                        NewpointY = pointY + 30;
                        drawmap(pointX, pointY, pointX, NewpointY);
                        pointY = NewpointY;
                        break;
                    default:break;
                }      
            }
            graphics.Dispose();
            pictureBox1.Image = bitmap;
        }
        private void drawmap(int pointX,int pointY,int NewpointX,int NewpointY) {
            Pen mypenRed = new Pen(Color.Red, 2);
            graphics.DrawLine(mypenRed, pointX, pointY, NewpointX, NewpointY); //绘制纵向线条
        }
        private void momeryMap(int[] buf)
        {
            MysqlConnector mysqlC = new MysqlConnector();
            string searchCommand = "SELECT id FROM detail WHERE name='" + name.Text.ToString() + "'";   
            int id=1;
            if (name.Text != "") {
                MySqlDataReader reader = mysqlC.ExeQuery(searchCommand);
                if (reader.Read()) id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            else { MessageBox.Show("请增加输入", "操作提示"); }
            //MessageBox.Show(id.ToString());
            /********************************************************************/
            string[] strs = Array.ConvertAll(buf, delegate (int input) { return input.ToString(); });
            string result = string.Join(";", strs);
            //MessageBox.Show(result);
            
            string insertCommand = "INSERT INTO map (myPath,id,name)VALUES( '" + result + "','" + id.ToString() + "','" + memoryName.Text.ToString() + "')";
            if (memoryName.Text != "")
            {
                mysqlC.ExeUpdate(insertCommand);
                MessageBox.Show("增加成功", "操作提示");
            }
            else { MessageBox.Show("请增加输入", "操作提示"); }
            Console.WriteLine(insertCommand);
        }
        private void memory_Click(object sender, EventArgs e)
        {
            momeryMap(Curvebuf);
            //DrawCurve(Curvebuf);
            //readMemory();
        }
        public int[] readMemory(string name) {
            MysqlConnector mysqlC = new MysqlConnector();
            string searchCommand = "SELECT myPath FROM map WHERE name='"+ name +"'";
            MySqlDataReader reader = mysqlC.ExeQuery(searchCommand);
            string str = "";
            try
            {
                if (reader.Read()) { str = reader.GetString(reader.GetOrdinal("myPath")); }
            }
            catch { }
            string[] strArr = str.Split(';');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(strArr[i]);
            }
            return intArr;
        }

        private void MapDraw_Load(object sender, EventArgs e)
        {
            DrawInit();
        }

        private void select_Click(object sender, EventArgs e)
        {
            DrawCurve(readMemory(name.Text.ToString()));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            memoryName.Text = "";
            DrawInit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
