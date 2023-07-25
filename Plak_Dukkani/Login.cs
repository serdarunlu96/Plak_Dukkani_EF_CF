using Microsoft.EntityFrameworkCore;
using Plak_Dukkani.Context;
using Plak_Dukkani.Data;

namespace Plak_Dukkani
{
    public partial class Login : Form
    {
        PlakDukkaniDbContext db = new PlakDukkaniDbContext();
        
        private readonly Admin admin;

        public Login(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "")
            {
                MessageBox.Show("User Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (db.Admins.Where(u => u.UserName == txtUserName.Text).Count() == 0)
            {
                MessageBox.Show("This UserName is not registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Admins.FirstOrDefault(a => a.UserName == txtUserName.Text);

            if (user != null && user.Password == Admin.HashPassword(txtPassword.Text))
            {
                this.Hide();
                Form albumMan = new AlbumManagement(admin);
                albumMan.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password or UserName. Please check and re-enter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
        }


    }
}