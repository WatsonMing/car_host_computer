namespace uart.桌面
{
    partial class Pot
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
            this.Rz = new System.Windows.Forms.ListBox();
            this.Md = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Humi1 = new System.Windows.Forms.TextBox();
            this.Temp1 = new System.Windows.Forms.TextBox();
            this.Sch = new System.Windows.Forms.TextBox();
            this.Humi2 = new System.Windows.Forms.TextBox();
            this.Temp2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rz
            // 
            this.Rz.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rz.FormattingEnabled = true;
            this.Rz.ItemHeight = 16;
            this.Rz.Items.AddRange(new object[] {
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5"});
            this.Rz.Location = new System.Drawing.Point(53, 46);
            this.Rz.Name = "Rz";
            this.Rz.Size = new System.Drawing.Size(77, 20);
            this.Rz.TabIndex = 33;
            // 
            // Md
            // 
            this.Md.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Md.FormattingEnabled = true;
            this.Md.ItemHeight = 16;
            this.Md.Items.AddRange(new object[] {
            "2.6",
            "2.7"});
            this.Md.Location = new System.Drawing.Point(53, 105);
            this.Md.Name = "Md";
            this.Md.Size = new System.Drawing.Size(77, 20);
            this.Md.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "土壤容重cm3/g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(161, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "土壤密度cm3/g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(161, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "浇灌量/g";
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(53, 152);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(77, 21);
            this.Size.TabIndex = 38;
            // 
            // column
            // 
            this.column.BackColor = System.Drawing.Color.White;
            this.column.BackgroundImage = global::uart.Properties.Resources.button;
            this.column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.column.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.column.ForeColor = System.Drawing.Color.White;
            this.column.Location = new System.Drawing.Point(383, 197);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(100, 30);
            this.column.TabIndex = 47;
            this.column.Text = "计算";
            this.column.UseVisualStyleBackColor = false;
            this.column.Click += new System.EventHandler(this.column_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(346, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "湿度前";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Temp.Location = new System.Drawing.Point(346, 114);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(56, 16);
            this.Temp.TabIndex = 49;
            this.Temp.Text = "温度前";
            // 
            // Humi1
            // 
            this.Humi1.Location = new System.Drawing.Point(427, 47);
            this.Humi1.Name = "Humi1";
            this.Humi1.Size = new System.Drawing.Size(100, 21);
            this.Humi1.TabIndex = 50;
            // 
            // Temp1
            // 
            this.Temp1.Location = new System.Drawing.Point(427, 111);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(100, 21);
            this.Temp1.TabIndex = 51;
            // 
            // Sch
            // 
            this.Sch.Location = new System.Drawing.Point(53, 206);
            this.Sch.Name = "Sch";
            this.Sch.Size = new System.Drawing.Size(77, 21);
            this.Sch.TabIndex = 52;
            // 
            // Humi2
            // 
            this.Humi2.Location = new System.Drawing.Point(427, 81);
            this.Humi2.Name = "Humi2";
            this.Humi2.Size = new System.Drawing.Size(100, 21);
            this.Humi2.TabIndex = 53;
            // 
            // Temp2
            // 
            this.Temp2.Location = new System.Drawing.Point(427, 142);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(100, 21);
            this.Temp2.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(346, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "湿度前";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(346, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "温度后";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(161, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "蒸腾量/g";
            // 
            // Pot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Temp2);
            this.Controls.Add(this.Humi2);
            this.Controls.Add(this.Sch);
            this.Controls.Add(this.Temp1);
            this.Controls.Add(this.Humi1);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.column);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Md);
            this.Controls.Add(this.Rz);
            this.Name = "Pot";
            this.Text = "Pot";
            this.Load += new System.EventHandler(this.Pot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Rz;
        private System.Windows.Forms.ListBox Md;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private new System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Button column;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.TextBox Humi1;
        private System.Windows.Forms.TextBox Temp1;
        private System.Windows.Forms.TextBox Sch;
        private System.Windows.Forms.TextBox Humi2;
        private System.Windows.Forms.TextBox Temp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}