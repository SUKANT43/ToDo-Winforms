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
            FormClosing += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to close the application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                Application.Exit();
            };
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
