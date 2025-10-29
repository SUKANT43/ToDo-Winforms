using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ToDo.View
{
    public partial class SignUpUserControl : UserControl
    {
        public event EventHandler OnNavigateToLogin;
        private string imagePath;
        private readonly string connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["ToDoDB"].ConnectionString;

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
                    userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim().ToLower();
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

            try
            {
                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();


                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("User with this email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    string query = "INSERT INTO Users(Name, Email, Password, ProfileImagePath) VALUES(@Name,@Email,@Password,@ProfileImagePath)";
                    using(MySqlCommand cmd=new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ProfileImagePath", imagePath);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nameTextBox.Clear();
                    emailTextBox.Clear();
                    passwordTextBox.Clear();
                    confirmPasswordTextBox.Clear();
                    userPictureBox.Image = null;
                    imagePath = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alreadyHaveAnAccountLabel_Click(object sender, EventArgs e)
        {
            OnNavigateToLogin?.Invoke(this, EventArgs.Empty);
        }
    }
}
