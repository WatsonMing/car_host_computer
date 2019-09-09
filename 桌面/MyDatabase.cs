using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace uart
{
    public partial class MyDatabase : Form
    {
        public MyDatabase()
        {
            InitializeComponent();
            try {
                updateDatabase();
                updatetable();
            } catch 
            { MessageBox.Show("数据库连接异常", "错误"); }
           
        }
        MysqlConnector mysqlC = new MysqlConnector();
        string id;
/********************************************************************************************************/
        private void update_Click(object sender, EventArgs e)//改
        {
            string replaceCommand;
            //replaceCommand = "DELETE FROM detail WHERE name='" + name.Text.ToString() + "'";
            //mysqlC.ExeUpdate(replaceCommand);
            replaceCommand = "UPDATE detail SET day_height_temp='" + day_height_temp.Text + "', day_low_temp='" + day_low_temp.Text + "', night_height_temp='" + night_height_temp.Text + "' , night_low_temp='" + night_low_temp.Text + "' , nursery_low_humi='" + nursery_low_humi.Text + "' , nursery_height_humi='" + nursery_height_humi.Text + "' , maturity_low_humi='" + maturity_low_humi.Text + "' , maturity_height_humi='" + maturity_height_humi.Text + "' , introduce='" + introduce.Text + "' WHERE name='" + name.Text + "'";
            mysqlC.ExeUpdate(replaceCommand);
            updateDatabase();
            MessageBox.Show("更新成功", "操作提示");
            clean();
        }
/********************************************************************************************************/
        private void button1_Click(object sender, EventArgs e)//删
        {
            string deleteCommand;
            if (!selectFlag)
            {
                if (strname.Text.ToString() != "")
                {
                    deleteCommand = "DELETE FROM detail WHERE name='" + strname.Text.ToString() + "'";
                    DialogResult dr = MessageBox.Show("是否需要删除作物:" + strname.Text.ToString() + " 的信息", "提示", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes) { mysqlC.ExeUpdate(deleteCommand); MessageBox.Show("删除成功", "操作提示"); }
                }
                else { MessageBox.Show("请输入正确","警告"); }
            }
            else {
                deleteCommand = "DELETE FROM detail WHERE name='" + deletename + "'";
                Console.WriteLine(deleteCommand);
                DialogResult dr=MessageBox.Show("是否需要删除作物:" + deletename + " 的信息", "提示", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes) { mysqlC.ExeUpdate(deleteCommand); MessageBox.Show("删除成功", "操作提示");}           
            }
            updateDatabase();     
        }
        private void search_Click(object sender, EventArgs e)//查
        {
            if (strname.Text.ToString() != "")
            {
                string searchCommand = "SELECT *FROM detail WHERE name='" + strname.Text.ToString() + "'";
                MySqlDataReader reader = mysqlC.ExeQuery(searchCommand);
                Console.WriteLine(searchCommand);
                if (reader.Read()) {
                    idInuput.Text = reader.GetString(reader.GetOrdinal("id"));
                    id = idInuput.Text.ToString();
                    day_height_temp.Text = reader.GetString(reader.GetOrdinal("day_height_temp"));
                    day_low_temp.Text = reader.GetString(reader.GetOrdinal("day_low_temp"));
                    night_height_temp.Text = reader.GetString(reader.GetOrdinal("night_height_temp"));
                    night_low_temp.Text = reader.GetString(reader.GetOrdinal("night_low_temp"));
                    nursery_low_humi.Text =  reader.GetString(reader.GetOrdinal("nursery_low_humi"));
                    nursery_height_humi.Text = reader.GetString(reader.GetOrdinal("nursery_height_humi"));
                    maturity_low_humi.Text = reader.GetString(reader.GetOrdinal("maturity_low_humi"));
                    maturity_height_humi.Text = reader.GetString(reader.GetOrdinal("maturity_height_humi"));
                    introduce.Text = reader.GetString(reader.GetOrdinal("introduce"));
                    name.Text = reader.GetString(reader.GetOrdinal("name"));
                    add.Enabled = false;
                    imageShow();
                }
            }
            updateDatabase();
        }
        private void add_Click(object sender, EventArgs e)//增
        {
            string insertCommand = "INSERT INTO detail ( id , day_height_temp, day_low_temp, night_height_temp , night_low_temp , nursery_low_humi , nursery_height_humi , maturity_low_humi , maturity_height_humi , introduce  , name ) VALUES( '" + id + "','" + day_height_temp.Text + "','" + day_height_temp.Text + "','" + night_height_temp.Text + "','" + night_low_temp.Text + "','" + nursery_low_humi.Text + "','" + nursery_height_humi.Text + "','" + maturity_low_humi.Text + "','" + maturity_height_humi.Text + "','" + introduce.Text + "','" + name.Text + "')";
            //MessageBox.Show(searchCommand);
            if (name.Text != "")
            {
                mysqlC.ExeUpdate(insertCommand);
                MessageBox.Show("增加成功", "操作提示");
            }
            else { MessageBox.Show("请增加输入", "操作提示"); }
            clean();
            Console.WriteLine(insertCommand);
            updateDatabase();
        }
        /***************************************************************************************************************/
        string tableName = "detail";
        private void updateDatabase() {
            string updateCommand = "SELECT *FROM "+tableName+"";
            MySqlDataReader reader = mysqlC.ExeQuery(updateCommand);
            BindingSource bs = new BindingSource
            {
                DataSource = reader
            };
            dataGridView1.DataSource = bs;
            int x = reader.GetInt32(reader.GetOrdinal("id")) + 1;
            id = x.ToString();
            idInuput.Text = id;
            updatetable();
           // MessageBox.Show(id);
        }
        /******************************************/
        private void updatetable()
        {
            string searchCommand = "SHOW TABLES";
            MySqlDataReader reader = mysqlC.ExeQuery(searchCommand);
            bsMethod(reader);
        }

        private void bsMethod(MySqlDataReader reader)
        {
            BindingSource Mybindingssource = new BindingSource
            {
                DataSource = reader
            };
            dataGridView2.DataSource = Mybindingssource;
        }

        /***************************************************************************************************************/
        private void clean() {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            name.Enabled = true;
        }
/***************************************************************************************************************/
        Boolean selectFlag = false;
        string deletename="青瓜";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectFlag = true;
            deletename = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //id = deletename;
            idInuput.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            day_height_temp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            day_low_temp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            night_height_temp.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            night_low_temp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            nursery_low_humi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            nursery_height_humi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            maturity_low_humi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            maturity_height_humi.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            introduce.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            add.Enabled = false;
            update.Enabled = false;
            idInuput.Enabled = false;
            imageShow();
        }
        private void cleanBtn_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
            clean();
        }
        private void idInuput_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void day_height_temp_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void day_low_temp_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void night_height_temp_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void night_low_temp_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void nursery_low_humi_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void nursery_height_humi_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void maturity_low_humi_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void maturity_height_humi_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void introduce_TextChanged(object sender, EventArgs e)
        {
            update.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tableName = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            clean();
            updateDatabase();
        }
        private void imageShow() {
            try
            {
                string adderss = Application.StartupPath;
                adderss = "G:\\Queen ant\\uart\\uart\\bin\\Debug\\cropImage\\" + idInuput.Text + ".jpg";
                //MessageBox.Show(adderss);
                pictureBox1.Image = Image.FromFile(adderss);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                img.Text = "";
            }
            catch{
                pictureBox1.Image = null;
                //MessageBox.Show(ex.ToString(),"未存在该图片"); 
                img.Text = "无图片";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "图片文件(*.jpg,*.png)|*.jpg;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                string newfile= "G:\\Queen ant\\uart\\uart\\bin\\Debug\\cropImage" + idInuput.Text + ".jpg";
                MessageBox.Show("图片以加载："+file);
                ImageFile imageFile = new ImageFile();
                imageFile.CopyFolder(file, newfile);
            }     
        }

        private void MyDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
