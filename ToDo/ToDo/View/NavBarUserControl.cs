using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace ToDo.View
{
    public partial class NavBarUserControl : UserControl
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager
        .ConnectionStrings["ToDoDB"].ConnectionString;


        public NavBarUserControl()
        {
            InitializeComponent();
            Resize += (s, e) => PageResize(s, e);
            Load += (s, e) => PageResize(s, e);

        }
        public void PageResize(object s,EventArgs e)
        {
            profilePanel.Location = new Point((Width - profilePanel.Width) / 2,20);
            homePanel.Location = new Point((Width - profilePanel.Width) / 2,210);
            taskPanel.Location = new Point((Width - profilePanel.Width) / 2, 285);
            settingPannel.Location = new Point((Width - profilePanel.Width) / 2, 365);
            ShowProfile();
            MakeRounded(profilePictureBox);
        }


        public void ShowProfile()
        {
            string mailId = Controller.AuthController.GetMail();
            if (string.IsNullOrEmpty(mailId))
            {
                return;
            }
            try
            {
                using (MySqlConnection conn=new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name,ProfileImagePath  FROM Users Where email=@Email";
                    using(MySqlCommand cmd=new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", mailId);
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string photoPath = reader["ProfileImagePath"].ToString();
                                nameLabel.Text = $"Hi, {name}";
                                profilePictureBox.Image = Image.FromFile(photoPath);
                                profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeRounded(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
            pb.Region = new Region(gp);
        }

    }
}
