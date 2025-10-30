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
        NavBarUserControl nbuc = new NavBarUserControl();
        TopBarUserControl tbuc = new TopBarUserControl();
        SettingUserControl suc = new SettingUserControl();

        public MainPageForm()
        {
            InitializeComponent();
            MinimumSize = new Size(1325, 1150);

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

            Resize += (s, e) => PageResize(s, e);
            Load += (s, e) => PageResize(s, e);

            tbuc.Dock = DockStyle.Top;
            nbuc.Dock = DockStyle.Left;
            suc.Dock = DockStyle.Fill;

            Controls.Add(suc);
            Controls.Add(tbuc);
            Controls.Add(nbuc);


        }

        public void PageResize(object e, EventArgs s)
        {


        }

    }
}
