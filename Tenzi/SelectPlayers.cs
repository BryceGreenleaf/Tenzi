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
    public partial class SelectPlayers : Form
    {
        public SelectPlayers()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            // Create an instance of the StartScreen form
            Start startForm = new Start();

            // Show the StartScreen form
            startForm.Show();

            // Optionally, close the current form
            this.Close();
        }


        private void btn_2players_Click(object sender, EventArgs e)
        {
            _2_Players _2Players = new _2_Players();

            _2Players.Show();

            this.Close();
        }
    }
}
