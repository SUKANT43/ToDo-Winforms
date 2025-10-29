using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ToDo.View
{
    public partial class LoginFormUserControl : UserControl
    {
        public event EventHandler OnNavigateToSignUp;
        private readonly string connectionString = System.Configuration.ConfigurationManager
    .ConnectionStrings["ToDoDB"].ConnectionString;

        public LoginFormUserControl()
        {
            InitializeComponent();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            OnNavigateToSignUp?.Invoke(this,EventArgs.Empty);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim().ToLower();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name, password FROM Users WHERE email=@Email";
                    using(MySqlCommand cmd=new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();
                                string name = reader["name"].ToString();
                                if (dbPassword == password)
                                {
                                    Controller.AuthController.SetMail(email);
                                    MessageBox.Show($"Hi {name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid credentials. Please check your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("No user found with this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
