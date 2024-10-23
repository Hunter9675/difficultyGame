using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace difficultyGame
{
    public partial class Form1 : Form
    {
        string user;
        string difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            user = usernameInput.Text;
            difficultyLevel = "easy";

            BackColor = Color.LightGreen;

            titleLabel.ForeColor = Color.Black;

            usernameOutputAndDifficultyOutput.ForeColor = Color.Black;

            usernameInputLabel.ForeColor = Color.Black;

        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            user = usernameInput.Text;
            difficultyLevel = "normal";

            BackColor = Color.LightBlue;

            titleLabel.ForeColor = Color.Black;

            usernameOutputAndDifficultyOutput.ForeColor = Color.Black;

            usernameInputLabel.ForeColor = Color.Black;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            user = usernameInput.Text;
            difficultyLevel = "HARD";

            BackColor = Color.DarkRed;

            titleLabel.ForeColor = Color.White;

            usernameOutputAndDifficultyOutput.ForeColor = Color.White;

            usernameInputLabel.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernameOutputAndDifficultyOutput.Text = $"Hello {user}! You are playing in {difficultyLevel} mode!";

           


        }
    }
}
