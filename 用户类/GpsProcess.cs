using System;
using static uart.用户类.GPSRevieveData;

namespace uart.用户类
{
    class GpsProcess
    {
        #region read GPS data from SerialPort
        public  void ReadGPZDA(string[] strGPS, GPZDA gpzda)
        {
            gpzda.UTCTime = DateTime.FromOADate(Convert.ToDouble(strGPS[1]));
            gpzda.Data = strGPS[2];
            gpzda.Month = strGPS[3];
            gpzda.Year = strGPS[4];
            gpzda.TimezoneHour = strGPS[5];
            gpzda.TimezoneMinitus = strGPS[6];
        }

        public  void ReadGPVTG(string[] strGPS, GPVTG gpvtg)
        {
            gpvtg.TNGroundAzimuth = string.IsNullOrEmpty(strGPS[1]) ? 0 : Convert.ToDouble(strGPS[1]);
            gpvtg.MNGroundAzimuth = string.IsNullOrEmpty(strGPS[3]) ? 0 : Convert.ToDouble(strGPS[3]);
            gpvtg.GroundSpeed = string.IsNullOrEmpty(strGPS[5]) ? 0 : Convert.ToDouble(strGPS[5]);
            gpvtg.GroundSpeedKilometer = string.IsNullOrEmpty(strGPS[7]) ? 0 : Convert.ToDouble(strGPS[7]);
            gpvtg.ModeIndication = string.IsNullOrEmpty(strGPS[9]) ? ' ' : Convert.ToChar(strGPS[9]);
        }

        public  void ReadGPRMC(string[] strGPS, GPRMC gprmc)
        {
            gprmc.UTCTime = DateTime.FromOADate(Convert.ToDouble(strGPS[1]));
            gprmc.LocationStatus = string.IsNullOrEmpty(strGPS[2]) ? ' ' : Convert.ToChar(strGPS[2]);
            gprmc.Latitude = string.IsNullOrEmpty(strGPS[3]) ? 0 : Convert.ToDouble(strGPS[3]);
            gprmc.LatitudeNS = string.IsNullOrEmpty(strGPS[4]) ? ' ' : Convert.ToChar(strGPS[4]);
            gprmc.Longitude = string.IsNullOrEmpty(strGPS[5]) ? 0 : Convert.ToDouble(strGPS[5]);
            gprmc.LongitudeEW = string.IsNullOrEmpty(strGPS[6]) ? ' ' : Convert.ToChar(strGPS[6]);
            gprmc.GroundSpeed = string.IsNullOrEmpty(strGPS[7]) ? 0 : Convert.ToDouble(strGPS[7]);
            gprmc.GroundAzimuth = string.IsNullOrEmpty(strGPS[8]) ? 0 : Convert.ToDouble(strGPS[8]);
            int a = Convert.ToInt32(strGPS[9].Substring(4, 2));
            //gprmc.UTCDate = new DateTime(Convert.ToInt32(strGPS[9].Substring(0,4)),Convert.ToInt32(strGPS[9].Substring(4,2)),1,0,0,0);
            gprmc.DeclinationAngle = string.IsNullOrEmpty(strGPS[10]) ? 0 : Convert.ToDouble(strGPS[10]);
            gprmc.DeclinationDirection = string.IsNullOrEmpty(strGPS[11]) ? ' ' : Convert.ToChar(strGPS[11]);
            gprmc.ModeIndication = string.IsNullOrEmpty(strGPS[12]) ? ' ' : Convert.ToChar(strGPS[12]);
        }

        public  void ReadGPGGA(string[] strGPS, GPGGA gpgga)
        {
            try
            {
                gpgga.UTCTime = DateTime.FromOADate(Convert.ToDouble(strGPS[1]));
                gpgga.Latitude = string.IsNullOrEmpty(strGPS[2]) ? 0 : Convert.ToDouble(strGPS[2]);
                gpgga.LatitudeNS = string.IsNullOrEmpty(strGPS[3]) ? ' ' : Convert.ToChar(strGPS[3]);
                gpgga.Longitude = string.IsNullOrEmpty(strGPS[4]) ? 0 : Convert.ToDouble(strGPS[4]);
                gpgga.LongitudeEW = string.IsNullOrEmpty(strGPS[5]) ? ' ' : Convert.ToChar(strGPS[5]);
                gpgga.Quality = string.IsNullOrEmpty(strGPS[6]) ? 0 : Convert.ToInt32(strGPS[6]);
                gpgga.UseSatelliteCount = string.IsNullOrEmpty(strGPS[7]) ? 0 : Convert.ToInt32(strGPS[7]);
                gpgga.precision = string.IsNullOrEmpty(strGPS[8]) ? 0 : Convert.ToDouble(strGPS[8]);//
                gpgga.SeaLevelHeight = string.IsNullOrEmpty(strGPS[9]) ? 0 : Convert.ToDouble(strGPS[9]);
                //10为单位（米：M）
                gpgga.GeoidalHeight = string.IsNullOrEmpty(strGPS[11]) ? 0 : Convert.ToDouble(strGPS[11]);
                //12为单位（米：M）
                gpgga.DifferenceDeadline = string.IsNullOrEmpty(strGPS[13]) ? 0 : Convert.ToDouble(strGPS[13]);
                gpgga.DifferenceReferenceBaseStation = string.IsNullOrEmpty(strGPS[14]) ? 0 : Convert.ToDouble(strGPS[14]);
            }
            catch { }
        }

        public  void ReadGPGSV(string[] strGPS, GPGSV gpgsv)
        {
            gpgsv.GSVCount = string.IsNullOrEmpty(strGPS[1]) ? 0 : Convert.ToInt32(strGPS[1]);
            gpgsv.GSVNumber = string.IsNullOrEmpty(strGPS[2]) ? 0 : Convert.ToInt32(strGPS[2]);
            gpgsv.VisibleSatelliteCount = string.IsNullOrEmpty(strGPS[3]) ? 0 : Convert.ToInt32(strGPS[3]);
            gpgsv.SatelliteNumber = string.IsNullOrEmpty(strGPS[4]) ? 0 : Convert.ToInt32(strGPS[4]);
            gpgsv.SatelliteElevationAngle = string.IsNullOrEmpty(strGPS[5]) ? 0 : Convert.ToDouble(strGPS[5]);
            gpgsv.SatelliteAngle = string.IsNullOrEmpty(strGPS[6]) ? 0 : Convert.ToDouble(strGPS[6]);
            gpgsv.NoiseRate = string.IsNullOrEmpty(strGPS[7]) ? 0 : Convert.ToInt32(strGPS[7]);
            gpgsv.Checksum = string.IsNullOrEmpty(strGPS[8]) ? 0 : Convert.ToInt32(strGPS[8]);
        }

        public  void ReadGPGSA(string[] strGPS, GPGSA gpgsa)
        {
            gpgsa.Mode = string.IsNullOrEmpty(strGPS[1]) ? ' ' : Convert.ToChar(strGPS[1]);
            gpgsa.Location = string.IsNullOrEmpty(strGPS[2]) ? 0 : Convert.ToInt32(strGPS[2]);
            gpgsa.PRN1 = string.IsNullOrEmpty(strGPS[3]) ? 0 : Convert.ToInt32(strGPS[3]);
            gpgsa.PRN2 = string.IsNullOrEmpty(strGPS[4]) ? 0 : Convert.ToInt32(strGPS[4]);
            gpgsa.PRN3 = string.IsNullOrEmpty(strGPS[5]) ? 0 : Convert.ToInt32(strGPS[5]);
            gpgsa.PRN4 = string.IsNullOrEmpty(strGPS[6]) ? 0 : Convert.ToInt32(strGPS[6]);
            gpgsa.PRN5 = string.IsNullOrEmpty(strGPS[7]) ? 0 : Convert.ToInt32(strGPS[7]);
            gpgsa.PRN6 = string.IsNullOrEmpty(strGPS[8]) ? 0 : Convert.ToInt32(strGPS[8]);
            gpgsa.PRN7 = string.IsNullOrEmpty(strGPS[9]) ? 0 : Convert.ToInt32(strGPS[9]);
            gpgsa.PRN8 = string.IsNullOrEmpty(strGPS[10]) ? 0 : Convert.ToInt32(strGPS[10]);
            gpgsa.PRN9 = string.IsNullOrEmpty(strGPS[11]) ? 0 : Convert.ToInt32(strGPS[11]);
            gpgsa.PRN10 = string.IsNullOrEmpty(strGPS[12]) ? 0 : Convert.ToInt32(strGPS[12]);
            gpgsa.PRN11 = string.IsNullOrEmpty(strGPS[13]) ? 0 : Convert.ToInt32(strGPS[13]);
            gpgsa.PRN12 = string.IsNullOrEmpty(strGPS[14]) ? 0 : Convert.ToInt32(strGPS[14]);
            gpgsa.PDOP = string.IsNullOrEmpty(strGPS[15]) ? 0 : Convert.ToDouble(strGPS[15]);
            gpgsa.HDOP = string.IsNullOrEmpty(strGPS[16]) ? 0 : Convert.ToDouble(strGPS[16]);
            gpgsa.VDOP = string.IsNullOrEmpty(strGPS[17]) ? 0 : Convert.ToDouble(strGPS[17]);
            //gpgsa.Checksum = string.IsNullOrEmpty(strGPS[18]) ? 0 : Convert.ToInt32(strGPS[18]);
        }
        #endregion
        public double Longitude;//
        public double Latitude;
        public void WriteGPGGA(GPGGA gpgga)
        {
            Longitude = gpgga.Longitude/100;
            Latitude = gpgga.Latitude/100;
            /*
            label_wd.Text = gpgga.Longitude.ToString() + gpgga.LongitudeEW;
            label_jd.Text = gpgga.Latitude.ToString() + gpgga.LatitudeNS;

            label_utcsj.Text = gpgga.UTCTime.ToLongTimeString();
            label_spjdyz.Text = gpgga.precision.ToString();
            label_jswzwxsl.Text = gpgga.UseSatelliteCount.ToString();
            label_jd.Text = gpgga.Latitude.ToString() + gpgga.LatitudeNS.ToString();
            label_cfzID.Text = gpgga.DifferenceReferenceBaseStation.ToString();
            label_cfsj.Text = gpgga.DifferenceDeadline.ToString();
            label_hbgd.Text = gpgga.SeaLevelHeight.ToString() + "米";
            label_ddszmgd.Text = gpgga.GeoidalHeight.ToString() + "米";

            switch (gpgga.Quality)
            {//0=未定位，1=非差分定位，2=差分定位，6=正在估算 
                case 0:
                    label_gpsstatus.Text = "未定位";
                    break;
                case 1:
                    label_gpsstatus.Text = "非差分定位";
                    break;
                case 2:
                    label_gpsstatus.Text = "差分定位";
                    break;
                case 6:
                    label_gpsstatus.Text = "正在估算";
                    break;
                default:
                    label_gpsstatus.Text = "";
                    break;
            }*/

        }
        /*
        public void WriteGPRMC(GPRMC gprmc)
        {
            label_wd.Text = gprmc.Longitude.ToString() + gprmc.LongitudeEW;
            label_jd.Text = gprmc.Latitude.ToString() + gprmc.LatitudeNS;

            label_dmhx.Text = gprmc.GroundAzimuth.ToString();
            label_dmsl.Text = gprmc.GroundSpeed.ToString();
            label_cpj.Text = gprmc.DeclinationAngle.ToString();
            label_utcrq.Text = gprmc.UTCDate.ToLongDateString();
            label_mszs.Text = gprmc.ModeIndication.ToString();

            if (gprmc.DeclinationDirection.ToString() == "E")//E（东）或W（西）
                label_cpjfx.Text = "东";
            else if (gprmc.DeclinationDirection.ToString() == "W")
                label_cpjfx.Text = "西";
            else
                label_cpjfx.Text = "";

            if (gprmc.ModeIndication.ToString() == "A")//（仅NMEA0183 3.00版本输出，A=自主定位，D=差分，E=估算，N=数据无效）
                label_mszs.Text = "自主定位";
            else if (gprmc.ModeIndication.ToString() == "D")
                label_mszs.Text = "差分";
            else if (gprmc.ModeIndication.ToString() == "E")
                label_mszs.Text = "估算";
            else if (gprmc.ModeIndication.ToString() == "N")
                label_mszs.Text = "数据无效";
            else
                label_mszs.Text = "";

            if (gprmc.LocationStatus.ToString() == "A")//A=有效定位，V=无效定位 
                label_dwzt.Text = "有效定位";
            else if (gprmc.LocationStatus.ToString() == "V")
                label_dwzt.Text = "无效定位";
            else
                label_dwzt.Text = "";
        }
        public void WriteGPGSA(GPGSA gpgsa)
        {

            label_sywxbh.Text = gpgsa.PRN1.ToString() + "|" + gpgsa.PRN2.ToString() + "|" +
                gpgsa.PRN3.ToString() + "|" + gpgsa.PRN4.ToString() + "|" +
                gpgsa.PRN5.ToString() + "|" + gpgsa.PRN6.ToString() + "|" +
                gpgsa.PRN7.ToString() + "|" + gpgsa.PRN8.ToString() + "|" +
                gpgsa.PRN9.ToString() + "|" + gpgsa.PRN10.ToString() + "|" +
                gpgsa.PRN11.ToString() + "|" + gpgsa.PRN12.ToString();

            label_vdop_yz.Text = gpgsa.VDOP.ToString();
            label_hdop_yz.Text = gpgsa.HDOP.ToString();
            label_pdop_yz.Text = gpgsa.PDOP.ToString();
            //label_sywxbh.Text = gpgsa;

            if (gpgsa.Location == '1')
                labe_dwxs.Text = "未定位";
            else if (gpgsa.Location == '2')
                labe_dwxs.Text = "二维定位";
            else if (gpgsa.Location == '3')
                labe_dwxs.Text = "三维定位";
            else
                labe_dwxs.Text = "";

            if (gpgsa.Mode == 'M')
                label_ms.Text = "手动";
            else if (gpgsa.Mode == 'M')
                label_ms.Text = "自动";
            else
                label_ms.Text = "";

        }*/
        public string WriteGPVTG(GPVTG gpvtg)
        {/*
            if (gpvtg.ModeIndication.ToString() == "A")
                label_mszs1.Text = "自主定位";
            else if (gpvtg.ModeIndication.ToString() == "D")
                label_mszs1.Text = "差分";
            else if (gpvtg.ModeIndication.ToString() == "E")
                label_mszs1.Text = "估算";
            else if (gpvtg.ModeIndication.ToString() == "N")
                label_mszs1.Text = "数据无效";
            else
                label_mszs1.Text = "";
            
            label_dmsl2.Text = gpvtg.GroundSpeedKilometer.ToString();
            label_dmsl1.Text = gpvtg.GroundSpeed.ToString();
            label_dmhx2.Text = gpvtg.MNGroundAzimuth.ToString();
            label_dmhx1.Text = gpvtg.TNGroundAzimuth.ToString();
             */
            return gpvtg.GroundSpeed.ToString();
        }/*
        public void WriteGPGSV(GPGSV gpgsv)
        {
            label_gsv_zs.Text = gpgsv.GSVCount.ToString();
            label_gsv_bh.Text = gpgsv.GSVNumber.ToString();
            label_wxzs.Text = gpgsv.VisibleSatelliteCount.ToString();
            label_wxbh.Text = gpgsv.SatelliteNumber.ToString();
            label_wxyj.Text = gpgsv.SatelliteElevationAngle.ToString();
            label_wxfwj.Text = gpgsv.SatelliteAngle.ToString();
            label_xhzsb.Text = gpgsv.NoiseRate.ToString();
        }*/
    }
}
