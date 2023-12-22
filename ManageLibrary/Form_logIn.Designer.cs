namespace ManageLibrary
{
    partial class Form_logIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_login = new Label();
            txt_name = new TextBox();
            txt_password = new TextBox();
            lbl_name = new Label();
            lbl_password = new Label();
            btn_login = new Button();
            btn_exit = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.Font = new Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.FromArgb(116, 86, 174);
            lbl_login.Location = new Point(244, 19);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(176, 68);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Log In";
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.LightGray;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(103, 112);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(377, 50);
            txt_name.TabIndex = 1;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.LightGray;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(103, 198);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(377, 50);
            txt_password.TabIndex = 2;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("#9Slide03 Bebas Neue ZSmall", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.Gray;
            lbl_name.Location = new Point(103, 84);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(63, 25);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            lbl_password.Font = new Font("#9Slide03 Bebas Neue ZSmall", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Gray;
            lbl_password.Location = new Point(103, 174);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(84, 21);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(116, 86, 174);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(144, 275);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(133, 64);
            btn_login.TabIndex = 5;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.FromArgb(116, 86, 174);
            btn_exit.Location = new Point(331, 275);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(133, 64);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form_logIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(608, 415);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(lbl_password);
            Controls.Add(lbl_name);
            Controls.Add(txt_password);
            Controls.Add(txt_name);
            Controls.Add(lbl_login);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_logIn";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private TextBox txt_name;
        private TextBox txt_password;
        private Label lbl_name;
        private Label lbl_password;
        private Button btn_login;
        private Button btn_exit;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}