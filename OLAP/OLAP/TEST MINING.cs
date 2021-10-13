using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAP
{
    public partial class TEST_MINING : Form
    {
        public TEST_MINING()
        {
            InitializeComponent();
        }
  

        private void TEST_MINING_Load(object sender, EventArgs e)
        {
            var listcuahang = new List<CUAHANG>()
            {
                new CUAHANG(){ MA_CUA_HANG = "",TEN_CUA_HANG = "" },
                new CUAHANG(){ MA_CUA_HANG = "CH1",TEN_CUA_HANG = "CH TRẦN PHÁT" },
                new CUAHANG(){ MA_CUA_HANG = "CH2",TEN_CUA_HANG = "CH HMN" },
                new CUAHANG(){ MA_CUA_HANG = "CH3",TEN_CUA_HANG = "CH NVC" },
                new CUAHANG(){ MA_CUA_HANG = "CH4",TEN_CUA_HANG = "CH LAM SƠN" },
                new CUAHANG(){ MA_CUA_HANG = "CH5",TEN_CUA_HANG = "CH LNLQA" },
                new CUAHANG(){ MA_CUA_HANG = "CH6",TEN_CUA_HANG = "CH HTP" },
                new CUAHANG(){ MA_CUA_HANG = "CH7",TEN_CUA_HANG = "CH LNPT" },
                new CUAHANG(){ MA_CUA_HANG = "CH8",TEN_CUA_HANG = "CH ĐQKN" },
                new CUAHANG(){ MA_CUA_HANG = "CH9",TEN_CUA_HANG = "CH DTC" },
                new CUAHANG(){ MA_CUA_HANG = "CH10",TEN_CUA_HANG = "CH MCK" },
                new CUAHANG(){ MA_CUA_HANG = "CH11",TEN_CUA_HANG = "CH TĐ" },
                new CUAHANG(){ MA_CUA_HANG = "CH12",TEN_CUA_HANG = "CH SYC" },
                new CUAHANG(){ MA_CUA_HANG = "CH13",TEN_CUA_HANG = "CH RND" },
                new CUAHANG(){ MA_CUA_HANG = "CH14",TEN_CUA_HANG = "CH MS" },
                new CUAHANG(){ MA_CUA_HANG = "CH15",TEN_CUA_HANG = "CH RN" }
            };
            cbcuahang.DataSource = listcuahang;
            cbcuahang.DisplayMember = "TEN_CUA_HANG";
            cbcuahang.ValueMember = "MA_CUA_HANG";

            var listkv = new List<KHUVUC>()
            {
            new KHUVUC(){MA_KHUVUC= "",TEN_KHUVUC=""},
            new KHUVUC(){MA_KHUVUC= "KV1",TEN_KHUVUC="TP.HCM"},
            new KHUVUC(){MA_KHUVUC= "KV2",TEN_KHUVUC="LONG AN"},
            new KHUVUC(){MA_KHUVUC= "KV3",TEN_KHUVUC="HUẾ"},
            new KHUVUC(){MA_KHUVUC= "KV4",TEN_KHUVUC="HÀ NỘI"},
            new KHUVUC(){MA_KHUVUC= "KV5",TEN_KHUVUC="HÀ TĨNH"}
            };
            cbkhuvuc.DataSource = listkv;
            cbkhuvuc.DisplayMember = "TEN_KHUVUC";
            cbkhuvuc.ValueMember = "MA_KHUVUC";

            var listtt = new List<TRANGTRAI>()
            {
                new TRANGTRAI(){MA_TRANGTRAI="",TEN_TRANGTRAI=""},
                new TRANGTRAI(){MA_TRANGTRAI="TT1",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT HK1"},
                new TRANGTRAI(){MA_TRANGTRAI="TT2",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT HK4"},
                new TRANGTRAI(){MA_TRANGTRAI="TT3",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT BK4"},
                new TRANGTRAI(){MA_TRANGTRAI="TT4",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT GK4"},
                new TRANGTRAI(){MA_TRANGTRAI="TT5",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT HK5"},
                new TRANGTRAI(){MA_TRANGTRAI="TT6",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT BK5"},
                new TRANGTRAI(){MA_TRANGTRAI="TT7",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT GK5"},
                new TRANGTRAI(){MA_TRANGTRAI="TT8",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT BK1"},
                new TRANGTRAI(){MA_TRANGTRAI="TT9",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT GK1"},
                new TRANGTRAI(){MA_TRANGTRAI="TT10",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT HK2"},
                new TRANGTRAI(){MA_TRANGTRAI="TT11",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT BK2"},
                new TRANGTRAI(){MA_TRANGTRAI="TT12",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT GK2"},
                new TRANGTRAI(){MA_TRANGTRAI="TT13",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT HK3"},
                new TRANGTRAI(){MA_TRANGTRAI="TT14",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT BK3"},
                new TRANGTRAI(){MA_TRANGTRAI="TT15",TEN_TRANGTRAI="TRANG TRẠI NHỊ BÁT GK3"}
            };
            cbtrangtrai.DataSource = listtt;
            cbtrangtrai.DisplayMember = "TEN_TRANGTRAI";
            cbtrangtrai.ValueMember = "MA_TRANGTRAI";


            var listgiong = new List<GIONG>()
            {
                new GIONG(){MA_GIONG= "",TEN_GIONG=""},
                new GIONG(){MA_GIONG= "B",TEN_GIONG="Bò"},
                new GIONG(){MA_GIONG= "G",TEN_GIONG="Gà"},
                new GIONG(){MA_GIONG= "H",TEN_GIONG="Heo"}
            };
            cbgiong.DataSource = listgiong;
            cbgiong.DisplayMember = "TEN_GIONG";
            cbgiong.ValueMember = "MA_GIONG";


        }

        private void bntim_Click(object sender, EventArgs e)
        {
            AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
            cnn.Open();
            AdomdCommand cmd = new AdomdCommand();
            string query = "SELECT [ASSS].[CHATLUONG LAN2], PredictProbability([ASSS].[CHATLUONG LAN2]) From [ASSS] NATURAL PREDICTION JOIN"
                            +"(SELECT '"+cbchatluong.SelectedValue+"' AS [CHATLUONG LAN1],"
                            + "'" + cbcuahang.SelectedValue + "' AS [MA CUA HANG],"
                            + "'" + cbgiong.SelectedValue + "' AS [MA GIONG],"
                            + "'" + cbkhuvuc.SelectedValue + "' AS [MA KHUVUC],"
                            + "'" + cbtrangtrai.SelectedValue + "' AS [MA TRANGTRAI],"
                            + "'" + cbthang.SelectedValue + "' AS [THANG]) AS t";

            cmd.CommandText = query;
            cmd.Connection = cnn;
            string prob;
            string prob1;
            AdomdDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                prob1 = dr.GetValue(0).ToString();
                prob = dr.GetValue(1).ToString();
                decimal per = Convert.ToDecimal(prob);
                decimal per1 = System.Math.Round((per * 100), 2);
                string thongtin = "";
                if (prob1 == "K")
                    thongtin = "Kém";
                else if (prob1 == "TB")
                    thongtin = "Trung Bình";
                else
                    thongtin = "Tốt";
                label9.Text = thongtin;
                lbxacxuat.Text = Convert.ToString(per1) + "%";
            }
            dr.Close();
        }



    }
}
