namespace ManageLibrary
{
    partial class Form_NXB
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
            lbl_title = new Label();
            lbl_codeNXB = new Label();
            label3 = new Label();
            lbl_addressNXB = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_delete = new Button();
            btn_change = new Button();
            dgv_NXB = new DataGridView();
            txt_codeNXB = new TextBox();
            txt_addressNXB = new TextBox();
            txt_nameNXB = new TextBox();
            txt_phoneNXB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_NXB).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(267, 30);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(353, 39);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Cập Nhật Nhà Xuất Bản";
            // 
            // lbl_codeNXB
            // 
            lbl_codeNXB.AutoSize = true;
            lbl_codeNXB.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_codeNXB.Location = new Point(44, 85);
            lbl_codeNXB.Name = "lbl_codeNXB";
            lbl_codeNXB.Size = new Size(89, 27);
            lbl_codeNXB.TabIndex = 1;
            lbl_codeNXB.Text = "Mã NXB";
            lbl_codeNXB.Click += lbl_codeNXB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(523, 88);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 2;
            label3.Text = "Tên NXB";
            // 
            // lbl_addressNXB
            // 
            lbl_addressNXB.AutoSize = true;
            lbl_addressNXB.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_addressNXB.Location = new Point(44, 147);
            lbl_addressNXB.Name = "lbl_addressNXB";
            lbl_addressNXB.Size = new Size(81, 27);
            lbl_addressNXB.TabIndex = 3;
            lbl_addressNXB.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(523, 151);
            label5.Name = "label5";
            label5.Size = new Size(140, 27);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(44, 449);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(120, 45);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(275, 449);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 45);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(523, 449);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(120, 45);
            btn_change.TabIndex = 7;
            btn_change.Text = "Thay Đổi";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // dgv_NXB
            // 
            dgv_NXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NXB.Location = new Point(44, 213);
            dgv_NXB.Name = "dgv_NXB";
            dgv_NXB.RowHeadersWidth = 62;
            dgv_NXB.RowTemplate.Height = 33;
            dgv_NXB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NXB.Size = new Size(876, 209);
            dgv_NXB.TabIndex = 8;
            dgv_NXB.CellClick += dataGridView1_CellContentClick;
            dgv_NXB.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_codeNXB
            // 
            txt_codeNXB.Location = new Point(170, 84);
            txt_codeNXB.Name = "txt_codeNXB";
            txt_codeNXB.Size = new Size(184, 31);
            txt_codeNXB.TabIndex = 9;
            // 
            // txt_addressNXB
            // 
            txt_addressNXB.Location = new Point(170, 147);
            txt_addressNXB.Name = "txt_addressNXB";
            txt_addressNXB.Size = new Size(184, 31);
            txt_addressNXB.TabIndex = 10;
            // 
            // txt_nameNXB
            // 
            txt_nameNXB.Location = new Point(736, 88);
            txt_nameNXB.Name = "txt_nameNXB";
            txt_nameNXB.Size = new Size(184, 31);
            txt_nameNXB.TabIndex = 11;
            // 
            // txt_phoneNXB
            // 
            txt_phoneNXB.Location = new Point(736, 150);
            txt_phoneNXB.Name = "txt_phoneNXB";
            txt_phoneNXB.Size = new Size(184, 31);
            txt_phoneNXB.TabIndex = 12;
            // 
            // Form_NXB
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 516);
            Controls.Add(txt_phoneNXB);
            Controls.Add(txt_nameNXB);
            Controls.Add(txt_addressNXB);
            Controls.Add(txt_codeNXB);
            Controls.Add(dgv_NXB);
            Controls.Add(btn_change);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(lbl_addressNXB);
            Controls.Add(label3);
            Controls.Add(lbl_codeNXB);
            Controls.Add(lbl_title);
            Name = "Form_NXB";
            Text = "Form_NXB";
            Load += Form_NXB_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_NXB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_codeNXB;
        private Label label3;
        private Label lbl_addressNXB;
        private Label label5;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_change;
        private DataGridView dgv_NXB;
        private TextBox txt_codeNXB;
        private TextBox txt_addressNXB;
        private TextBox txt_nameNXB;
        private TextBox txt_phoneNXB;
    }
}