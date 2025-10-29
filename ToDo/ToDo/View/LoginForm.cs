using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            LoginFormUserControl luc = new LoginFormUserControl();
            CloseButtonUserControl cbuc = new CloseButtonUserControl();
            luc.OnNavigateToSignUp += Sf_OnNavigateToSignUp;
            luc.OnNavigateToMainPage += Sf_OnNavigateToMainPage;
            cbuc.Location = new Point(luc.Width - 35, 0);
            Controls.Add(cbuc);
            MaximumSize = new Size(luc.Width, luc.Height);
            MinimumSize = new Size(luc.Width, luc.Height);
            Controls.Add(luc);
        }

        public void Sf_OnNavigateToSignUp(Object s,EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            sf.Show();
        }

        public void Sf_OnNavigateToMainPage(object s, EventArgs e)
        {
            MainPageForm mpf = new MainPageForm();
            mpf.Show();
        }
    }
}