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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string user = "admin";
        string pass = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text) == "kaiser") && ((textBox2.Text) == "123"))
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Tên đăng nhập, Mật khẩu rồi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
