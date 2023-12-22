namespace ManageLibrary
{
    public partial class Form_logIn : Form
    {
        public Form_logIn()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" && txt_password.Text == "")
            {
                errorProvider1.SetError(txt_name, "Don't blank");
                errorProvider2.SetError(txt_password, "Don't blank");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
            }



            if (txt_name.Text == "admin" && txt_password.Text == "123")
            {
                this.Hide();
                Form_Menu form_Menu = new Form_Menu();
                form_Menu.ShowDialog();
                this.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}