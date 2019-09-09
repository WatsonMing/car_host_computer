using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace uart.桌面
{
    public partial class GrowMemary : Form
    {
        public GrowMemary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//回溯
        {
            imgDisplay();
            
        }
        int imgCount = 0;
        string[] parm = new string[100];
        double[] w = new double[100];
        double[] h = new double[100];
        private void imgDisplay()
        {
            string selectFidCommand = "SELECT id FROM detail WHERE name='" + strname.Text + "'";
            MySqlDataReader reader2 = mysqlC.ExeQuery(selectFidCommand);
            if (reader2.Read()) { fid = reader2.GetInt32(reader2.GetOrdinal("id")); }
            //获取父亲id
            string selectFidCommand2 = "SELECT imageName FROM growimage WHERE Fid=" + fid + " and phase='"+ jieDuan + "' and quarter='"+ jiDu + "' ";
            MySqlDataReader reader = mysqlC.ExeQuery(selectFidCommand2);
            int i = 0;
            while (reader.Read()) {
                parm[i] = reader.GetString(reader.GetOrdinal("imageName"));
                imageList1.Images.Add(Image.FromFile("G:\\Queen ant\\uart\\uart\\bin\\Debug\\growMemary_Iamge\\" + strname.Text.ToString() + "\\" + jiDu + "\\" + jieDuan + "\\" + parm[i] + ".jpg"));
                i++;
            }
            imgCount = i;
            pictureBox2.Image = imageList1.Images[0];
            label8.Text = parm[0];
            //MessageBox.Show(parm[0]+parm[1]+ parm[2]+ parm[3]+ parm[4]);
            /*********************************添加图片集合******************************************************/

        }
        string jiDu = "第一季度";
        string jieDuan = "幼苗期";
        int fid = 0;
        private void pictureBox1_Click(object sender, EventArgs e)//保存图片
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "图片文件(*.jpg,*.png)|*.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                MessageBox.Show("图片以加载：" + file);
                jiDu = listBox2.SelectedItem.ToString();
               // MessageBox.Show(jiDu);
                jieDuan = listBox1.SelectedItem.ToString();
                // MessageBox.Show(jieDuan);
                string name= string.Format("{0:D}", dateTimePicker1.Value);
                string newfile = "G:\\Queen ant\\uart\\uart\\bin\\Debug\\growMemary_Iamge\\"+ strname.Text.ToString()+"\\"+ jiDu+"\\"+jieDuan+"\\"+ name + ".jpg";
                 MessageBox.Show(newfile);
                ImageFile imageFile = new ImageFile();
                imageFile.CopyFolder(file, newfile);
                /******************************/
                string selectFidCommand = "SELECT id FROM detail WHERE name='" + strname.Text + "'";
                MySqlDataReader reader2 = mysqlC.ExeQuery(selectFidCommand);
                if (reader2.Read()) { fid = reader2.GetInt32(reader2.GetOrdinal("id")); }
                insertDb(jieDuan, name, jiDu);//插入数据库
            }
        }
        MysqlConnector mysqlC = new MysqlConnector();
        private void insertDb(string pah, string imgName, string qua)//数据库插入
        {  
            try
            {
                string countCmd = "select count(*) from growImage";
                int id=0;
                id= mysqlC.count(countCmd)+1;
                string insertCommand = "INSERT INTO growImage ( phase , Fid, id, quarter ,imageName) VALUES( '" + pah + "'," + fid + "," + id + ",'" + qua + "','" + imgName + "')";
                //MessageBox.Show(insertCommand);
                mysqlC.ExeUpdate(insertCommand);
                //MessageBox.Show("增加成功", "操作提示");
            }
            catch { MessageBox.Show("增加失败", "操作提示"); }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string countCmd = "select count(*) from grow";
            string time = "2018年1月1日";
            int id = 0;
            id = mysqlC.count(countCmd) + 1;
            time =dateTimePicker1.Value.ToShortDateString().ToString();
            string selectFidCommand = "SELECT id FROM detail WHERE name='" + strname.Text + "'";
            MySqlDataReader reader2 = mysqlC.ExeQuery(selectFidCommand);
            if (reader2.Read()) { fid = reader2.GetInt32(reader2.GetOrdinal("id")); }
            string insertCommand = "INSERT INTO grow (MyId,Id,Phase,Width,Length,ImageName,Quarter) VALUES( " + id+ "," + fid + ",'" + jieDuan + "'," + hei.Text.ToString() + "," + wid.Text.ToString() + ",'" + time + "','"+ jiDu + "')";
            //MessageBox.Show(insertCommand);
            mysqlC.ExeUpdate(insertCommand);
            MessageBox.Show("增加成功", "操作提示");
        }
        int count=0;
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //count = 0;
            if (imageList1.Images.Count != 0)
            {
                count++;
                if (count == imgCount) { count = imgCount; }
                else {
                    pictureBox2.Image = imageList1.Images[count];
                    label8.Text = parm[count];
                }
            }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //count = imgCount;
            if (imageList1.Images.Count != 0)
            {
                if (count == 0) { count = 0; }
                else
                {
                    count--;
                    pictureBox2.Image = imageList1.Images[count];
                    label8.Text = parm[count];
                }
            }
        }

        private void GrowMemary_Load(object sender, EventArgs e)
        {

        }
    }
}
