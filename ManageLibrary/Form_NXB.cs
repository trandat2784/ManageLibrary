using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class Form_NXB : Form
    {

        string connectstr = @"Data Source=TRAN_DAT\SQLEXPRESS;Initial Catalog=Manage_Library;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        Manage_book book_NXB = new Manage_book();
        public Form_NXB()
        {
            InitializeComponent();
        }
        public void Form_Connect()
        {
            connection = new SqlConnection(connectstr);
            connection.Open();
            cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;


        }
        public void Form_TakeData()
        {
            cmd = new SqlCommand();
            cmd.Connection = connection; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Manage_NXB";
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            dgv_NXB.DataSource = table;


        }
        public void Form_Close()
        {
            connection.Close();
            connection.Dispose();
        }
        private void Form_NXB_Load(object sender, EventArgs e)
        {
            Form_Connect();
            Form_TakeData();
            Form_Close();
        }

        private void lbl_codeNXB_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_codeNXB.Text = dgv_NXB.Rows[i].Cells[0].Value.ToString();
            txt_addressNXB.Text = dgv_NXB.Rows[i].Cells[1].Value.ToString();
            txt_nameNXB.Text = dgv_NXB.Rows[i].Cells[2].Value.ToString();
            txt_phoneNXB.Text = dgv_NXB.Rows[i].Cells[3].Value.ToString();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = "insert into Manage_NXB values(@maNXB , @diaChi,@tenNXB,@soDienThoai)";
            cmd.Parameters.AddWithValue("@maNXB", txt_codeNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txt_addressNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@tenNXB", txt_nameNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@soDienThoai", txt_phoneNXB.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Form_TakeData();
            }
            else
            {
                MessageBox.Show("Loi khi lay du lieu");
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = "delete from Manage_NXB where maNXB=@maNXB";
            cmd.Parameters.AddWithValue("@maNXB", txt_codeNXB.Text.Trim());
            //cmd.Parameters.AddWithValue("@diaChi", txt_addressNXB.Text.Trim());
            //cmd.Parameters.AddWithValue("@tenNXB", txt_nameNXB.Text.Trim());
            //cmd.Parameters.AddWithValue("@soDienThoai", txt_phoneNXB.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Form_TakeData();
            }
            else
            {
                MessageBox.Show("Loi khi lay du lieu");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = @"update Manage_NXB 
                       set maNXB = @maNXB , diaChi = @diaChi , tenNXB = @tenNXB , soDienThoai = @soDienThoai
                       where maNXB = @maNXB";

            // Thêm các tham số
            cmd.Parameters.AddWithValue("@maNXB", txt_codeNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txt_addressNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@tenNXB", txt_nameNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@soDienThoai", txt_phoneNXB.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Form_TakeData();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu");
            }
            Form_Close();
        }
    }
}
