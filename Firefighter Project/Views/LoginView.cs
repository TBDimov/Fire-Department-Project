using Firefighter_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firefighter_Project
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            rv.Show();
            this.Hide();
        }

        private void ForgotPassBtn_Click(object sender, EventArgs e)
        {
            ForgottenPassView fpv = new ForgottenPassView();
            fpv.Show();
            this.Hide();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
