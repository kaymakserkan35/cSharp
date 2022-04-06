using Admin_Member_Login.Data;
using Admin_Member_Login.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Member_Login
{
    public partial class MainForm : Form
    {
        Database db;
        public MainForm()
        {
            InitializeComponent();
            db = new Database();
        }
        private void GetUserFromLoginForm()
        {
            string password = this.PasswordTxtBox.Text;
            string username = this.UserNameTxtBox.Text;
            bool rememberme = this.RememberMeChckBox.Checked;
        }

        private User GetUserFromDB()
        {
            string password = this.PasswordTxtBox.Text;
            string username = this.UserNameTxtBox.Text;
            bool rememberme = this.RememberMeChckBox.Checked;

            var user = this.db.Users.FirstOrDefault(USER => USER.Name == username && USER.Password == password);
            if (user.RememberMe != rememberme)
            {
                user.RememberMe = rememberme;
                // update et..
            }

            return user;
        }
    }
}
