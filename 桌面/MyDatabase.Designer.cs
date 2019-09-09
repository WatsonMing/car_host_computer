namespace uart
{
    partial class MyDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDatabase));
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.day_height_temp = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.night_height_temp = new System.Windows.Forms.TextBox();
            this.nursery_height_humi = new System.Windows.Forms.TextBox();
            this.maturity_low_humi = new System.Windows.Forms.TextBox();
            this.maturity_height_humi = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nursery_low_humi = new System.Windows.Forms.TextBox();
            this.night_low_temp = new System.Windows.Forms.TextBox();
            this.strname = new System.Windows.Forms.TextBox();
            this.day_low_temp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInuput = new System.Windows.Forms.TextBox();
            this.introduce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BackgroundImage = global::uart.Properties.Resources.button;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(685, 471);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 31);
            this.search.TabIndex = 5;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundImage = global::uart.Properties.Resources.button;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(820, 471);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 31);
            this.delete.TabIndex = 6;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // day_height_temp
            // 
            this.day_height_temp.Location = new System.Drawing.Point(185, 274);
            this.day_height_temp.Name = "day_height_temp";
            this.day_height_temp.Size = new System.Drawing.Size(98, 21);
            this.day_height_temp.TabIndex = 7;
            this.day_height_temp.TextChanged += new System.EventHandler(this.day_height_temp_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = global::uart.Properties.Resources.button;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(953, 471);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 31);
            this.add.TabIndex = 8;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // night_height_temp
            // 
            this.night_height_temp.Location = new System.Drawing.Point(385, 274);
            this.night_height_temp.Name = "night_height_temp";
            this.night_height_temp.Size = new System.Drawing.Size(98, 21);
            this.night_height_temp.TabIndex = 10;
            this.night_height_temp.TextChanged += new System.EventHandler(this.night_height_temp_TextChanged);
            // 
            // nursery_height_humi
            // 
            this.nursery_height_humi.Location = new System.Drawing.Point(685, 274);
            this.nursery_height_humi.Name = "nursery_height_humi";
            this.nursery_height_humi.Size = new System.Drawing.Size(98, 21);
            this.nursery_height_humi.TabIndex = 11;
            this.nursery_height_humi.TextChanged += new System.EventHandler(this.nursery_height_humi_TextChanged);
            // 
            // maturity_low_humi
            // 
            this.maturity_low_humi.Location = new System.Drawing.Point(785, 274);
            this.maturity_low_humi.Name = "maturity_low_humi";
            this.maturity_low_humi.Size = new System.Drawing.Size(98, 21);
            this.maturity_low_humi.TabIndex = 12;
            this.maturity_low_humi.TextChanged += new System.EventHandler(this.maturity_low_humi_TextChanged);
            // 
            // maturity_height_humi
            // 
            this.maturity_height_humi.Location = new System.Drawing.Point(885, 274);
            this.maturity_height_humi.Name = "maturity_height_humi";
            this.maturity_height_humi.Size = new System.Drawing.Size(98, 21);
            this.maturity_height_humi.TabIndex = 13;
            this.maturity_height_humi.TextChanged += new System.EventHandler(this.maturity_height_humi_TextChanged);
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(1085, 274);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(98, 21);
            this.name.TabIndex = 14;
            // 
            // nursery_low_humi
            // 
            this.nursery_low_humi.Location = new System.Drawing.Point(585, 274);
            this.nursery_low_humi.Name = "nursery_low_humi";
            this.nursery_low_humi.Size = new System.Drawing.Size(98, 21);
            this.nursery_low_humi.TabIndex = 15;
            this.nursery_low_humi.TextChanged += new System.EventHandler(this.nursery_low_humi_TextChanged);
            // 
            // night_low_temp
            // 
            this.night_low_temp.Location = new System.Drawing.Point(485, 274);
            this.night_low_temp.Name = "night_low_temp";
            this.night_low_temp.Size = new System.Drawing.Size(98, 21);
            this.night_low_temp.TabIndex = 16;
            this.night_low_temp.TextChanged += new System.EventHandler(this.night_low_temp_TextChanged);
            // 
            // strname
            // 
            this.strname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strname.Location = new System.Drawing.Point(583, 407);
            this.strname.Name = "strname";
            this.strname.Size = new System.Drawing.Size(153, 26);
            this.strname.TabIndex = 19;
            // 
            // day_low_temp
            // 
            this.day_low_temp.Location = new System.Drawing.Point(285, 274);
            this.day_low_temp.Name = "day_low_temp";
            this.day_low_temp.Size = new System.Drawing.Size(98, 21);
            this.day_low_temp.TabIndex = 9;
            this.day_low_temp.TextChanged += new System.EventHandler(this.day_low_temp_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 245);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idInuput
            // 
            this.idInuput.Location = new System.Drawing.Point(85, 274);
            this.idInuput.Name = "idInuput";
            this.idInuput.Size = new System.Drawing.Size(98, 21);
            this.idInuput.TabIndex = 21;
            this.idInuput.TextChanged += new System.EventHandler(this.idInuput_TextChanged);
            // 
            // introduce
            // 
            this.introduce.Location = new System.Drawing.Point(985, 274);
            this.introduce.Name = "introduce";
            this.introduce.Size = new System.Drawing.Size(98, 21);
            this.introduce.TabIndex = 22;
            this.introduce.TextChanged += new System.EventHandler(this.introduce_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "-->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(482, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "作物名称：";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.BackgroundImage = global::uart.Properties.Resources.button;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(1085, 471);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 31);
            this.update.TabIndex = 26;
            this.update.Text = "更改";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.White;
            this.cleanBtn.BackgroundImage = global::uart.Properties.Resources.button;
            this.cleanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cleanBtn.ForeColor = System.Drawing.Color.White;
            this.cleanBtn.Location = new System.Drawing.Point(756, 405);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(82, 31);
            this.cleanBtn.TabIndex = 27;
            this.cleanBtn.Text = "清空";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 305);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(143, 200);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 200);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::uart.Properties.Resources.button;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(485, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "打开图片文件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // img
            // 
            this.img.AutoSize = true;
            this.img.Location = new System.Drawing.Point(342, 366);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(0, 12);
            this.img.TabIndex = 31;
            // 
            // MyDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 518);
            this.Controls.Add(this.img);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introduce);
            this.Controls.Add(this.idInuput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.strname);
            this.Controls.Add(this.night_low_temp);
            this.Controls.Add(this.nursery_low_humi);
            this.Controls.Add(this.name);
            this.Controls.Add(this.maturity_height_humi);
            this.Controls.Add(this.maturity_low_humi);
            this.Controls.Add(this.nursery_height_humi);
            this.Controls.Add(this.night_height_temp);
            this.Controls.Add(this.day_low_temp);
            this.Controls.Add(this.add);
            this.Controls.Add(this.day_height_temp);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyDatabase";
            this.Text = "数据库管理";
            this.Load += new System.EventHandler(this.MyDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox day_height_temp;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox night_height_temp;
        private System.Windows.Forms.TextBox nursery_height_humi;
        private System.Windows.Forms.TextBox maturity_low_humi;
        private System.Windows.Forms.TextBox maturity_height_humi;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox nursery_low_humi;
        private System.Windows.Forms.TextBox night_low_temp;
        private System.Windows.Forms.TextBox strname;
        private System.Windows.Forms.TextBox day_low_temp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idInuput;
        private System.Windows.Forms.TextBox introduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label img;
    }
}