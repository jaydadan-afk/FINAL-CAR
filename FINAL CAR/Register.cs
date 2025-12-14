using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FINAL_CAR
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirmPass.Text.Trim();
           

            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }


            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }


            if (password.ToLower().Contains(username.ToLower()))
            {
                MessageBox.Show("Password must not contain the username");
                return;
            }


            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string filePath = "users.json";
            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }

            // Username uniqueness check
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
            }

            users.Add(new User
            {
                Username = username,
                Password = password
            });

            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Registration successful!");

            this.Hide();
            new Customer().Show();
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            new Form1().Show();
        }
    }
}
