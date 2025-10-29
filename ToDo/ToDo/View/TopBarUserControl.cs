using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.View
{
    public partial class TopBarUserControl : UserControl
    {
        public TopBarUserControl()
        {
            InitializeComponent();
            Resize+= (s,e) => PageResize(s,e);
        }

        public void PageResize(object s,EventArgs e)
        {
            titleLabel.Location = new Point(
                (Width-titleLabel.Width)/2,
                (Height-titleLabel.Height)/2
                );
        }
    }
}
