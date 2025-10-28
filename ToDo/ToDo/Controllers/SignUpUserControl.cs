using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ToDo.Controllers
{
    public partial class SignUpUserControl : UserControl
    {
        private string imagePath;

        private readonly string usersFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Users"
        );


        public SignUpUserControl()
        {
            InitializeComponent();
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog())
            {
                openFileDialog.Title = "Select Profile Picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    userPictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (imagePath == null)
            {
                MessageBox.Show("Choose Profile Picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var invalids = Path.GetInvalidFileNameChars();
            string safeFileName = string.Concat(email.Select(c => invalids.Contains(c) ? '_' : c));
            string userFile = Path.Combine(usersFolder, safeFileName + ".json");

            if (File.Exists(userFile))
            {
                MessageBox.Show("User with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new Model.UserCredentialsModel
            {
                Name = name,
                Email = email,
                Password = password,
                ProfileImagePath = imagePath ?? string.Empty,
                CreatedAt = DateTime.UtcNow
            };

            try
            {
                string json = JsonConvert.SerializeObject(user, Formatting.Indented);
                File.WriteAllText(userFile, json);

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTextBox.Clear();
                emailTextBox.Clear();
                passwordTextBox.Clear();
                confirmPasswordTextBox.Clear();
                userPictureBox.Image = null;
                imagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
