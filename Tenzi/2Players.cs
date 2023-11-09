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

        int totalScore = 0;

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the numeric value from textBox1
            if (int.TryParse(textBox1.Text, out int enteredValue))
            {
                // Add the value to the total score
                totalScore += enteredValue;

                // Update the total score display
                UpdateTotalScore();
            }
            else
            {
                // Handle the case where the entered text is not a valid integer
                MessageBox.Show("Please enter a valid integer in the textbox.");
            }
        }

        private void UpdateTotalScore()
        {
            // Update the label to display the current total score
            result1.Text = "Result1: " + totalScore;
        }

        private void result1_Click(object sender, EventArgs e)
        {
            // Display the total score in result1 when it is clicked
            UpdateTotalScore();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can choose to handle text changes in textBox1 if needed
            // For example, if you want to perform some action when the text changes.
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
