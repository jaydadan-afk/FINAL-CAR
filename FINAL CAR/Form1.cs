using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace FINAL_CAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Welcome Admin!");             
                new Admin().Show();
                return;
            }

            string filePath = Path.Combine(Application.StartupPath, "users.json");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registered users found");
                return;
            }

            string json = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new();

            foreach (User u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    MessageBox.Show("Login successful!");

                    this.Hide();
                    new Register().Show();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password");
        
    }
    }
}
