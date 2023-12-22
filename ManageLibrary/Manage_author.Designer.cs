namespace ManageLibrary
{
    partial class Manage_author
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
            lbl_manageAuthor = new Label();
            lbl_codeAuthor = new Label();
            lbl_nameAuthor = new Label();
            dgv_author = new DataGridView();
            btn_add = new Button();
            btn_delete = new Button();
            btn_change = new Button();
            txt_nameAuthor = new TextBox();
            txt_codeAuthor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_author).BeginInit();
            SuspendLayout();
            // 
            // lbl_manageAuthor
            // 
            lbl_manageAuthor.AutoSize = true;
            lbl_manageAuthor.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_manageAuthor.ForeColor = Color.FromArgb(116, 86, 174);
            lbl_manageAuthor.Location = new Point(286, 26);
            lbl_manageAuthor.Name = "lbl_manageAuthor";
            lbl_manageAuthor.Size = new Size(276, 38);
            lbl_manageAuthor.TabIndex = 0;
            lbl_manageAuthor.Text = "Athor Managament";
            // 
            // lbl_codeAuthor
            // 
            lbl_codeAuthor.AutoSize = true;
            lbl_codeAuthor.Font = new Font("#9Slide03 Bebas Neue ZSmall", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_codeAuthor.ForeColor = Color.Gray;
            lbl_codeAuthor.Location = new Point(111, 95);
            lbl_codeAuthor.Name = "lbl_codeAuthor";
            lbl_codeAuthor.Size = new Size(93, 26);
            lbl_codeAuthor.TabIndex = 1;
            lbl_codeAuthor.Text = "Mã Tác Giả";
            // 
            // lbl_nameAuthor
            // 
            lbl_nameAuthor.AutoSize = true;
            lbl_nameAuthor.Font = new Font("#9Slide03 Bebas Neue ZSmall", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nameAuthor.ForeColor = Color.Gray;
            lbl_nameAuthor.Location = new Point(106, 168);
            lbl_nameAuthor.Name = "lbl_nameAuthor";
            lbl_nameAuthor.Size = new Size(98, 26);
            lbl_nameAuthor.TabIndex = 2;
            lbl_nameAuthor.Text = "Tên Tác Giả";
            // 
            // dgv_author
            // 
            dgv_author.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_author.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_author.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_author.Location = new Point(60, 330);
            dgv_author.Name = "dgv_author";
            dgv_author.RowHeadersWidth = 62;
            dgv_author.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_author.Size = new Size(663, 225);
            dgv_author.TabIndex = 3;
            dgv_author.CellClick += dgv_author_CellContentClick;
            dgv_author.CellContentClick += dgv_author_CellContentClick;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(116, 86, 174);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("#9Slide03 Bebas Neue ZSmall", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.Transparent;
            btn_add.Location = new Point(566, 95);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 46);
            btn_add.TabIndex = 4;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("#9Slide03 Bebas Neue ZSmall", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.FromArgb(116, 86, 174);
            btn_delete.Location = new Point(566, 160);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 41);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Xóa ";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_change
            // 
            btn_change.FlatStyle = FlatStyle.Flat;
            btn_change.Font = new Font("#9Slide03 Bebas Neue ZSmall", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.ForeColor = Color.FromArgb(116, 86, 174);
            btn_change.Location = new Point(566, 221);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(112, 43);
            btn_change.TabIndex = 6;
            btn_change.Text = "Thay đổi";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // txt_nameAuthor
            // 
            txt_nameAuthor.BackColor = Color.LightGray;
            txt_nameAuthor.BorderStyle = BorderStyle.None;
            txt_nameAuthor.Font = new Font("#9Slide03 Bebas Neue ZSmall", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nameAuthor.Location = new Point(111, 197);
            txt_nameAuthor.Multiline = true;
            txt_nameAuthor.Name = "txt_nameAuthor";
            txt_nameAuthor.Size = new Size(260, 31);
            txt_nameAuthor.TabIndex = 7;
            // 
            // txt_codeAuthor
            // 
            txt_codeAuthor.BackColor = Color.LightGray;
            txt_codeAuthor.BorderStyle = BorderStyle.None;
            txt_codeAuthor.Font = new Font("#9Slide03 Arima Madurai ExtraBo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_codeAuthor.Location = new Point(111, 124);
            txt_codeAuthor.Multiline = true;
            txt_codeAuthor.Name = "txt_codeAuthor";
            txt_codeAuthor.Size = new Size(260, 31);
            txt_codeAuthor.TabIndex = 8;
            // 
            // Manage_author
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 599);
            Controls.Add(txt_codeAuthor);
            Controls.Add(txt_nameAuthor);
            Controls.Add(btn_change);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(dgv_author);
            Controls.Add(lbl_nameAuthor);
            Controls.Add(lbl_codeAuthor);
            Controls.Add(lbl_manageAuthor);
            ForeColor = Color.FromArgb(164, 165, 169);
            MinimizeBox = false;
            Name = "Manage_author";
            Text = "Manage_author";
            Load += Manage_author_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_author).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_manageAuthor;
        private Label lbl_codeAuthor;
        private Label lbl_nameAuthor;
        private DataGridView dgv_author;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_change;
        private TextBox txt_nameAuthor;
        private TextBox txt_codeAuthor;
    }
}