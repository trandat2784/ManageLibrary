using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.Win32.SafeHandles;

namespace ManageLibrary
{
    public partial class Manage_book : Form
    {

        string query = "select * from Manage_Book";
        string connectstr = @"Data Source=TRAN_DAT\SQLEXPRESS;Initial Catalog=Manage_Library;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        private void Manage_book_Load(object sender, EventArgs e)
        {

            Form_Connect();
            string querry_1 = "SELECT maNXB from Manage_NXB ";
            cmd = new SqlCommand();
            cmd.Connection = connection; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = querry_1;
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            cbx_codeNXB.DisplayMember = "maNXB";
            cbx_codeNXB.ValueMember = "maNXB";
            cbx_codeNXB.DataSource = table;

            string querry_2 = "SELECT maTacGia from Manage_Author ";
            cmd.CommandText = querry_2;
            SqlDataReader dr_codeAuthor = cmd.ExecuteReader();
            DataTable table_author = new DataTable();
            table_author.Load(dr_codeAuthor);
            cbx_codeAuthor.DisplayMember = "maTacGia";
            cbx_codeAuthor.ValueMember = "maTacGia";
            cbx_codeAuthor.DataSource = table_author;
            Form_TakeData();
            Form_Close();


        }
        public void Form_Connect()
        {
            connection = new SqlConnection(connectstr);
            connection.Open();


        }
        public void Form_TakeData()
        {
            cmd = new SqlCommand();
            cmd.Connection = connection; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Manage_Book";
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            dgv_book.DataSource = table;


        }
        public void Form_Close()
        {
            connection.Close();
            connection.Dispose();
        }
        public Manage_book()
        {
            InitializeComponent();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_code.Text = dgv_book.Rows[i].Cells[0].Value.ToString();
            txt_nameBook.Text = dgv_book.Rows[i].Cells[1].Value.ToString();
            txt_publicationYear.Text = dgv_book.Rows[i].Cells[2].Value.ToString();
            txt_categoryCode.Text = dgv_book.Rows[i].Cells[3].Value.ToString();
            txt_mount.Text = dgv_book.Rows[i].Cells[6].Value.ToString();
            //cbx_codeAuthor.Text = dgv_book.Rows[i].Cells[4].Value.ToString();
            //cbx_codeNXB.Text = dgv_book.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }



        private void btn_find_Click(object sender, EventArgs e)
        {
            //bo phan nay
        }
        private void btn_find_Click_1(object sender, EventArgs e)
        {
            if (rdb_code.Checked)
            {
                Form_Connect();
                SqlCommand cmd_2 = new SqlCommand();
                cmd_2.Connection = connection; ;
                cmd_2.CommandType = CommandType.Text;
                cmd_2.CommandText = "SELECT * from Manage_Book Where maSach='" + txt_search.Text.Trim() + "'";
                SqlDataReader dr_find = cmd_2.ExecuteReader();
                DataTable table_find = new DataTable();
                table_find.Load(dr_find);
                dgv_book.DataSource = table_find;
                Form_Close();
            }
            if (rdb_nameBook.Checked)
            {
                Form_Connect();
                cmd = new SqlCommand();
                cmd.Connection = connection; ;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from Manage_Book Where tenSach='" + txt_search.Text.Trim() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                table = new DataTable();
                table.Load(dr);
                dgv_book.DataSource = table;
                Form_Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd = new SqlCommand();
            cmd.Connection = connection; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into Manage_Book values (@maSach ,@tenSach,@namXuatBan,@theLoai,@tenTacGia,@maNXB,@soLuong)";
            cmd.Parameters.AddWithValue("@maSach", txt_code.Text.Trim());
            cmd.Parameters.AddWithValue("@tenSach", txt_nameBook.Text.Trim());
            cmd.Parameters.AddWithValue("@namXuatBan", int.Parse(txt_publicationYear.Text.Trim()));
            cmd.Parameters.AddWithValue("@theLoai", txt_categoryCode.Text.Trim());
            cmd.Parameters.AddWithValue("@tenTacGia", cbx_codeAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@maNXB", cbx_codeNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@soLuong", int.Parse(txt_mount.Text.Trim()));

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

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Form_Connect();
            // Tao cau lenh truy van moi            
            cmd = new SqlCommand();
            // Chon duong gui cau lenh truy van
            cmd.Connection = connection; ;
            // chon loai truy van
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update Manage_Book set maSach = @maSach ";
            cmd.CommandText = @"update Manage_Book 
                       set maSach=@maSach,
                           tenSach = @tenSach, 
                           namXuatBan = @namXuatBan, 
                           theLoai = @theLoai, 
                           maTacGia = @maTacGia, 
                           maNXB = @maNXB,
                           soLuong=@soLuong
                       where maSach = @maSach";

            // Thêm các tham số
            cmd.Parameters.AddWithValue("@maSach",txt_code.Text.Trim());
            cmd.Parameters.AddWithValue("@tenSach", txt_nameBook.Text.Trim());
            cmd.Parameters.AddWithValue("@namXuatBan", int.Parse(txt_publicationYear.Text.Trim()));
            cmd.Parameters.AddWithValue("@theLoai", txt_categoryCode.Text.Trim());
            cmd.Parameters.AddWithValue("@maTacGia", cbx_codeAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@maNXB", cbx_codeNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@soLuong", int.Parse(txt_mount.Text.Trim()));
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

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            Form_Connect();
            cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Manage_Book WHERE MaSach = @maSach ";
            cmd.Parameters.AddWithValue("@maSach", txt_code.Text.Trim());

            try
            {
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Form_TakeData();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }

            Form_Close();

        }
        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click_1(object sender, EventArgs e)
        {
            Form_Connect();
            Form_TakeData();
            Form_Close();
        }

        private void cbx_codeNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
