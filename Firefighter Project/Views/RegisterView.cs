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
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            lv.Show();
            this.Hide();
        }
    }
}
