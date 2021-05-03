/*
 * Maeve Wheaton
 * Mr. T
 * May 3, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        //variables
        string heroName;
        string difficultyLevel;


        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            //set button colors
            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            //assign variables
            heroName = heroNameInput.Text;
            difficultyLevel = "easy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.DarkOrange;
            hardButton.BackColor = Color.Black;

            heroName = heroNameInput.Text;
            difficultyLevel = "medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Firebrick;

            heroName = heroNameInput.Text;
            difficultyLevel = "hard";
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            welcomeMessageLabel.Text = $"Welcome {heroName}";
            welcomeMessageLabel.Text += $"\nA true brave hero! Go forth and conquer the {difficultyLevel} path!";
        }
    }
}
