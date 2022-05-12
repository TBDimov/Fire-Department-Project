using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firefighter_Project.Views
{
    public partial class ForgottenPassView : Form
    {
        public ForgottenPassView()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            lv.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgottenPassView_Load(object sender, EventArgs e)
        {

        }
    }
}
