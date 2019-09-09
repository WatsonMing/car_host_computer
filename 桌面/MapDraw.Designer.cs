namespace uart.桌面
{
    partial class MapDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapDraw));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 621);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "。";
            // 
            // memory
            // 
            this.memory.BackColor = System.Drawing.Color.White;
            this.memory.BackgroundImage = global::uart.Properties.Resources.button;
            this.memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memory.ForeColor = System.Drawing.Color.White;
            this.memory.Location = new System.Drawing.Point(657, 491);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(124, 40);
            this.memory.TabIndex = 5;
            this.memory.Text = "储存";
            this.memory.UseVisualStyleBackColor = false;
            this.memory.Click += new System.EventHandler(this.memory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(654, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "名称：";
            // 
            // memoryName
            // 
            this.memoryName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memoryName.Location = new System.Drawing.Point(657, 447);
            this.memoryName.Name = "memoryName";
            this.memoryName.Size = new System.Drawing.Size(124, 26);
            this.memoryName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(654, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "作物：";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(657, 375);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(124, 26);
            this.name.TabIndex = 9;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.White;
            this.select.BackgroundImage = global::uart.Properties.Resources.button;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select.ForeColor = System.Drawing.Color.White;
            this.select.Location = new System.Drawing.Point(657, 546);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(124, 40);
            this.select.TabIndex = 10;
            this.select.Text = "查询";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::uart.Properties.Resources.button;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(657, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapDraw";
            this.Text = "工作区域地图缩略图";
            this.Load += new System.EventHandler(this.MapDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button button1;
    }
}