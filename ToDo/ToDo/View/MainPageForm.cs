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
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1325, 1150);
            NavBarUserControl nbuc = new NavBarUserControl();
            nbuc.Dock = DockStyle.Left;
            TopBarUserControl tbuc = new TopBarUserControl();
            tbuc.Dock = DockStyle.Top;
            this.Controls.Add(tbuc);
            this.Controls.Add(nbuc);
        }
    }
}
