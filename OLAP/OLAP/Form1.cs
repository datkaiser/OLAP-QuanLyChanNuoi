using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using GemBox.Spreadsheet;
//using GemBox.Spreadsheet.WinFormsUtilities;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Export;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace OLAP
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataToGridView();
            vohieuhoa(false);
        }
        private void loadDataToGridView()
        {
            dataGridView1.DataSource = db.TRANGTRAIs.ToList();
            //dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TRANGTRAI nxb = dataGridView1.CurrentRow.DataBoundItem as TRANGTRAI;
            textBox1.Text = nxb.MA_TRANGTRAI;
            textBox2.Text = nxb.TEN_TRANGTRAI;
            textBox3.Text = nxb.MA_KHUVUC;
            textBox4.Text = nxb.DIACHI;
            textBox5.Text = nxb.SOCHUONG.ToString();
        }
        private void vohieuhoa(bool kt)
        {
            textBox1.Enabled = kt;
            textBox2.Enabled = kt;
            textBox3.Enabled = kt;
            textBox4.Enabled = kt;
            textBox5.Enabled = kt;
          
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        DataSet1 ds1 = new DataSet1();
        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Thêm")
            {
                vohieuhoa(true);
                textBox1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                reset();
                textBox1.Focus();
                button1.Text = "Import";
            }
            else
            {
                button1.Text = "Thêm";
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã trang trại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập họ tên trang trại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khu vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }
                if (textBox4.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
                if (textBox5.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }
                
                var qr = from d in db.TRANGTRAIs
                         where d.MA_TRANGTRAI == textBox1.Text
                         select d;
               
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    TRANGTRAI nv = new TRANGTRAI();
                    nv.MA_TRANGTRAI = textBox1.Text;
                    nv.TEN_TRANGTRAI = textBox2.Text;
                    nv.MA_KHUVUC = textBox3.Text;
             
                    nv.DIACHI = textBox4.Text;
                    nv.SOCHUONG = textBox5.Text.Length;
                    
                    db.TRANGTRAIs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Đã import thành công", "Thông báo");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    reset();
                    loadDataToGridView();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Sửa")
            {
                button2.Text = "Import";
                vohieuhoa(true);
                textBox1.Enabled = false;
            }
            else
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã trang trại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập họ tên trang trại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khu vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }
                if (textBox4.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
                if (textBox5.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }
                else
                {
                    TRANGTRAI nv = db.TRANGTRAIs.Single(s => s.MA_TRANGTRAI == textBox1.Text);
                    nv.MA_TRANGTRAI = textBox1.Text;
                    nv.TEN_TRANGTRAI = textBox2.Text;
                    nv.MA_KHUVUC = textBox3.Text;
                    nv.DIACHI = textBox4.Text;
                    nv.SOCHUONG = textBox5.Text.Length;
                    db.SubmitChanges();
                    MessageBox.Show("Import thành công", "Thông báo");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    reset();
                    loadDataToGridView();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string st = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in db.TRANGTRAIs
                             where d.MA_TRANGTRAI == st
                             select d;
                    db.TRANGTRAIs.DeleteOnSubmit(qr.FirstOrDefault());
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadDataToGridView();
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64846TB;Initial Catalog=test;User ID=sa;Password=sa2012");
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                string query = "Insert into TRANGTRAI(MA_TRANGTRAI,TEN_TRANGTRAI,MA_KHUVUC,DIACHI,SOCHUONG) values (@MA_TRANGTRAI,@TEN_TRANGTRAI,@MA_KHUVUC,@DIACHI,@SOCHUONG)";
                // dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value); ; ; ; ;
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                sqlcmd.Parameters.AddWithValue("@MA_TRANGTRAI", dataGridView1.Rows[i].Cells[0].Value);
                sqlcmd.Parameters.AddWithValue("@TEN_TRANGTRAI", dataGridView1.Rows[i].Cells[1].Value);
                sqlcmd.Parameters.AddWithValue("@MA_KHUVUC", dataGridView1.Rows[i].Cells[2].Value);
                sqlcmd.Parameters.AddWithValue("@DIACHI", dataGridView1.Rows[i].Cells[3].Value);
                sqlcmd.Parameters.AddWithValue("@SOCHUONG", dataGridView1.Rows[i].Cells[4].Value);
                sqlcmd.ExecuteNonQuery();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from TRANGTRAI", conn);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dataGridView1.DataSource = dtb;
            conn.Close();
            MessageBox.Show("luu thanh cong");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}
