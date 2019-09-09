using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace uart
{
    class BaiduApi
    {
        public double Longitude;
        public double Latitude;
        public void GetBaiducoor(double longitude, double latitude)//坐标转换的方法
        {
            try { 
            //需要转的gps经纬度
            string convertUrl = "http://api.map.baidu.com/ag/coord/convert?from=0&to=4&x=" + longitude + "&y=" + latitude + "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(convertUrl);//创建http请求
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
            string responseTxt = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();

            CoorConvert mapconvert = new CoorConvert();//创建存放结果的对象
            mapconvert = JsonConvert.DeserializeObject<CoorConvert>(responseTxt);//赋值

            string lon = mapconvert.x;
            string lat = mapconvert.y;
            byte[] xBuffer = Convert.FromBase64String(lon);//坐标base64解密
            string strX = Encoding.UTF8.GetString(xBuffer, 0, xBuffer.Length);
            byte[] yBuffer = Convert.FromBase64String(lat);
            string strY = Encoding.UTF8.GetString(yBuffer, 0, xBuffer.Length);
            Longitude = Convert.ToDouble(strX);
            Latitude = Convert.ToDouble(strY);
            }
            catch { }
        }
        public class CoorConvert
        {
            public string error { get; set; }
            public string x { get; set; }
            public string y { get; set; }
        }
    }
}
