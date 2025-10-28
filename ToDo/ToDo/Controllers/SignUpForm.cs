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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            SignUpUserControl sf = new SignUpUserControl();
            MaximumSize = new Size(sf.Width, sf.Height+20);
            MinimumSize = new Size(sf.Width, sf.Height+20);
            CloseButtonUserControl cbc = new CloseButtonUserControl();
            cbc.Location = new Point(sf.Width - 40, 0);
            Controls.Add(cbc);
            Controls.Add(sf);
        }
    }
}
