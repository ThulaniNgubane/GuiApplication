using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiApplication
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void SendBotton_Click(object sender, EventArgs e)
        {
            string input = UserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ResponseBox.Text = "Please enter a message.";
                UserInput.Focus();
                return;
            }

            ResponseBox.Text = GetResponse(input);

            UserInput.Clear();
            UserInput.Focus();
        }

        private string GetResponse(string input)
        {
            string question = input.ToLowerInvariant();

            if (question.Contains("hello") ||
                question.Contains("hi"))
            {
                return "Hello! How can I help you today?";
            }

            if (question.Contains("password"))
            {
                return "Use a strong, unique password for each account. " +
                       "Consider using a password manager.";
            }

            if (question.Contains("phishing"))
            {
                return "Phishing is a scam that tries to trick you " +
                       "into revealing personal information. " +
                       "Avoid suspicious links and attachments.";
            }

            if (question.Contains("help"))
            {
                return "You can ask about passwords, phishing, " +
                       "or general cybersecurity.";
            }

            return "Sorry, I don't understand. Type 'help' for topics.";
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
    
        }
    }
}