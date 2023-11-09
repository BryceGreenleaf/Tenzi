using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenzi
{
    public partial class _2_Players : Form
    {
        public _2_Players()
        {
            InitializeComponent();
        }




        //----------------------------------------------------------

        // Initialize total scores for each player
        int totalScore = 0;
        int totalScore2 = 0;

        // Player 1 Add Button Click Event
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Try to parse the text from textBox1 to an integer
            if (int.TryParse(textBox1.Text, out int enteredValue))
            {
                // Add the parsed value to the total score for Player 1
                totalScore += enteredValue;

                // Update the total score display for Player 1
                UpdateTotalScore();

                // Reset textBox1 to an empty string
                textBox1.Text = string.Empty;
            }
            else
            {
                // Display a message if the entered text is not a valid integer
                MessageBox.Show("Player 1: Please enter a valid integer in the textbox.");
            }
        }

        // Update Total Score for Player 1
        private void UpdateTotalScore()
        {
            // Update the label to display the current total score for Player 1
            result1.Text = "Player 1 Total Score: " + totalScore;

            // Check if Player 1 has won
            if (totalScore >= 100)
            {
                // Show a message indicating that Player 2 has won
                ShowWinnerMessage("Player 2");

                // Reset the scores for a new game
                ResetScores();
            }
        }

        // Player 1 Result Label Click Event
        private void result1_Click(object sender, EventArgs e)
        {
            // Display the total score for Player 1 when the result label is clicked
            UpdateTotalScore();
        }

        // Player 1 Textbox Text Changed Event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes for Player 1 if needed
        }

        // Player 2 Add Button Click Event
        private void addBtn2_Click(object sender, EventArgs e)
        {
            // Try to parse the text from textBox2 to an integer
            if (int.TryParse(textBox2.Text, out int enteredValue2))
            {
                // Add the parsed value to the total score for Player 2
                totalScore2 += enteredValue2;

                // Update the total score display for Player 2
                UpdateTotalScore2();

                // Reset textBox2 to an empty string
                textBox2.Text = string.Empty;
            }
            else
            {
                // Display a message if the entered text is not a valid integer
                MessageBox.Show("Player 2: Please enter a valid integer in the textbox.");
            }
        }

        // Update Total Score for Player 2
        private void UpdateTotalScore2()
        {
            // Update the label to display the current total score for Player 2
            result2.Text = "Player 2 Total Score: " + totalScore2;

            // Check if Player 2 has won
            if (totalScore2 >= 100)
            {
                // Show a message indicating that Player 1 has won
                ShowWinnerMessage("Player 1");

                // Reset the scores for a new game
                ResetScores();
            }
        }

        // Player 2 Result Label Click Event
        private void result2_Click(object sender, EventArgs e)
        {
            // Display the total score for Player 2 when the result label is clicked
            UpdateTotalScore2();
        }

        // Player 2 Textbox Text Changed Event
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes for Player 2 if needed
        }

        // Reset Scores and Optionally Restart Application
        private void ResetScores()
        {
            // Ask the user if they want to restart the game
            DialogResult dialogResult = MessageBox.Show("The game has ended. Do you want to restart?", "Game Over", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Reset the scores for a new game
                totalScore = 0;
                totalScore2 = 0;
                UpdateTotalScore();
                UpdateTotalScore2();
            }
            else
            {
                // Optionally handle the case where the user chooses not to restart
            }
        }

        // Show Winner Message
        private void ShowWinnerMessage(string winner)
        {
            // Display a message box with the winner
            MessageBox.Show($"{winner} has won!", "Game Over");
        }


        //-------------------------------------------------------------

        private void _2_Players_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of the SelectPlayers form
            SelectPlayers selectPlayersForm = new SelectPlayers();

            // Show the SelectPlayers form
            selectPlayersForm.Show();

            // Optionally, close the current form
            this.Close();
        }

        
    }
}
