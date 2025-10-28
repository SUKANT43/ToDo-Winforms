using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.Controllers
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            LoginFormUserControl luc = new LoginFormUserControl();
            CloseButtonUserControl cbuc = new CloseButtonUserControl();
            cbuc.Location = new Point(luc.Width-35,0);
            Controls.Add(cbuc);
            MaximumSize = new Size(luc.Width, luc.Height);
            MinimumSize = new Size(luc.Width, luc.Height);
            Controls.Add(luc);
        }
    }
}
