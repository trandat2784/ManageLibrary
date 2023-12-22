namespace ManageLibrary
{
    partial class Form_Date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tcn_detailDate = new TabControl();
            tabPage_makeDate = new TabPage();
            btn_deleteTemp = new Button();
            btn_addTem = new Button();
            txt_nameViewer = new TextBox();
            txt_codeViewer = new TextBox();
            label6 = new Label();
            lbl_viewer = new Label();
            dgv_codeBorrow = new DataGridView();
            txt_codeBorrow = new TextBox();
            lbl_borrow = new Label();
            tabPage_detailDate = new TabPage();
            txt_stt = new TextBox();
            lbl_stt = new Label();
            lbl_note = new Label();
            txt_note = new TextBox();
            panel1 = new Panel();
            btn_change = new Button();
            btn_Load = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            dgv_date = new DataGridView();
            dtp_payBook = new DateTimePicker();
            dtp_borrow = new DateTimePicker();
            cbx1_codeBook = new ComboBox();
            cbx_borrrow = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            managebookBindingSource = new BindingSource(components);
            tcn_detailDate.SuspendLayout();
            tabPage_makeDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_codeBorrow).BeginInit();
            tabPage_detailDate.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_date).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managebookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tcn_detailDate
            // 
            tcn_detailDate.Controls.Add(tabPage_makeDate);
            tcn_detailDate.Controls.Add(tabPage_detailDate);
            tcn_detailDate.Dock = DockStyle.Bottom;
            tcn_detailDate.Location = new Point(0, 39);
            tcn_detailDate.Name = "tcn_detailDate";
            tcn_detailDate.SelectedIndex = 0;
            tcn_detailDate.Size = new Size(1112, 673);
            tcn_detailDate.TabIndex = 0;
            // 
            // tabPage_makeDate
            // 
            tabPage_makeDate.BackColor = Color.WhiteSmoke;
            tabPage_makeDate.Controls.Add(btn_deleteTemp);
            tabPage_makeDate.Controls.Add(btn_addTem);
            tabPage_makeDate.Controls.Add(txt_nameViewer);
            tabPage_makeDate.Controls.Add(txt_codeViewer);
            tabPage_makeDate.Controls.Add(label6);
            tabPage_makeDate.Controls.Add(lbl_viewer);
            tabPage_makeDate.Controls.Add(dgv_codeBorrow);
            tabPage_makeDate.Controls.Add(txt_codeBorrow);
            tabPage_makeDate.Controls.Add(lbl_borrow);
            tabPage_makeDate.Font = new Font("#9Slide03 Bebas Neue ZSmall", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage_makeDate.ForeColor = SystemColors.ActiveCaption;
            tabPage_makeDate.Location = new Point(4, 34);
            tabPage_makeDate.Name = "tabPage_makeDate";
            tabPage_makeDate.Padding = new Padding(3);
            tabPage_makeDate.Size = new Size(1104, 635);
            tabPage_makeDate.TabIndex = 0;
            tabPage_makeDate.Text = "Lập Phiếu Mượn Trả";
            // 
            // btn_deleteTemp
            // 
            btn_deleteTemp.Location = new Point(626, 161);
            btn_deleteTemp.Name = "btn_deleteTemp";
            btn_deleteTemp.Size = new Size(129, 53);
            btn_deleteTemp.TabIndex = 8;
            btn_deleteTemp.Text = "Xóa Phiếu ";
            btn_deleteTemp.UseVisualStyleBackColor = true;
            btn_deleteTemp.Click += btn_deleteTemp_Click;
            // 
            // btn_addTem
            // 
            btn_addTem.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addTem.Location = new Point(626, 57);
            btn_addTem.Name = "btn_addTem";
            btn_addTem.Size = new Size(165, 56);
            btn_addTem.TabIndex = 7;
            btn_addTem.Text = "Tạo Phiếu ";
            btn_addTem.UseVisualStyleBackColor = true;
            btn_addTem.Click += btn_addTem_Click;
            // 
            // txt_nameViewer
            // 
            txt_nameViewer.BackColor = Color.LightGray;
            txt_nameViewer.BorderStyle = BorderStyle.None;
            txt_nameViewer.Location = new Point(48, 202);
            txt_nameViewer.Multiline = true;
            txt_nameViewer.Name = "txt_nameViewer";
            txt_nameViewer.Size = new Size(281, 34);
            txt_nameViewer.TabIndex = 6;
            // 
            // txt_codeViewer
            // 
            txt_codeViewer.BackColor = Color.LightGray;
            txt_codeViewer.BorderStyle = BorderStyle.None;
            txt_codeViewer.Location = new Point(48, 125);
            txt_codeViewer.Multiline = true;
            txt_codeViewer.Name = "txt_codeViewer";
            txt_codeViewer.Size = new Size(281, 34);
            txt_codeViewer.TabIndex = 5;
            txt_codeViewer.TextChanged += txt_codeViewer_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("#9Slide03 Bebas Neue ZSmall", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(48, 172);
            label6.Name = "label6";
            label6.Size = new Size(98, 26);
            label6.TabIndex = 4;
            label6.Text = "Tên Độc Giả";
            // 
            // lbl_viewer
            // 
            lbl_viewer.AutoSize = true;
            lbl_viewer.Font = new Font("#9Slide03 Bebas Neue ZSmall", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_viewer.ForeColor = Color.Gray;
            lbl_viewer.Location = new Point(48, 100);
            lbl_viewer.Name = "lbl_viewer";
            lbl_viewer.Size = new Size(93, 26);
            lbl_viewer.TabIndex = 3;
            lbl_viewer.Text = "Mã Độc Giả";
            // 
            // dgv_codeBorrow
            // 
            dgv_codeBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_codeBorrow.BackgroundColor = Color.White;
            dgv_codeBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_codeBorrow.Location = new Point(48, 251);
            dgv_codeBorrow.Name = "dgv_codeBorrow";
            dgv_codeBorrow.RowHeadersWidth = 62;
            dgv_codeBorrow.RowTemplate.Height = 33;
            dgv_codeBorrow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_codeBorrow.Size = new Size(995, 279);
            dgv_codeBorrow.TabIndex = 2;
            dgv_codeBorrow.CellClick += dgv_codeBorrow_CellContentClick;
            dgv_codeBorrow.CellContentClick += dgv_codeBorrow_CellContentClick;
            // 
            // txt_codeBorrow
            // 
            txt_codeBorrow.BackColor = Color.LightGray;
            txt_codeBorrow.BorderStyle = BorderStyle.None;
            txt_codeBorrow.Location = new Point(48, 57);
            txt_codeBorrow.Multiline = true;
            txt_codeBorrow.Name = "txt_codeBorrow";
            txt_codeBorrow.Size = new Size(281, 34);
            txt_codeBorrow.TabIndex = 1;
            // 
            // lbl_borrow
            // 
            lbl_borrow.AutoSize = true;
            lbl_borrow.Font = new Font("#9Slide03 Bebas Neue ZSmall", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_borrow.ForeColor = Color.Gray;
            lbl_borrow.Location = new Point(48, 31);
            lbl_borrow.Name = "lbl_borrow";
            lbl_borrow.Size = new Size(125, 26);
            lbl_borrow.TabIndex = 0;
            lbl_borrow.Text = "Mã Phiếu Mượn";
            // 
            // tabPage_detailDate
            // 
            tabPage_detailDate.Controls.Add(txt_stt);
            tabPage_detailDate.Controls.Add(lbl_stt);
            tabPage_detailDate.Controls.Add(lbl_note);
            tabPage_detailDate.Controls.Add(txt_note);
            tabPage_detailDate.Controls.Add(panel1);
            tabPage_detailDate.Controls.Add(dgv_date);
            tabPage_detailDate.Controls.Add(dtp_payBook);
            tabPage_detailDate.Controls.Add(dtp_borrow);
            tabPage_detailDate.Controls.Add(cbx1_codeBook);
            tabPage_detailDate.Controls.Add(cbx_borrrow);
            tabPage_detailDate.Controls.Add(label4);
            tabPage_detailDate.Controls.Add(label3);
            tabPage_detailDate.Controls.Add(label2);
            tabPage_detailDate.Controls.Add(label1);
            tabPage_detailDate.Location = new Point(4, 34);
            tabPage_detailDate.Name = "tabPage_detailDate";
            tabPage_detailDate.Padding = new Padding(3);
            tabPage_detailDate.Size = new Size(1104, 635);
            tabPage_detailDate.TabIndex = 1;
            tabPage_detailDate.Text = "Chi Tiết Phiếu Mượn Trả";
            tabPage_detailDate.UseVisualStyleBackColor = true;
            // 
            // txt_stt
            // 
            txt_stt.Location = new Point(756, 220);
            txt_stt.Name = "txt_stt";
            txt_stt.Size = new Size(300, 31);
            txt_stt.TabIndex = 13;
            txt_stt.TextChanged += txt_stt_TextChanged;
            // 
            // lbl_stt
            // 
            lbl_stt.AutoSize = true;
            lbl_stt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stt.Location = new Point(607, 219);
            lbl_stt.Name = "lbl_stt";
            lbl_stt.Size = new Size(91, 29);
            lbl_stt.TabIndex = 12;
            lbl_stt.Text = "Số Đơn";
            // 
            // lbl_note
            // 
            lbl_note.AutoSize = true;
            lbl_note.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_note.Location = new Point(38, 212);
            lbl_note.Name = "lbl_note";
            lbl_note.Size = new Size(95, 29);
            lbl_note.TabIndex = 11;
            lbl_note.Text = "Ghi Chú";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(237, 212);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(300, 31);
            txt_note.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_change);
            panel1.Controls.Add(btn_Load);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_add);
            panel1.Location = new Point(38, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 98);
            panel1.TabIndex = 9;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(592, 29);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(112, 46);
            btn_change.TabIndex = 3;
            btn_change.Text = "Thay Đổi ";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(846, 29);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(112, 46);
            btn_Load.TabIndex = 2;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(305, 29);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 46);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Trả Sách";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(42, 29);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 46);
            btn_add.TabIndex = 0;
            btn_add.Text = "Gia Hạn";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_date
            // 
            dgv_date.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_date.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_date.Location = new Point(38, 388);
            dgv_date.Name = "dgv_date";
            dgv_date.RowHeadersWidth = 62;
            dgv_date.RowTemplate.Height = 33;
            dgv_date.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_date.Size = new Size(1018, 169);
            dgv_date.TabIndex = 8;
            dgv_date.CellClick += dgv_date_CellContentClick;
            dgv_date.CellContentClick += dgv_date_CellContentClick;
            // 
            // dtp_payBook
            // 
            dtp_payBook.Location = new Point(756, 130);
            dtp_payBook.Name = "dtp_payBook";
            dtp_payBook.Size = new Size(300, 31);
            dtp_payBook.TabIndex = 7;
            dtp_payBook.ValueChanged += dtp_payBook_ValueChanged;
            // 
            // dtp_borrow
            // 
            dtp_borrow.Location = new Point(237, 128);
            dtp_borrow.Name = "dtp_borrow";
            dtp_borrow.Size = new Size(300, 31);
            dtp_borrow.TabIndex = 6;
            // 
            // cbx1_codeBook
            // 
            cbx1_codeBook.FormattingEnabled = true;
            cbx1_codeBook.Location = new Point(756, 42);
            cbx1_codeBook.Name = "cbx1_codeBook";
            cbx1_codeBook.Size = new Size(300, 33);
            cbx1_codeBook.TabIndex = 5;
            cbx1_codeBook.SelectedIndexChanged += cbx_codeBook_SelectedIndexChanged;
            // 
            // cbx_borrrow
            // 
            cbx_borrrow.FormattingEnabled = true;
            cbx_borrrow.Location = new Point(237, 46);
            cbx_borrrow.Name = "cbx_borrrow";
            cbx_borrrow.Size = new Size(300, 33);
            cbx_borrrow.TabIndex = 4;
            cbx_borrrow.SelectedIndexChanged += cbx_borrrow_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(607, 46);
            label4.Name = "label4";
            label4.Size = new Size(103, 29);
            label4.TabIndex = 3;
            label4.Text = "Mã Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(607, 130);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 2;
            label3.Text = "Ngày Trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 130);
            label2.Name = "label2";
            label2.Size = new Size(144, 29);
            label2.TabIndex = 1;
            label2.Text = "Ngày Mượn ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(179, 29);
            label1.TabIndex = 0;
            label1.Text = "Mã Phiếu Mượn";
            // 
            // managebookBindingSource
            // 
            managebookBindingSource.DataSource = typeof(Manage_book);
            // 
            // Form_Date
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 712);
            Controls.Add(tcn_detailDate);
            MaximizeBox = false;
            Name = "Form_Date";
            Text = "Form_Date";
            Load += Form_Date_Load;
            tcn_detailDate.ResumeLayout(false);
            tabPage_makeDate.ResumeLayout(false);
            tabPage_makeDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_codeBorrow).EndInit();
            tabPage_detailDate.ResumeLayout(false);
            tabPage_detailDate.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_date).EndInit();
            ((System.ComponentModel.ISupportInitialize)managebookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcn_detailDate;
        private TabPage tabPage_makeDate;
        private TabPage tabPage_detailDate;
        private DateTimePicker dtp_payBook;
        private DateTimePicker dtp_borrow;
        private ComboBox cbx1_codeBook;
        private ComboBox cbx_borrrow;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btn_Load;
        private Button btn_delete;
        private Button btn_add;
        private DataGridView dgv_date;
        private Label lbl_borrow;
        private BindingSource managebookBindingSource;
        private TextBox txt_note;
        private Label lbl_note;
        private Button btn_change;
        private TextBox txt_codeBorrow;
        private DataGridView dgv_codeBorrow;
        private Button btn_addTem;
        private TextBox txt_nameViewer;
        private TextBox txt_codeViewer;
        private Label label6;
        private Label lbl_viewer;
        private Button btn_deleteTemp;
        private TextBox txt_stt;
        private Label lbl_stt;
    }
}