using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, System.EventArgs e)
        {
          
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
            txtPassword.PasswordChar= '*';
        }

        private void pictureBoxYouTube_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YhAwNITpnno&t=1185s");
        }

        private void pictureBoxInstagram_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/loveyoustepan/");
        }

        private void pictureBoxFacebook_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ilon.mask.357284");
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            SqlConnection con = new SqlConnection();
        }
    }
}
