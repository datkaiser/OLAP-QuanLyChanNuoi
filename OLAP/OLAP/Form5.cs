using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64846TB;Initial Catalog=test;User ID=sa;Password=sa2012");
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fload = new OpenFileDialog();
            fload.Title = "Chon file";
            fload.FileName = textBox1.Text;
            fload.Filter = "Excel Sheet (*.xls)|*.xlsx|All Files(*.*)|*.*";
            fload.FilterIndex = 1;
            fload.RestoreDirectory = true;
            if (fload.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fload.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillGrid2();
        }
        void fillGrid2()
        {
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';");
            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [KHUVUC$]", connect);
            DataSet dt = new DataSet();
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            dataGridView1.DataSource = dtb.DefaultView;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                string query = "Insert into KHUVUC(MA_KHUVUC,TEN_KHUVUC) values (@MA_KHUVUC,@TEN_KHUVUC)";
                // dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value); ; ; ; ;
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@MA_KHUVUC", dataGridView1.Rows[i].Cells[0].Value);
                sqlcmd.Parameters.AddWithValue("@TEN_KHUVUC", dataGridView1.Rows[i].Cells[1].Value);
                sqlcmd.ExecuteNonQuery();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from KHUVUC", conn);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dataGridView1.DataSource = dtb;
            conn.Close();
            MessageBox.Show("luu thanh cong");
            fillGrid2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';");
            //OleDbConnection cnn = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.4.0;data source='" + textBox1.Text + "';Extended Properties=\"Excel 8.0 xml;HDR=NO;IMEX=1\"");
            cnn.Open();
            OleDbDataAdapter daapdater = new OleDbDataAdapter("Select * from [KHUVUC$]", cnn);
            DataSet dts = new DataSet();
            DataTable dtt = new DataTable();
            daapdater.Fill(dtt);
            this.dataGridView1.DataSource = dtt.DefaultView;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form1 = new Form3();
            form1.ShowDialog();
            this.Close();
        }
    }
}
