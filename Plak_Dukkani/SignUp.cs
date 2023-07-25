using Microsoft.VisualBasic.ApplicationServices;
using Plak_Dukkani.Context;
using Plak_Dukkani.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plak_Dukkani
{
    public partial class SignUp : Form
    {
        PlakDukkaniDbContext db = new PlakDukkaniDbContext();

        private readonly Admin admin;

        public SignUp()
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login(admin);
            login.Show();
        }

        private bool IsPasswordValid(string password)
        {
            int requiredLength = 8;
            int requiredUpperCaseCount = 2;
            int requiredLowerCaseCount = 3;
            int requiredSpecialCharCount = 2;
            if (password.Length < requiredLength)
                return false;
            if (password.Count(char.IsUpper) < requiredUpperCaseCount)
                return false;
            if (password.Count(char.IsLower) < requiredLowerCaseCount)
                return false;
            int specialCharCount = password.Count(c => "!:+*".Contains(c));
            if (specialCharCount < requiredSpecialCharCount)
                return false;
            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.UserName = txtSUUserName.Text;

            if (txtSUUserName.Text == "")
            {
                MessageBox.Show("Admin Name cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Admins.Where(a => a.UserName == ad.UserName).Count() > 0)
            {

                MessageBox.Show("This User Name has already been used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(txtSUPassword.Text))
            {

                MessageBox.Show("Password need to be minimum 8 characters, should be contains at least 3 lower case, 2 upper case and 2 \"!:+*\"special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ad.Password = Admin.HashPassword(txtSUPassword.Text);

            MessageBox.Show("Account Successfully Created!");


            db.Admins.Add(new Admin() { UserName = ad.UserName,Password = ad.Password });

            db.SaveChanges();

            this.Hide();
            Form login = new Login(admin);
            login.Show();
        }



    }
}
