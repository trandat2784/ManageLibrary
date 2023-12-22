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
    public partial class Manage_author : Form
    {
        string connectstr = @"Data Source=TRAN_DAT\SQLEXPRESS;Initial Catalog=Manage_Library;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        Manage_book book_NXB = new Manage_book();
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
            cmd.CommandText = "SELECT * from Manage_author";
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            dgv_author.DataSource = table;


        }
        public void Form_Close()
        {
            connection.Close();
            connection.Dispose();
        }
        public Manage_author()
        {
            InitializeComponent();
        }

        private void Manage_author_Load(object sender, EventArgs e)
        {
            Form_Connect();
            Form_TakeData();
            Form_Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = "insert into Manage_author values(@maTacGia, @tenTacGia)";
            cmd.Parameters.AddWithValue("@maTacGia", txt_codeAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@tenTacGia", txt_nameAuthor.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Form_TakeData();
            }
            else
            {
                MessageBox.Show("Loi khi lay du lieu");
            }
            Form_Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = "delete from Manage_Author where maTacGIa=@maTacGIa";
            cmd.Parameters.AddWithValue("@maTacGia", txt_codeAuthor.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Form_TakeData();
            }
            else
            {
                MessageBox.Show("Loi khi lay du lieu");
            }
            Form_Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = @"update Manage_Author
                       set maTacGia = @maTacGia , tenTacGia = @tenTacGia 
                       where maTacGia = @maTacGia";

            // Thêm các tham số
            cmd.Parameters.AddWithValue("@maTacGia", txt_codeAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@tenTacGia", txt_nameAuthor.Text.Trim());
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

        private void dgv_author_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_codeAuthor.Text = dgv_author.Rows[i].Cells[0].Value.ToString();
            txt_nameAuthor.Text = dgv_author.Rows[i].Cells[1].Value.ToString();
        }
    }
}
