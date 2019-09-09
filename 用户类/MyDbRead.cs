using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uart
{
    class MyDbRead
    {
        /* * 数据库读取数据变量声明 **/
        private int id = 0;//作物id
        private int dht = 0;//白天最高温度
        private int dlt = 0;//白天最低温度
        private int nht = 0;//晚上最高温度
        private int nlt = 0;//晚上最低温度
        private int nlh = 0;//幼苗期最低湿度
        private int nhh = 0;//幼苗期最高湿度
        private int mlh = 0;//幼苗期最低湿度
        private int mhh = 0;//幼苗期最高湿度
        private string introduce = "";//作物详情
        /********************************************/
        private int nt;
        private int dt;
        private int nh;
        private int mh;

        public  int Nt { get => nt; set => nt = value; }
        public  int Dt { get => dt; set => dt = value; }
        public  int Nh { get => nh; set => nh = value; }
        public  int Mh { get => mh; set => mh = value; }
        public string Introduce { get => introduce; set => introduce = value; }
        public int Id { get => id; set => id = value; }

        public void mydbread(string mysqlCommand) {
            MysqlConnector mysqlC = new MysqlConnector();
            MySqlDataReader reader = mysqlC.ExeQuery(mysqlCommand);
            try
            {
                if (reader.Read())
                {
                    //数据获取
                    Id = reader.GetInt32(reader.GetOrdinal("id"));
                    dht = reader.GetInt32(reader.GetOrdinal("day_height_temp"));
                    dlt = reader.GetInt32(reader.GetOrdinal("day_low_temp"));
                    nht = reader.GetInt32(reader.GetOrdinal("night_height_temp"));
                    nlt = reader.GetInt32(reader.GetOrdinal("night_low_temp"));
                    nlh = reader.GetInt32(reader.GetOrdinal("nursery_low_humi"));
                    nhh = reader.GetInt32(reader.GetOrdinal("nursery_height_humi"));
                    mlh = reader.GetInt32(reader.GetOrdinal("maturity_low_humi"));
                    mhh = reader.GetInt32(reader.GetOrdinal("maturity_height_humi"));
                    Introduce = reader.GetString(reader.GetOrdinal("introduce"));
                    //数据处理显示
                    Nt = ((nht + nlt) / 2);
                    Dt = ((dht + dlt) / 2);
                    Nh = ((nlh + nhh) / 2);
                    Mh = ((mlh + mhh) / 2);
                }
            }
            catch { MessageBox.Show("数据库读取异常"); }
        }
    }
}
