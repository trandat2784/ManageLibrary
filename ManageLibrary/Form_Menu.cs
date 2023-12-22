using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_logIn frm_1 = new Form_logIn();
            frm_1.ShowDialog();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_book mb_1 = new Manage_book();
            mb_1.ShowDialog();
            mb_1 = null;
            this.Show();

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_author ma_1 = new Manage_author();
            ma_1.ShowDialog();
            ma_1 = null;
            this.Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.ShowDialog();
            about = null;
            this.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NXB form_NXB = new Form_NXB();
            form_NXB.ShowDialog();
            form_NXB = null;
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int currentImageIndex = 0;
        private string[] imagePaths = {
         @"C:\Code_C#\ManageLibrary\Book\Screenshot 2023-12-09 101747.png",
         @"C:\Code_C#\ManageLibrary\Book\Screenshot 2023-12-09 101716.png",
         @"C:\Code_C#\ManageLibrary\Book\Screenshot 2023-12-09 101724.png",
         @"C:\Code_C#\ManageLibrary\Book\Screenshot 2023-12-09 105143.png"
         };


        private void timer1_Tick(object sender, EventArgs e)
        {

            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length; // Chuyển đến ảnh tiếp theo
            string imagePath = imagePaths[currentImageIndex];

            try
            {
                // Load ảnh từ đường dẫn và hiển thị nó trong PictureBox
                Image newImage = Image.FromFile(imagePath);
                Slider.Image = newImage;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Error loading image: " + ex.Message);
            }
        }

        private void muonTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Date form_Date = new Form_Date();
            form_Date.ShowDialog();
            form_Date = null;
            this.Show();
        }
    }
}
