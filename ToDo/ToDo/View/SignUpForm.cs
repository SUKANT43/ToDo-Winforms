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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(245, 245, 245);
           Font = new Font("Segoe UI", 10, FontStyle.Bold);
            SignUpUserControl sf = new SignUpUserControl();
            MaximumSize = new Size(sf.Width, sf.Height+10);
            MinimumSize = new Size(sf.Width, sf.Height+10);
            CloseButtonUserControl cbc = new CloseButtonUserControl();
            cbc.Location = new Point(sf.Width - 40, 0);
            Controls.Add(cbc);
            Controls.Add(sf);
        }
        public void closeForm()
        {
        }
    }
}
