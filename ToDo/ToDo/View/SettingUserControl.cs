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
namespace ToDo.View
{
    public partial class SettingUserControl : UserControl
    {
        private string mailId = Controller.AuthController.GetMail();
        private readonly string connectionString = System.Configuration.ConfigurationManager
        .ConnectionStrings["ToDoDB"].ConnectionString;

        public SettingUserControl()
        {
            InitializeComponent();
            Resize += (s, e) => UserControlResize(s, e);
            Load += (s, e) => UserControlResize(s, e);
        }

        public void UserControlResize(object s,EventArgs e)
        {
            sizeControlPanel.Location = new Point(
                    (mainPanel.Width - sizeControlPanel.Width) / 2,
                    ((mainPanel.Height - sizeControlPanel.Height) / 2)-50
                    );
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, Email, ProfileImagePath FROM Users WHERE Email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", mailId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string email = reader["Email"].ToString();
                                string path = reader["ProfileImagePath"].ToString();
                                nameTextBox.Text = name;
                                emailTextBox.Text = email;
                                profilePictureBox.Image = Image.FromFile(path);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mailId))
            {
                return;
            }
        }
    }
}
