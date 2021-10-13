
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdx1();
        }
        public void mdx1()
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT [Measures].[TONGTIEN] ON COLUMNS,[GIONG].[TEN GIONG].[TEN GIONG] ON ROWS FROM[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT NON EMPTY CROSSJOIN( [TRANGTRAI].[TEN TRANGTRAI].[TEN TRANGTRAI].MEMBERS,[NAM].[NAM].[NAM]) ON ROWS,NON EMPTY[Measures].[TONGTIEN] ON COLUMNS FROM[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT NON EMPTY [TRANGTRAI].[TEN TRANGTRAI].[TEN TRANGTRAI].MEMBERS ON ROWS,NON EMPTY CROSSJOIN([NAM].[NAM].[NAM],[GIONG].[Hierarchy].[TEN GIONG] ) ON COLUMNS FROM[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "select {[GIONG].[TEN GIONG].[TEN GIONG]} on COLUMNS from[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT NON EMPTY [Measures].[TONGTIEN]ON COLUMNS, [GIONG].[TEN GIONG].[TEN GIONG] ON ROWS FROM[OLAP1] WHERE[NAM].[NAM].&[2.019E3]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT NON EMPTY [Measures].[TONGTIEN]ON COLUMNS, [GIONG].[TEN GIONG].[TEN GIONG] ON ROWS FROM[OLAP1] WHERE[NAM].[NAM].&[2.020E3]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "select [Measures].[TONGTIEN] on columns, TOPCOUNT( CROSSJOIN([THANG].[THANG].[THANG], [NAM].[NAM].[NAM].&[2019]),3,[Measures].[TONGTIEN]) on rows from[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "select [Measures].[TONGTIEN] on columns, TOPCOUNT( CROSSJOIN([THANG].[THANG].[THANG], [NAM].[NAM].[NAM].&[2020]),3,[Measures].[TONGTIEN]) on rows from[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                AdomdConnection cnn = new AdomdConnection("provider = MSOLAP; data source=THUTHUATFB; initial catalog=SSAS");
                cnn.Open();
                string tan = "SELECT {[NAM].[NAM].&[2018],[NAM].[NAM].&[2019],[NAM].[NAM].&[2020] }ON ROWS, [Measures].[TONGTIEN] ON COLUMNS FROM[OLAP1]";
                AdomdDataAdapter a = new AdomdDataAdapter(tan, cnn);
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công" + ex.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form3 = new Form4();
            form3.ShowDialog();
            this.Close();
        }
    }
    
}
