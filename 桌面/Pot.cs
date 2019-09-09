using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uart.桌面
{
    public partial class Pot : Form
    {
        public Pot()
        {
            InitializeComponent();
        }
        double size = 123.138461538462;
        double C = 4200;
        //int temp_2 = 0;
        //int temp_1 = 0;
        double m = 0.001;
        double Specific_Heat_Capacity;
       // Specific_Heat_Capacity = Q /(m* (temp_2 - temp_1));
        private void column_Click(object sender, EventArgs e)
        {
            double rz = 1.0;
            double md = 1.6;
            
            rz = double.Parse(Rz.SelectedItem.ToString());
            md = double.Parse(Md.SelectedItem.ToString());
            //MessageBox.Show(rz.ToString(),md.ToString());
            size = 66.7 * 3 * (md - rz)/md;
            Size.Text = size.ToString();
            Sch.Text = SHC().ToString();
        }
        private double SHC()
        {
            Specific_Heat_Capacity = C *m * (double .Parse(Temp2.Text.ToString()) - double.Parse(Temp1.Text.ToString()));
            return Specific_Heat_Capacity;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Pot_Load(object sender, EventArgs e)
        {

        }
    }
}
