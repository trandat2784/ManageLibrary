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
    public partial class Form_Date : Form
    {
        string connectstr = @"Data Source=TRAN_DAT\SQLEXPRESS;Initial Catalog=Manage_Library;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;

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
            cmd.CommandText = "select * from Manage_Date";
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            dgv_date.DataSource = table;
            dgv_date.Columns[5].Visible = false;
            dgv_date.Columns[6].Visible = false;




        }
        public void Form_Close()
        {
            connection.Close();
            connection.Dispose();

        }
        public Form_Date()
        {
            InitializeComponent();
        }

        private void cbx_codeBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_date_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DateTime borrowDate, payDate;
            cbx_borrrow.SelectedItem = dgv_date.Rows[i].Cells[0].Value.ToString();
            cbx1_codeBook.SelectedItem = dgv_date.Rows[i].Cells[1].Value.ToString();
            DateTime.TryParse(dgv_date.Rows[i].Cells[2].Value.ToString(), out borrowDate);
            dtp_borrow.Value = borrowDate;
            DateTime.TryParse(dgv_date.Rows[i].Cells[2].Value.ToString(), out payDate);
            dtp_payBook.Value = payDate;
            txt_note.Text = dgv_date.Rows[i].Cells[4].Value.ToString();
            txt_stt.Text = dgv_date.Rows[i].Cells[7].Value.ToString();

        }

        private void Form_Date_Load(object sender, EventArgs e)
        {

            Form_Connect();
            Form_TakeData();
            // cbx ma sach
            string querry_1 = "SELECT maSach from Manage_Book ";
            cmd = new SqlCommand();
            cmd.Connection = connection; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = querry_1;
            SqlDataReader dr = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(dr);
            cbx1_codeBook.DisplayMember = "masach";
            cbx1_codeBook.ValueMember = "masach";
            cbx1_codeBook.DataSource = table;
            //cbx ma muon
            string querry_2 = "SELECT maPhieuMuon from Manage_TemBorrow";
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = connection; ;
            cmd_2.CommandType = CommandType.Text;
            cmd_2.CommandText = querry_2;
            SqlDataReader dr_borrow = cmd_2.ExecuteReader();
            DataTable table_2 = new DataTable();
            table_2.Load(dr_borrow);
            cbx_borrrow.DisplayMember = "maPhieuMuon";
            cbx_borrrow.ValueMember = "maPhieuMuon";
            cbx_borrrow.DataSource = table_2;

            cmd.CommandText = "select * from Manage_TemBorrow";
            SqlDataReader dr_borrowTemp = cmd.ExecuteReader();
            DataTable table_borrowTemp = new DataTable();
            table_borrowTemp.Load(dr_borrowTemp);
            dgv_codeBorrow.DataSource = table_borrowTemp;
            Form_Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_Connect();
            // Bắt đầu một transaction
            SqlTransaction transaction = connection.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {
                // Thực hiện câu lệnh insert
                cmd.CommandText = "insert into Manage_Date(maPhieuMuon,maSach,ngayMuon,ngayTra,ghiChu,STT) values(@maPhieuMuon, @maSach, @ngayMuon,@ngayTra,@ghiChu,@STT)";
                cmd.Parameters.AddWithValue("@maPhieuMuon", cbx_borrrow.Text.Trim());
                cmd.Parameters.AddWithValue("@maSach", cbx1_codeBook.Text.Trim());
                cmd.Parameters.AddWithValue("@ngayMuon", dtp_borrow.Value);
                cmd.Parameters.AddWithValue("@ngayTra", dtp_payBook.Value);
                cmd.Parameters.AddWithValue("@ghiChu", txt_note.Text.Trim());
                cmd.Parameters.AddWithValue("@STT", txt_stt.Text.Trim());
                int row = cmd.ExecuteNonQuery();

                // Thực hiện câu lệnh update
                cmd.CommandText = "update Manage_Book set soLuong=soLuong-1 where maSach = '" + cbx1_codeBook.Text.Trim() + "'";
                row = cmd.ExecuteNonQuery();

                // Commit transaction nếu mọi thứ đều thành công
                transaction.Commit();

                if (row > 0)
                {
                    Form_TakeData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu");
                }
            }
            catch (Exception ex)
            {
                // Rollback transaction nếu có lỗi
                transaction.Rollback();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                Form_Close();
            }
            int quantity = 0;
            if (int.TryParse(txt_stt.Text, out int index))
            {
                quantity = index + 1;

            }
            else
            {
                quantity = 1;
            }
            txt_stt.Text = quantity.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Form_Connect();
            SqlTransaction transaction = connection.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "Delete from Manage_Date where STT=@STT";
                cmd.Parameters.AddWithValue("@STT", txt_stt.Text.Trim());
                int row = cmd.ExecuteNonQuery();
                cmd.CommandText = "update Manage_Book set soLuong=soLuong+1 where maSach = '" + cbx1_codeBook.Text.Trim() + "'";
                // Commit transaction nếu mọi thứ đều thành công
                transaction.Commit();
                row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Form_TakeData();
                }
                else
                {
                    MessageBox.Show("Loi khi lay du lieu");
                }
            }
            catch (Exception ex)
            {
                // Rollback transaction nếu có lỗi
                transaction.Rollback();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                Form_Close();
            }
        }

        private void dtp_payBook_ValueChanged(object sender, EventArgs e)
        {
            //if (dtp_payBook.Value <= dtp_borrow.Value)
            //{
            //    MessageBox.Show("Ngay Tra Khong Hop Le");

            //}

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = @"update Manage_Date
                       set maPhieuMuon = @maPhieuMuon , maSach = @maSach,ngayMuon=@ngayMuon ,ngayTra=@ngayTra,ghiChu=@ghiChu 
                       where maPhieuMuon = @maPhieuMuon";


            // Thêm các tham số
            cmd.Parameters.AddWithValue("@maPhieuMuon", cbx_borrrow.Text);
            cmd.Parameters.AddWithValue("@maSach", cbx1_codeBook.Text);
            cmd.Parameters.AddWithValue("@ngayMuon", dtp_borrow.Value);
            cmd.Parameters.AddWithValue("@ngayTra", dtp_payBook.Value);
            cmd.Parameters.AddWithValue("@ghiChu", txt_note.Text.Trim());
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


        // Tab1
        private void dgv_codeBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            txt_codeBorrow.Text = dgv_codeBorrow.Rows[i].Cells[0].Value.ToString();
            txt_codeViewer.Text = dgv_codeBorrow.Rows[i].Cells[1].Value.ToString();
            txt_nameViewer.Text = dgv_codeBorrow.Rows[i].Cells[2].Value.ToString();


        }

        private void btn_addTem_Click(object sender, EventArgs e)
        {
            Form_Connect();

            cmd.CommandText = "insert into Manage_TemBorrow values(@maPhieuMuon, @maDocGia, @tenDocGia)";
            cmd.Parameters.AddWithValue("@maPhieuMuon", txt_codeBorrow.Text.Trim());
            cmd.Parameters.AddWithValue("@maDocGia", txt_codeViewer.Text.Trim());
            cmd.Parameters.AddWithValue("@tenDocGia", txt_nameViewer.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {

                cmd.CommandText = "select * from Manage_TemBorrow";
                SqlDataReader dr = cmd.ExecuteReader();
                table = new DataTable();
                table.Load(dr);
                dgv_codeBorrow.DataSource = table;
            }
            else
            {
                MessageBox.Show("Loi khi them du lieu");
            }
            Form_Close();
        }

        private void btn_deleteTemp_Click(object sender, EventArgs e)
        {
            Form_Connect();
            cmd.CommandText = "Delete from Manage_TemBorrow where maPhieuMuon=@maPhieuMuon";
            cmd.Parameters.AddWithValue("@maPhieuMuon", txt_codeBorrow.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                cmd.CommandText = "select * from Manage_TemBorrow";
                SqlDataReader dr = cmd.ExecuteReader();
                table = new DataTable();
                table.Load(dr);
                dgv_codeBorrow.DataSource = table;
            }
            else
            {
                MessageBox.Show("Loi khi lay du lieu");
            }
            Form_Close();
        }

        private void cbx_borrrow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            Form_Connect();
            string querry_2 = "SELECT maPhieuMuon from Manage_TemBorrow";
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = connection; ;
            cmd_2.CommandType = CommandType.Text;
            cmd_2.CommandText = querry_2;
            SqlDataReader dr_borrow = cmd_2.ExecuteReader();
            DataTable table_2 = new DataTable();
            table_2.Load(dr_borrow);
            cbx_borrrow.DisplayMember = "maPhieuMuon";
            cbx_borrrow.ValueMember = "maPhieuMuon";
            cbx_borrrow.DataSource = table_2;
            Form_Close();
        }

        private void txt_stt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codeViewer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
