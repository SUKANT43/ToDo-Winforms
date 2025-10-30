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
        string path;
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
                                 path = reader["ProfileImagePath"].ToString();
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
                MessageBox.Show("Invalid user. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @NewEmail AND Email <> @OldEmail";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NewEmail", emailTextBox.Text);
                        checkCmd.Parameters.AddWithValue("@OldEmail", mailId);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("This email is already registered with another account.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "UPDATE Users SET Name = @Name, Email = @NewEmail, ProfileImagePath = @Path WHERE Email = @OldEmail";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@NewEmail", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Path", path);
                        cmd.Parameters.AddWithValue("@OldEmail", mailId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mailId = emailTextBox.Text; 
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Profile Picture";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                        profilePictureBox.Image = Image.FromFile(path);
                        profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        MessageBox.Show("Profile picture selected successfully!", "Image Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting image: " + ex.Message,
                    "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
