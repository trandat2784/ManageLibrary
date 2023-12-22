namespace ManageLibrary
{
    partial class Manage_book
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
            lbl_code = new Label();
            lbl_nameBook = new Label();
            lbl_yearPublication = new Label();
            lbl_publisherCode = new Label();
            lbl_categoryCode = new Label();
            lbl_authorCode = new Label();
            txt_code = new TextBox();
            txt_nameBook = new TextBox();
            btn_add = new Button();
            btn_Change = new Button();
            btn_Delete = new Button();
            btn_Load = new Button();
            btn_exit = new Button();
            grp_update = new GroupBox();
            txt_mount = new TextBox();
            lbl_mount = new Label();
            cbx_codeAuthor = new ComboBox();
            cbx_codeNXB = new ComboBox();
            txt_publicationYear = new TextBox();
            txt_categoryCode = new TextBox();
            groupBox2 = new GroupBox();
            txt_search = new TextBox();
            btn_find = new Button();
            grp_search = new GroupBox();
            rdb_nameBook = new RadioButton();
            rdb_code = new RadioButton();
            dgv_book = new DataGridView();
            managebookBindingSource = new BindingSource(components);
            grp_update.SuspendLayout();
            groupBox2.SuspendLayout();
            grp_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_book).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managebookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbl_code
            // 
            lbl_code.AutoSize = true;
            lbl_code.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_code.Location = new Point(23, 58);
            lbl_code.Name = "lbl_code";
            lbl_code.Size = new Size(84, 24);
            lbl_code.TabIndex = 2;
            lbl_code.Text = "Ma Sach";
            // 
            // lbl_nameBook
            // 
            lbl_nameBook.AutoSize = true;
            lbl_nameBook.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nameBook.Location = new Point(23, 121);
            lbl_nameBook.Name = "lbl_nameBook";
            lbl_nameBook.Size = new Size(92, 24);
            lbl_nameBook.TabIndex = 3;
            lbl_nameBook.Text = "Ten Sach";
            // 
            // lbl_yearPublication
            // 
            lbl_yearPublication.AutoSize = true;
            lbl_yearPublication.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yearPublication.Location = new Point(341, 57);
            lbl_yearPublication.Name = "lbl_yearPublication";
            lbl_yearPublication.Size = new Size(138, 24);
            lbl_yearPublication.TabIndex = 4;
            lbl_yearPublication.Text = "Nam Xuat Ban";
            // 
            // lbl_publisherCode
            // 
            lbl_publisherCode.AutoSize = true;
            lbl_publisherCode.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_publisherCode.Location = new Point(341, 121);
            lbl_publisherCode.Name = "lbl_publisherCode";
            lbl_publisherCode.Size = new Size(123, 24);
            lbl_publisherCode.TabIndex = 5;
            lbl_publisherCode.Text = "Ma Xuat Ban";
            // 
            // lbl_categoryCode
            // 
            lbl_categoryCode.AutoSize = true;
            lbl_categoryCode.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_categoryCode.Location = new Point(731, 123);
            lbl_categoryCode.Name = "lbl_categoryCode";
            lbl_categoryCode.Size = new Size(87, 24);
            lbl_categoryCode.TabIndex = 6;
            lbl_categoryCode.Text = "The Loai";
            // 
            // lbl_authorCode
            // 
            lbl_authorCode.AutoSize = true;
            lbl_authorCode.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_authorCode.Location = new Point(731, 58);
            lbl_authorCode.Name = "lbl_authorCode";
            lbl_authorCode.Size = new Size(109, 24);
            lbl_authorCode.TabIndex = 7;
            lbl_authorCode.Text = "Ma Tac Gia";
            // 
            // txt_code
            // 
            txt_code.Location = new Point(141, 58);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(157, 36);
            txt_code.TabIndex = 8;
            // 
            // txt_nameBook
            // 
            txt_nameBook.Location = new Point(141, 118);
            txt_nameBook.Name = "txt_nameBook";
            txt_nameBook.Size = new Size(157, 36);
            txt_nameBook.TabIndex = 9;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(23, 39);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(137, 55);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_Change
            // 
            btn_Change.Location = new Point(279, 39);
            btn_Change.Name = "btn_Change";
            btn_Change.Size = new Size(137, 55);
            btn_Change.TabIndex = 15;
            btn_Change.Text = "Change";
            btn_Change.UseVisualStyleBackColor = true;
            btn_Change.Click += btn_Change_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(530, 39);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(137, 55);
            btn_Delete.TabIndex = 16;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click_1;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(885, 39);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(137, 55);
            btn_Load.TabIndex = 17;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click_1;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(1227, 30);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(137, 55);
            btn_exit.TabIndex = 19;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // grp_update
            // 
            grp_update.Controls.Add(txt_mount);
            grp_update.Controls.Add(lbl_mount);
            grp_update.Controls.Add(cbx_codeAuthor);
            grp_update.Controls.Add(cbx_codeNXB);
            grp_update.Controls.Add(txt_publicationYear);
            grp_update.Controls.Add(lbl_code);
            grp_update.Controls.Add(lbl_nameBook);
            grp_update.Controls.Add(lbl_yearPublication);
            grp_update.Controls.Add(lbl_publisherCode);
            grp_update.Controls.Add(lbl_categoryCode);
            grp_update.Controls.Add(lbl_authorCode);
            grp_update.Controls.Add(txt_code);
            grp_update.Controls.Add(txt_categoryCode);
            grp_update.Controls.Add(txt_nameBook);
            grp_update.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grp_update.Location = new Point(40, 171);
            grp_update.Name = "grp_update";
            grp_update.Size = new Size(1419, 181);
            grp_update.TabIndex = 20;
            grp_update.TabStop = false;
            grp_update.Text = "Update Book";
            // 
            // txt_mount
            // 
            txt_mount.Location = new Point(1207, 61);
            txt_mount.Name = "txt_mount";
            txt_mount.Size = new Size(157, 36);
            txt_mount.TabIndex = 17;
            // 
            // lbl_mount
            // 
            lbl_mount.AutoSize = true;
            lbl_mount.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mount.Location = new Point(1091, 65);
            lbl_mount.Name = "lbl_mount";
            lbl_mount.Size = new Size(99, 24);
            lbl_mount.TabIndex = 16;
            lbl_mount.Text = "Số Lượng ";
            // 
            // cbx_codeAuthor
            // 
            cbx_codeAuthor.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_codeAuthor.FormattingEnabled = true;
            cbx_codeAuthor.Location = new Point(885, 58);
            cbx_codeAuthor.Name = "cbx_codeAuthor";
            cbx_codeAuthor.Size = new Size(157, 37);
            cbx_codeAuthor.TabIndex = 15;
            // 
            // cbx_codeNXB
            // 
            cbx_codeNXB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_codeNXB.FormattingEnabled = true;
            cbx_codeNXB.Location = new Point(530, 118);
            cbx_codeNXB.Name = "cbx_codeNXB";
            cbx_codeNXB.Size = new Size(157, 37);
            cbx_codeNXB.TabIndex = 14;
            cbx_codeNXB.SelectedIndexChanged += cbx_codeNXB_SelectedIndexChanged;
            // 
            // txt_publicationYear
            // 
            txt_publicationYear.Location = new Point(530, 58);
            txt_publicationYear.Name = "txt_publicationYear";
            txt_publicationYear.Size = new Size(157, 36);
            txt_publicationYear.TabIndex = 10;
            // 
            // txt_categoryCode
            // 
            txt_categoryCode.Location = new Point(885, 114);
            txt_categoryCode.Name = "txt_categoryCode";
            txt_categoryCode.Size = new Size(157, 36);
            txt_categoryCode.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_add);
            groupBox2.Controls.Add(btn_Change);
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_exit);
            groupBox2.Controls.Add(btn_Load);
            groupBox2.Location = new Point(40, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1419, 107);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(259, 62);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(683, 34);
            txt_search.TabIndex = 0;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.Location = new Point(982, 56);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(115, 47);
            btn_find.TabIndex = 1;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click_1;
            // 
            // grp_search
            // 
            grp_search.Controls.Add(rdb_nameBook);
            grp_search.Controls.Add(rdb_code);
            grp_search.Controls.Add(btn_find);
            grp_search.Controls.Add(txt_search);
            grp_search.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grp_search.Location = new Point(40, 12);
            grp_search.Name = "grp_search";
            grp_search.Size = new Size(1419, 138);
            grp_search.TabIndex = 22;
            grp_search.TabStop = false;
            grp_search.Text = "Search Book";
            // 
            // rdb_nameBook
            // 
            rdb_nameBook.AutoSize = true;
            rdb_nameBook.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_nameBook.Location = new Point(44, 87);
            rdb_nameBook.Name = "rdb_nameBook";
            rdb_nameBook.Size = new Size(127, 31);
            rdb_nameBook.TabIndex = 5;
            rdb_nameBook.TabStop = true;
            rdb_nameBook.Text = "Tên Sách";
            rdb_nameBook.UseVisualStyleBackColor = true;
            // 
            // rdb_code
            // 
            rdb_code.AutoSize = true;
            rdb_code.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_code.Location = new Point(44, 33);
            rdb_code.Name = "rdb_code";
            rdb_code.Size = new Size(119, 31);
            rdb_code.TabIndex = 4;
            rdb_code.TabStop = true;
            rdb_code.Text = "Mã Sách";
            rdb_code.UseVisualStyleBackColor = true;
            // 
            // dgv_book
            // 
            dgv_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_book.Location = new Point(40, 471);
            dgv_book.Name = "dgv_book";
            dgv_book.RowHeadersWidth = 62;
            dgv_book.RowTemplate.Height = 33;
            dgv_book.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_book.Size = new Size(1419, 369);
            dgv_book.TabIndex = 0;
            dgv_book.CellClick += dataGridView1_CellClick;
            dgv_book.CellContentClick += dataGridView1_CellContentClick;
            // 
            // managebookBindingSource
            // 
            managebookBindingSource.DataSource = typeof(Manage_book);
            // 
            // Manage_book
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 945);
            Controls.Add(dgv_book);
            Controls.Add(grp_search);
            Controls.Add(groupBox2);
            Controls.Add(grp_update);
            Name = "Manage_book";
            Text = "Manage_book";
            Load += Manage_book_Load;
            grp_update.ResumeLayout(false);
            grp_update.PerformLayout();
            groupBox2.ResumeLayout(false);
            grp_search.ResumeLayout(false);
            grp_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_book).EndInit();
            ((System.ComponentModel.ISupportInitialize)managebookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_code;
        private Label lbl_nameBook;
        private Label lbl_yearPublication;
        private Label lbl_publisherCode;
        private Label lbl_categoryCode;
        private Label lbl_authorCode;
        private TextBox txt_code;
        private TextBox txt_nameBook;
        private Button btn_add;
        private Button btn_Change;
        private Button btn_Delete;
        private Button btn_Load;
        private Button btn_exit;
        private GroupBox grp_update;
        private GroupBox groupBox2;
        private TextBox txt_search;
        private Button btn_find;
        private GroupBox grp_search;
        private DataGridView dgv_book;
        private RadioButton rdb_nameBook;
        private RadioButton rdb_code;
        private BindingSource managebookBindingSource;
        private ComboBox cbx_codeNXB;
        private ComboBox cbx_codeAuthor;
        private TextBox txt_publicationYear;
        private TextBox txt_categoryCode;
        private TextBox txt_mount;
        private Label lbl_mount;
    }
}